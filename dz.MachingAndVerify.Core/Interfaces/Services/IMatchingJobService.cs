using dz.MatchingAndVerify.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Interfaces.Services
{
    public interface IMatchingJobService
    {
        void CreateJob(MatchingJob job);
        void DeleteJob(int jobId);
        IEnumerable<MatchingJob> ListJobs();
    }
}
