using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using dz.MatchingAndVerify.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Services
{
    public class MatchingJobService:IMatchingJobService
    {
        private readonly IRepository<MatchingJob> _jobRepository;

        public MatchingJobService(IRepository<MatchingJob> jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public void CreateJob(MatchingJob job)
        {
            _jobRepository.Add(job);
        }

        public void DeleteJob(int jobId)
        {
            var job = _jobRepository.GetById(jobId);

            _jobRepository.Delete(job);
        }

        public IEnumerable<MatchingJob> ListJobs()
        {
            return _jobRepository.GetAll().AsEnumerable();
        }
    }
}
