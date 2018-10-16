using dz.MatchingAndVerify.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MachingAndVerify.MySqlDb.Data
{
    public class MatchingAndVerifyDb:DbContext
    {
        public MatchingAndVerifyDb():base("MatchingAndVerifyDb")
        {

        }
        public virtual DbSet<MatchingJob> MatchingJobs { get; set; }
        public virtual DbSet<MatchingJobItem> MatchingJobItems { get; set; }
        public virtual DbSet<MatchingTemplate> MatchingTemplates { get; set; }
        public virtual DbSet<MatchingTemplateItem> MatchingTemplateItems { get; set; }
    }
}
