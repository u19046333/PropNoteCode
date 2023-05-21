using WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class Repository : IRepository
    {
        private readonly AppDbContext _appDbContext;

        public Repository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _appDbContext.Add(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return await _appDbContext.SaveChangesAsync() > 0;
        }

        public async Task<Broker[]> GetAllBrokersAsync()
        {
            IQueryable<Broker> query = _appDbContext.Brokers;
            return await query.ToArrayAsync();
        }

        public async Task<Tenant[]> GetAllTenantsAsync()
        {
            IQueryable<Tenant> query = _appDbContext.Tenants;

            return await query.ToArrayAsync();
        }

        public async Task<Property[]> GetAllPropertiesAsync()
        {
            IQueryable<Property> query = _appDbContext.Properties.Include(x => x.Broker);
            return await query.ToArrayAsync();
        }

        public async Task<Lease[]> GetAllLeasesAsync()
        {
            IQueryable<Lease> query = _appDbContext.Leases.Include(x => x.Property).Include(x => x.Tenant);
            return await query.ToArrayAsync();
        }


        public async Task AddBroker(Broker broker)
        {
            _appDbContext.Add(broker);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task AddProperty(Property property)
        {
            _appDbContext.Add(property);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task AddLease(Lease lease)
        {
            _appDbContext.Add(lease);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
