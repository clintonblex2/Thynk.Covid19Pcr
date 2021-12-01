using Hangfire.Annotations;
using Hangfire.Dashboard;

namespace Thynk.Covid19Pcr.Application.Filters
{
    public class HangfireDashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public HangfireDashboardAuthorizationFilter()
        {
        }
        public bool Authorize([NotNull] DashboardContext context)
        {
            return true;
        }
    }
}
