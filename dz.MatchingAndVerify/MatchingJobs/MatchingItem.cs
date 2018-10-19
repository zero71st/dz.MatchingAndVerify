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
        private List<MatchingComponentModel> _allCards;
        private List<MatchingComponentModel> _pendingCards;
        private List<MatchingComponentModel> _matchedCards;

        private MatchingComponentModel _currentCard;

        private IRepository<MatchingJob> _jobRepository;
        private JobService _uidJobService;
        
        public MatchingItem()
        {
            InitializeComponent();

            _uidDb = new UIDTrackingDB();
            _matchingDb = new MatchingAndVerifyDb();
            _jobRepository = new Repository<MatchingJob>(_matchingDb);

            _uidJobService = new JobService(_uidDb);

            tbComponent1.KeyDown += tbComponent1_KeyDown;
            tbComponent2.KeyDown += tbComponent2_KeyDown;
            tbComponent3.KeyDown += tbComponent3_KeyDown;
        }

        void tbComponent3_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        void tbComponent2_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        void tbComponent1_KeyDown(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }



        public MatchingItem(int jobId):this()
        {
            var job = _jobRepository.GetById(jobId);

            var cards = _uidJobService.GetItemsByJobID(job.JobId).ToList();
            var items = job.MatchItems.ToList();

            _allCards = (from c in cards
                         join x in items
                         on c.ID equals x.JobItemId
                         select new MatchingComponentModel
                         {
                             JobItemId = x.JobItemId,
                             Component1 = c.UID,
                             Component2 = c.MaskedCardNumber,
                             Status = Status.New
                         }).ToList();

            ReloadJobItems();
        }

        private void ReloadJobItems()
        {
            _pendingCards = _allCards.Where(a => a.Status == Status.New).ToList();
            _matchedCards = _allCards.Where(a => a.Status == Status.Matched).ToList();

            gvPending.DataSource = _allCards;
            gvMatched.DataSource = _matchedCards;
        }

        private void MatchingItem_Load(object sender, EventArgs e)
        {

        }
    }
}
