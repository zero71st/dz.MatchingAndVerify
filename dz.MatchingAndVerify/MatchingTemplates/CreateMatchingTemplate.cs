using dz.MachingAndVerify.MySqlDb.Data;
using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Repositories;
using dz.MatchingAndVerify.Core.Services;
using dz.MatchingAndVerify.Helpers;
using dz.MatchingAndVerify.Services;
using dz.MatchingAndVerify.ViewModels;
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

        private readonly IRepository<MatchingTemplate> _templateRepository;
        private readonly MatchingTemplateService _templateService; 

        private MatchingTemplate _template;

        public CreateMatchingTemplate()
        {
            InitializeComponent();
            
            _uidDb = new UIDModel.UIDTrackingDB();
            _matchingDb = new MatchingAndVerifyDb();

            _customerService = new CustomerService(_uidDb);
            _productService = new ProductService(_uidDb);
            _uidJobService = new JobService(_uidDb);

            _templateRepository = new Repository<MatchingTemplate>(_matchingDb);

            _templateService = new MatchingTemplateService(_templateRepository);

            Shown += CreateMatchingJob_Shown;

            LoadCustomers();
        }

        public CreateMatchingTemplate(FormMode formMode):this()
        {
            FormMode = formMode;
        }

        public CreateMatchingTemplate(FormMode formMode,int templateId):this(formMode)
        {
            _template = _templateRepository.GetById(templateId);
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
                if (FormMode == ViewModels.FormMode.Add)
                {
                    int customerId = (int)cbCustomer.SelectedValue;
                    int productId = (int)cbProduct.SelectedValue;
                    int jobId = (int)cbJob.SelectedValue;
                    string name = tbTemplateName.Text;

                    _template = new MatchingTemplate(customerId, productId, jobId, name, AuthenticationService.LoggedUser);

                    _templateService.CreateTemplate(_template);
                }

                if (FormMode == ViewModels.FormMode.Edit)
                {
                    _template.CustomerId = (int)cbCustomer.SelectedValue;
                    _template.ProductId = (int)cbProduct.SelectedValue;
                    _template.JobSampleId = (int)cbJob.SelectedValue;
                    _template.Name = tbTemplateName.Text;

                    _templateRepository.Update(_template);
                }

                Info("Save");
            }
            catch (Exception ex)
            {
                Alert(ex.Message);
            }
        }
    }
}
