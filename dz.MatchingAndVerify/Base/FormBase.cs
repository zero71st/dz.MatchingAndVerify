using dz.MatchingAndVerify.MySqlDb.Data;
using dz.UIDModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz.MatchingAndVerify.Base
{
    public partial class FormBase : Form
    {
        protected MatchingAndVerifyDb _matchingDb;
        protected UIDTrackingDB _uidDb;

        public FormBase()
        {
            InitializeComponent();

            FormClosing += FormBase_FormClosing;
        }

        void FormBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_matchingDb != null)
                _matchingDb.Dispose();

            if (_uidDb != null)
                _uidDb.Dispose();
        }

        protected virtual void AssignPermission()
        {

        }

        protected void Info(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void Warning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        protected void Alert(string message)
        {
            MessageBox.Show(message, "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        protected DialogResult Confirm(string message)
        {
            return MessageBox.Show(message, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
