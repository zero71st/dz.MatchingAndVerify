using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Entities
{
    public class MatchingJobItem:BaseEntity
    {
        public int JobItemId { get; set; }
        public Status Status { get; set; }

        public string MatchingBy { get; set; }
        public DateTime MatchingDate { get; set; }
    }
}
