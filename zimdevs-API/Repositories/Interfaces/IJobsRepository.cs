using System.Collections.Generic;
using System.Threading.Tasks;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Repositories.Implementations
{
    public interface IJobsRepository
    {
        Task<IEnumerable<Job>> GetJobs(int? statusId = 1);

        Task<IEnumerable<Job>> GetJobsByCompany(int companyId);


        void PostJob(Job job);

        Task<Job> UpdateJob(Job job);

        void AddJobApplication(Application application);

        Task<Application> UpdateApplication(Application application);

        Task<ShortList> GetShortList(Job job);

    }
}