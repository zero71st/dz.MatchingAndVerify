using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.Core.Entities
{
    public class MatchingTemplateItem:BaseEntity
    {
        public string DisplayName { get; set; }
        public string FieldName { get; set; }
        public int Offset { get; set; }
        public int Length { get; set; }

        public int MachingTemplateId { get; set; }
        public virtual MatchingTemplate MatchingTemplate { get; set; }
    }
}