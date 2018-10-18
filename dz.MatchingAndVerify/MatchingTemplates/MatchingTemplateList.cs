using dz.MatchingAndVerify.MySqlDb.Data;
using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Services;
using dz.MatchingAndVerify.Core.Services;
using dz.MatchingAndVerify.ViewModels;
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
    public partial class MatchingTemplateList : ListBase
    {
        private readonly IMatchingTemplateService _templateService;

        public MatchingTemplateList()
        {
            InitializeComponent();

            gvTemplates.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            _matchingDb = new MatchingAndVerifyDb();
            _templateService = new MatchingTemplateService(new Repository<MatchingTemplate>(_matchingDb));
           
            LoadTemplates();
        }

        private void LoadTemplates()
        {
            var templates = _templateService.ListAllTemplate();

            gvTemplates.DataSource = templates.Select(t=> new { t.Id,t.Name,t.CreateBy,t.CreateDate}).ToList();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            OnCreate();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            OnEdit();
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            var form = new CreateMatchingTemplate(FormMode.Add);

            form.ShowDialog();

            LoadTemplates();
        }

        protected override void OnEdit()
        {
            base.OnEdit();

            int id = (int)gvTemplates.SelectedRows[0].Cells["Id"].Value;

            var form = new CreateMatchingTemplate(FormMode.Edit, id);

            form.ShowDialog();
        }

        protected override void OnDelete()
        {
            base.OnDelete();

        }
    }
}
