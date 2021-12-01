using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Generic;
using System.Linq;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.Application.Filters
{
    public class ModelStateValidationFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var response = new ExecutedResult<IEnumerable<string>>
                {
                    Response = ResponseCode.ValidationError
                };
                var message = context.ModelState.Values.SelectMany(a => a.Errors).Select(e => e.ErrorMessage);
                var lst = new List<string>();
                lst.AddRange(message);
                response.Message = lst.FirstOrDefault();
                response.ValidationMessages = lst;
                context.Result = new BadRequestObjectResult(response);
            }
        }
    }
}
