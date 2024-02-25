using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using Volo.Abp.MultiTenancy;

namespace Mdw.TenantManagement
{
    public class HostTenantResolveContributor : TenantResolveContributorBase
    {
        public override async Task ResolveAsync(ITenantResolveContext context)
        {
            var currentContextAccessor = context.ServiceProvider.GetRequiredService<IHttpContextAccessor>();
            var tenantRepository = context.ServiceProvider.GetRequiredService<IHostTenantRepository>();

            var host = currentContextAccessor?.HttpContext?.Request.Host.Host;
            if (tenantRepository != null)
            {
                var tenant = await tenantRepository.GetTenantByHost(host);

                if (tenant != null)
                {
                    context.TenantIdOrName = tenant.Name;
                }
            }
        }

        public override string Name => "Host";
    }

}
