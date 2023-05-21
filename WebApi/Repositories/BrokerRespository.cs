using Microsoft.EntityFrameworkCore;
using WebApi.Migrations;
using WebApi.Models.Broker;
using WebApi.Models.Interfaces;

namespace WebApi.Repositories
{
    public class BrokerRespository : IBrokerRepository
    {
        private readonly AppDbContext _appDbContext;

        public BrokerRespository(AppDbContext appDbContext)
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

        public async Task AddBroker(Broker broker)
        {
            _appDbContext.Add(broker);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
