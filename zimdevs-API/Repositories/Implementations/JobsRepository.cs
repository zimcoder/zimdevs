using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zimdevsapi.Models.Entities;

namespace zimdevsapi.Repositories.Implementations
{
    public class JobsRepository : IJobsRepository
    {
        public JobsRepository(ZimDevsDbContext context)
        {
            Context = context;
        }

        public async Task<IEnumerable<Job>> GetJobs()
        {
            return await Context.Jobs.ToListAsync();
        }

        public Task<IEnumerable<Job>> GetJobs(int? statusId = 1)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Job>> GetJobsByCompany(int companyId)
        {
            return await Context.Jobs.Where(j => j.Company.Id == companyId).ToListAsync();
        }

        public void PostJob(Job job)
        {
            Context.Jobs.Add(job);
        }

        public Task<Job> UpdateJob(Job job)
        {
            throw new System.NotImplementedException();
        }

        public void AddJobApplication(Application application)
        {
            Context.Applications.Add(application);
        }

        public Task<Application> UpdateApplication(Application application)
        {
            throw new System.NotImplementedException();
        }

        public Task<ShortList> GetShortList(Job job)
        {
            throw new System.NotImplementedException();
        }

        public ZimDevsDbContext Context { get; }
    }
}
