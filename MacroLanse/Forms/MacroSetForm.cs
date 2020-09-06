using MacroLanse.Structures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroLanse.Forms
{
    public partial class MacroSetForm : Form
    {
        public MacroSet MacroSet { get; set; }

        public MacroSetForm(MacroSet macroSet)
        {
            MacroSet = macroSet;

            InitializeComponent();

            Helpers.AddNewBinding(textName, "Text", MacroSet, "Name");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MacroSet.Name = textName.Text;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
