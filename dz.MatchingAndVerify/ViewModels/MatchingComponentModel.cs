using dz.MatchingAndVerify.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz.MatchingAndVerify.ViewModels
{
    public class MatchingComponentModel
    {
        public int JobItemId { get; set; }
        public string Component1 { get; set; }
        public string Component2 { get; set; }
        public string Component3 { get; set; }
        public string Component4 { get; set; }
        public string Component5 { get; set; }
        public Status Status { get; set; }

        public void Matched()
        {
            Status = Core.Entities.Status.Matched;
        }
    }
}
