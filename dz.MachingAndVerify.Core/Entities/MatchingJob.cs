using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Entities
{
    public class MatchingJob:BaseEntity
    {
        public int CusotomerId { get; set; }
        public int ProductId { get; set; }
        public int JobId { get; set; }

        public int MatchingTemplateId { get; set; }
        public virtual MatchingTemplate MatchingTemplate { get; set; }

        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
