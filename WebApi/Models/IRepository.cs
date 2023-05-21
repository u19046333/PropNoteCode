using WebApi.Models;

namespace WebApi.Models
{
    public interface IRepository
    {
        Task<bool> SaveChangesAsync();

        void Add<T>(T entity) where T : class;

        Task<Broker[]> GetAllBrokersAsync();

        Task<Property[]> GetAllPropertiesAsync();

        Task<Tenant[]> GetAllTenantsAsync();
        Task<Lease[]> GetAllLeasesAsync();

        Task AddBroker(Broker broker);

        Task AddProperty(Property property);

        Task AddLease(Lease lease);


    }
}
