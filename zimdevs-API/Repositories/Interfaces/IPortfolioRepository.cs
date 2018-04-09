using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Repositories.Interfaces
{
    public interface IPortfolioRepository
    {
        Task<IEnumerable<Project>> GetDeveloperPortfolio(int developerId);
        Task<Project> GetProject(int projectId);
        void AddPoject(Project project);

        void UpdateProject(Project project);

        void Remove(Project project);
    }
}
