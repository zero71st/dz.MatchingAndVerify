using dz.MachingAndVerify.MySqlDb.Data;
using dz.MatchingAndVerify.Base;
using dz.MatchingAndVerify.Core.Entities;
using dz.MatchingAndVerify.Core.Interfaces.Services;
using dz.MatchingAndVerify.Core.Services;
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


            _matchingDb = new MatchingAndVerifyDb();
            _templateService = new MatchingTemplateService(new Repository<MatchingTemplate>(_matchingDb));
           
            LoadTemplates();
        }

        private void LoadTemplates()
        {
            var templates = _templateService.ListAllTemplate();

            gvTemplates.DataSource = templates.ToList();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            var form = new CreateMatchingTemplate();

            form.ShowDialog();
        }
    }
}
