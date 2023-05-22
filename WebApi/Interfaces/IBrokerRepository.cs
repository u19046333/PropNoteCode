using WebApi.Models.Broker;

namespace WebApi.Models.Interfaces
{
    public interface IBrokerRepository
    {

        Task<bool> SaveChangesAsync();
        Task AddBroker(WebApi.Models.Broker.Broker broker);
        Task<WebApi.Models.Broker.Broker[]> GetAllBrokersAsync();
        Task EditBroker(int brokerId, WebApi.Models.Broker.Broker broker);
        Task DeleteBrokerAsync(WebApi.Models.Broker.Broker broker);
        void Delete<T>(T entity) where T : class;
        Task<WebApi.Models.Broker.Broker> GetBrokerByID(int brokerID);
    }
}
