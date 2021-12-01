using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;

namespace Thynk.Covid19Pcr.Application.Extensions
{
    public static class FacadeExtensions
    {
        public static IEnumerable<T> GetModelFromSqlQuery<T>(this DatabaseFacade databaseFacade, string sql, params object[] parameters)
            where T : new()
        {
            using (DbDataReader dr = databaseFacade.ExecuteSqlQuery(sql, parameters).DbDataReader)
            {
                List<T> lst = new();
                PropertyInfo[] props = typeof(T).GetProperties();
                while (dr.Read())
                {
                    T t = new();
                    IEnumerable<string> actualNames = dr.GetColumnSchema().Select(o => o.ColumnName);
                    for (int i = 0; i < props.Length; ++i)
                    {
                        PropertyInfo pi = props[i];

                        if (!pi.CanWrite)
                        {
                            continue;
                        }

                        System.ComponentModel.DataAnnotations.Schema.ColumnAttribute ca = pi.GetCustomAttribute(typeof(System.ComponentModel.DataAnnotations.Schema.ColumnAttribute)) as System.ComponentModel.DataAnnotations.Schema.ColumnAttribute;
                        string name = ca?.Name ?? pi.Name;

                        if (pi == null)
                        {
                            continue;
                        }

                        if (!actualNames.Contains(name))
                        {
                            continue;
                        }
                        object value = dr[name];
                        Type pt = pi.DeclaringType;
                        bool nullable = pt.GetTypeInfo().IsGenericType && pt.GetGenericTypeDefinition() == typeof(Nullable<>);
                        if (value == DBNull.Value)
                        {
                            value = null;
                        }
                        if (value == null && pt.GetTypeInfo().IsValueType && !nullable)
                        {
                            value = Activator.CreateInstance(pt);
                        }
                        pi.SetValue(t, value);
                    }
                    lst.Add(t);
                }
                return lst;
            }
        }

        public static RelationalDataReader ExecuteSqlQuery(this DatabaseFacade databaseFacade, string sql, params object[] parameters)
        {
            var concurrencyDetector = databaseFacade.GetService<IConcurrencyDetector>();

            using (concurrencyDetector.EnterCriticalSection())
            {
                var rawSqlCommand = databaseFacade
                    .GetService<IRawSqlCommandBuilder>()
                    .Build(sql, parameters);

                var paramObject = new RelationalCommandParameterObject(databaseFacade.GetService<IRelationalConnection>(), rawSqlCommand.ParameterValues, null, null, null);

                return rawSqlCommand
                    .RelationalCommand
                    .ExecuteReader(paramObject);
            }
        }
    }
}
