using dz.MatchingAndVerify.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz.MatchingAndVerify.MatchingJobs
{
    public partial class MatchingJobList : ListBase
    {
        public MatchingJobList()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            var form = new CreateMatchingJob();
            form.ShowDialog();
        }

        private void btMatching_Click(object sender, EventArgs e)
        {
            var form = new MatchingItem();

            form.ShowDialog();
        }
    }
}
