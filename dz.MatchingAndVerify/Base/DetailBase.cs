﻿using dz.MatchingAndVerify.ViewModels;
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
    public partial class DetailBase : FormBase
    {
        public FormMode FormMode { get; set; }

        public DetailBase()
        {
            InitializeComponent();
        }

        protected virtual void OnSave()
        {

        }

        protected virtual void OnCancel()
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            OnSave();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            OnCancel();
        }
    }

    
}
