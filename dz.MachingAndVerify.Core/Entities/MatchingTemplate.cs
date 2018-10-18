using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Entities
{
    public class MatchingTemplate:BaseEntity
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int JobSampleId { get; set; }
        public string Name { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual List<MatchingTemplateItem> Components { get; set; }

        public MatchingTemplate()
        {
            Components = new List<MatchingTemplateItem>();
            CreateDate = DateTime.Today;
        }

        public MatchingTemplate(int customerId,int productId,int uidJobId,string name,string createBy):this()
        {
            CustomerId = customerId;
            ProductId = productId;
            JobSampleId = uidJobId;
            Name = name;
            CreateBy = createBy;
        }
    }
}
