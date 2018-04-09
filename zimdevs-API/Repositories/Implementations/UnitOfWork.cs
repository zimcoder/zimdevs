using System.Threading.Tasks;
using zimdevsapi.Models;

namespace zimdevsapi.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWok
    {
        public UnitOfWork(ZimDevsDbContext context)
        {
            Context = context;
        }
        public ZimDevsDbContext Context { get; }
        public async Task CompleteAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
