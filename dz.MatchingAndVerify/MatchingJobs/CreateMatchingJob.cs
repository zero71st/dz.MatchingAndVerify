using dz.MatchingAndVerify.Base;
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
	}
}
