using ContactManagerApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerApp.Repository
{
    public class ContactDbRepository : IRepository<Contact, int>
    {
        private readonly DbContext dbContext;

        public ContactDbRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<int> CreateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Contact entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Contact>> GetAllAsync()
        {
            return dbContext.Set<Contact>().ToListAsync();
        }

        public Task<Contact> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Contact entity)
        {
            throw new NotImplementedException();
        }
    }
}
