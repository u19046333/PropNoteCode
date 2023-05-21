using WebApi.Models.Broker;
namespace WebApi.Models.Interfaces
{
    public interface IBrokerRepository
    {

        Task<bool> SaveChangesAsync();
        Task AddBroker(WebApi.Models.Broker.Broker broker);
        Task<WebApi.Models.Broker.Broker[]> GetAllBrokersAsync();
    }
}
