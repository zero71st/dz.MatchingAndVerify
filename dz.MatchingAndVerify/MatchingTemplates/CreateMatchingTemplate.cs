using dz.MachingAndVerify.MySqlDb.Data;
using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using dz.MatchingAndVerify.Core.Services;
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

namespace dz.MatchingAndVerify.MatchingTemplates
{
    public partial class CreateMatchingTemplate : DetailBase
    {
        private readonly CustomerService _customerService;
        private readonly ProductService _productService;
        private readonly JobService _uidJobService;

        private readonly MatchingTemplateService _templateService; 

        public CreateMatchingTemplate()
        {
            InitializeComponent();

            _uidDb = new UIDModel.UIDTrackingDB();
            _matchingDb = new MatchingAndVerifyDb();

            _customerService = new CustomerService(_uidDb);
            _productService = new ProductService(_uidDb);
            _uidJobService = new JobService(_uidDb);

            _templateService = new MatchingTemplateService(new Repository<MatchingTemplate>(_matchingDb));

            Shown += CreateMatchingJob_Shown;

            LoadCustomers();
        }

        private void CreateMatchingJob_Shown(object sender, EventArgs e)
        {
            cbCustomer.SelectedIndexChanged += cbCustomer_SelectedIndexChanged;
            cbProduct.SelectedIndexChanged += cbProduct_SelectedIndexChanged;
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();            
        }

        private void LoadProducts()
        {
            var products = _productService.GetAllProducts();
            int customerId = (int)cbCustomer.SelectedValue;

            var customerProducts = products.Where(p => p.CustomerID == customerId).ToDictionary(i => i.ID, i => i.Name);

            ComboBoxHelper.PupulateComboBox(cbProduct, customerProducts);
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadJobs();
        }

        private void LoadJobs()
        {
            if (cbProduct.Items.Count > 0)
            {
                int productId = (int)cbProduct.SelectedValue;
                var uid_jobs = _uidJobService.GetJobsbyProductID(productId);

                var jobs = uid_jobs.ToDictionary(key => key.ID, value => value.DataAs);

                ComboBoxHelper.PupulateComboBox(cbJob, jobs);
            }
        }

        private void LoadCustomers()
        {
            var customers = _customerService.GetAllCustomers().ToDictionary(i => i.ID, i => i.Name);

            ComboBoxHelper.PupulateComboBox(cbCustomer, customers);
        }

        protected override void OnSave()
        {
            base.OnSave();

            try
            {

                var template = new MatchingTemplate();

                template.CustomerId = (int)cbCustomer.SelectedValue;
                template.ProductId = (int)cbProduct.SelectedValue;
                template.JobSampleId = (int)cbJob.SelectedValue;
                template.Name = tbComponentName.Text;

                _templateService.CreateTemplate(template);
            }
            catch (Exception ex)
            {
                Alert(ex.Message);
            }
        }
    }
}
