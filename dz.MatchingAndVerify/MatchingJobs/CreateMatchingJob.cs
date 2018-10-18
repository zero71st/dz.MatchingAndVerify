using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Helpers;
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
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using dz.MatchingAndVerify.Services;
using dz.MatchingAndVerify.MySqlDb.Data;

namespace dz.MatchingAndVerify.MatchingJobs
{
	public partial class CreateMatchingJob : DetailBase
	{
		private readonly CustomerService _customerService;
		private readonly ProductService _productService;
		private readonly JobService _uidJobService;

        private readonly IRepository<MatchingJob> _jobRepository;
        private readonly IRepository<MatchingTemplate> _templateRepository;

		public CreateMatchingJob()
		{
			InitializeComponent();

			_uidDb = new UIDModel.UIDTrackingDB();
            _matchingDb = new MySqlDb.Data.MatchingAndVerifyDb();
       
			_customerService = new CustomerService(_uidDb);
			_productService = new ProductService(_uidDb);
			_uidJobService = new JobService(_uidDb);

            _jobRepository = new Repository<MatchingJob>(_matchingDb);
            _templateRepository = new Repository<MatchingTemplate>(_matchingDb);

			Shown += CreateMatchingJob_Shown;

			LoadCustomers();

            LoadTemplates();
		}

        private void LoadTemplates()
        {
            var templates = _templateRepository.GetAll().ToDictionary(t => t.Id, t => t.Name);

            ComboBoxHelper.PupulateComboBox(cbTemplate, templates);
        }

		void CreateMatchingJob_Shown(object sender, EventArgs e)
		{
			cbCustomer.SelectedIndexChanged += cbCustomer_SelectedIndexChanged;
			cbProduct.SelectedIndexChanged += cbProduct_SelectedIndexChanged;
		}

		void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadJobs();
		}

		private void LoadJobs()
		{
			if (cbProduct.Items.Count > 0)
			{
				int productId = (int)cbProduct.SelectedValue;
				var uid_jobs = _uidJobService.GetJobsbyProductID(productId);

				var jobs = uid_jobs.ToDictionary(key=> key.ID,value=> value.DataAs);

				ComboBoxHelper.PupulateComboBox(cbJob,jobs);
			}
		}

		void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadProducts();
		}

		public void LoadCustomers()
		{
			var customers = _customerService.GetAllCustomers().ToDictionary(i=> i.ID,i=> i.Name);
			
            ComboBoxHelper.PupulateComboBox(cbCustomer, customers);
		}

		public void LoadProducts()
		{
			var products = _productService.GetAllProducts();
			int customerId = (int)cbCustomer.SelectedValue;

			var customerProducts = products.Where(p => p.CustomerID == customerId).ToDictionary(i => i.ID, i => i.Name);

			ComboBoxHelper.PupulateComboBox(cbProduct, customerProducts);
		}

        protected override void OnSave()
        {
            base.OnSave();

            try
            {
                var customerId = (int)cbCustomer.SelectedValue;
                var productId = (int)cbProduct.SelectedValue;
                var jobId = (int)cbJob.SelectedValue;
                var templateId = (int)cbTemplate.SelectedValue;

                var cards = _uidJobService.GetItemsByJobID(jobId);

                MatchingJob job = new MatchingJob(customerId,productId,jobId,templateId,AuthenticationService.LoggedUser);

                if (cards.Count() > 0)
                {
                    foreach (var card in cards)
                    {
                        MatchingJobItem item = new MatchingJobItem();
                        item.JobItemId = card.ID;

                        job.AddMatchItem(item);
                    }

                   _jobRepository.Add(job);

                    Info("Save");
                }
            }
            catch (Exception ex)
            {
              //  Alert(ex.Message);
                throw ex;
            }
        }
	}
}
