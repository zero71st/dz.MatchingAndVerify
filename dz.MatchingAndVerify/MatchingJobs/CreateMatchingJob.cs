using dz.MatchingAndVerify.Base;
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
    public partial class CreateMatchingJob : DetailBase
    {
        private readonly CustomerService _customerService;
        private readonly ProductService _productService;
        private readonly JobService _uidJobService;

        public CreateMatchingJob()
        {
            InitializeComponent();

            _uidDb = new UIDModel.UIDTrackingDB();

            _customerService = new CustomerService(_uidDb);
            _productService = new ProductService(_uidDb);
            _uidJobService = new JobService(_uidDb);

            Shown += CreateMatchingJob_Shown;

            LoadCustomers();
        }

        void CreateMatchingJob_Shown(object sender, EventArgs e)
        {
            cbCustomer.SelectedIndexChanged += cbCustomer_SelectedIndexChanged;
     
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

                cbJob.DataSource = uid_jobs.Select(j => new { Id = j.ID, Name = String.Format("As:{0}",j.DataAs)}).ToList();
                cbJob.DisplayMember = "Name";
                cbJob.ValueMember = "Id";
            }
        }

        void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void LoadCustomers()
        {
            var customers = _customerService.GetAllCustomers();

            cbCustomer.DataSource = customers.Select(c => new { Id = c.ID, c.Name }).ToList();

            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "Id";
        }

        public void LoadProducts()
        {
            cbProduct.SelectedIndexChanged += cbProduct_SelectedIndexChanged;

            var products = _productService.GetAllProducts();
            int customerId = (int)cbCustomer.SelectedValue;

            cbProduct.DataSource = products.Where(p=> p.CustomerID == customerId).Select(p => new { Id = p.ID, p.Name }).ToList();

            cbProduct.DisplayMember = "Name";
            cbProduct.ValueMember = "Id";
        }
    }
}
