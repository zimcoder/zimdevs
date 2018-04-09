using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models.Entities;
using zimdevsapi.Repositories.Interfaces;

namespace zimdevsapi.Repositories.Implementations
{
    public class DeveloperRepository : IDeveloperRepository
    {
        public ZimDevsDbContext Context { get; }
        public DeveloperRepository(ZimDevsDbContext context)
        {
            Context = context;
        }

        public async Task<IEnumerable<Developer>> GetDevelopers()
        {
            return await Context.Developers.ToListAsync();
        }

        public void AddDeveloper(Developer developer)
        {
            Context.Developers.Add(developer);
        }

    }
}
