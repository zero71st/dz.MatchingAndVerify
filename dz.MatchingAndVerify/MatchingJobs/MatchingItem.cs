using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using dz.MatchingAndVerify.MySqlDb.Data;
using dz.MatchingAndVerify.ViewModels;
using dz.UIDModel;
using dz.UIDServices;
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
    public partial class MatchingItem : DetailBase
    {
        private List<MatchingComponentModel> _models = new List<MatchingComponentModel>();

        private IRepository<MatchingJob> _jobRepository;
        private JobService _uidJobService;
        
        public MatchingItem()
        {
            InitializeComponent();

            _uidDb = new UIDTrackingDB();
            _matchingDb = new MatchingAndVerifyDb();
            _jobRepository = new Repository<MatchingJob>(_matchingDb);

            _uidJobService = new JobService(_uidDb);
        }

        public MatchingItem(int jobId):this()
        {
            var job = _jobRepository.GetById(jobId);

            var cards = _uidJobService.GetItemsByJobID(job.JobId).ToList();
            var items = job.MatchItems.ToList();

            _models = (from c in cards
                      join x in items 
                      on c.ID equals x.JobItemId 
                      select new MatchingComponentModel 
                      { 
                          JobItemId = x.JobItemId,
                          Component1 = c.UID,
                          Component2 = c.MaskedCardNumber,
                          Status = Status.New
                      }).ToList();

            LoadJobItems();
        }

        private void LoadJobItems()
        {
            gvMatchingItems.DataSource = _models;
        }

        private void MatchingItem_Load(object sender, EventArgs e)
        {

        }
    }
}
