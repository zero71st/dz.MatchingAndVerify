using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz.MatchingAndVerify.Helpers
{
    public class ComboBoxHelper
    {
        public static void PupulateComboBox(ComboBox comboBox, IDictionary<int, string> items)
        {
            comboBox.DataSource = items.ToList();
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
        }
    }
}
