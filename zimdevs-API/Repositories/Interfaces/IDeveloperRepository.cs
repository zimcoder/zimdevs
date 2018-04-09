using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Repositories.Interfaces
{
    public interface IDeveloperRepository
    {
        Task<IEnumerable<Developer>> GetDevelopers();
    }
}