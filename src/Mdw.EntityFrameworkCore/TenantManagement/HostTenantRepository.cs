using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Mdw.TenantManagement
{
    public class HostTenantRepository : EfCoreRepository<TenantManagementDbContext, Tenant, Guid>, IHostTenantRepository
    {
        public HostTenantRepository(IDbContextProvider<TenantManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Tenant> GetTenantByHost(string host, CancellationToken cancellationToken = default)
        {
            var context = await GetDbContextAsync();
            var tenant = context.Tenants
                .Where(u => EF.Property<string>(u, "Host") == host);
            return await tenant.FirstOrDefaultAsync(cancellationToken: cancellationToken);
        }
    }
}
