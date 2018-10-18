using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using dz.MatchingAndVerify.MySqlDb.Data;
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
        private IRepository<MatchingJob> _jobRepository;

        public MatchingJobList()
        {
            InitializeComponent();

            _matchingDb = new MatchingAndVerifyDb();

            _jobRepository = new Repository<MatchingJob>(_matchingDb);

            gvJobs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadJobs();
        }

        private void LoadJobs()
        {
            var jobs = (_jobRepository.GetAll()
                       .Select(j => new { j.Id, j.CreateBy, j.CreateDate })
                       .ToList());

            gvJobs.DataSource = jobs;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            OnCreate();
        }

        private void btMatching_Click(object sender, EventArgs e)
        {
            int jobId = (int)gvJobs.SelectedRows[0].Cells["Id"].Value;

            var form = new MatchingItem(jobId);

            form.ShowDialog();
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            var form = new CreateMatchingJob();
            form.ShowDialog();
        }

        protected override void OnEdit()
        {
            base.OnEdit();
        }

        protected override void OnDelete()
        {
            base.OnDelete();
        }
    }
}
