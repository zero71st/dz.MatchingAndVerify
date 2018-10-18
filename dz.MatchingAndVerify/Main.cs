using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.MatchingTemplates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dz.MatchingAndVerify.MatchingJobs;
using dz.MatchingAndVerify.MySqlDb.Data;

namespace dz.MatchingAndVerify
{
    
    public partial class Main : FormBase,IDisposable
    {
      

        public Main()
        {
            InitializeComponent();

            Text = String.Format("{0} v.{1}", Text, Application.ProductVersion);
        }

        private void ShowForm<T>(T form) where T : Form
        {
            if (!Application.OpenForms.OfType<T>().Any())
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                foreach (Form fm in Application.OpenForms)
                    if (fm.GetType() == typeof(T))
                        fm.BringToFront();
            }
        }

        private void tsbMatchingJobs_Click(object sender, EventArgs e)
        {
            ShowForm<MatchingJobList>(new MatchingJobList());
        }

        private void tsbMatchingTemplate_Click(object sender, EventArgs e)
        {
            ShowForm<MatchingTemplateList>(new MatchingTemplateList());
        }
    }
}
