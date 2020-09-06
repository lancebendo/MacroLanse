using MacroLanse.Structures;
using System;
using System.Windows.Forms;
using WindowsInput.Native;

namespace MacroLanse.Forms
{
    public partial class MacroForm : Form
    {
        public Macro CurrentMacro { get; set; }

        public MacroForm(Macro macro)
        {
            CurrentMacro = macro;

            InitializeComponent();
            
            comboKeyCode.DataSource = new BindingSource() { DataSource = DataContext.Instance.Keys };
            comboKeyCode.DisplayMember = "DisplayName";
            comboKeyCode.ValueMember = "Code";

            Helpers.AddNewBinding(comboKeyCode, "SelectedItem", CurrentMacro, "KeyCode");
            Helpers.AddNewBinding(numTimeoutDuration, "Text", CurrentMacro, "TimeoutDuration");

        }

        //

        private void btnOK_Click(object sender, EventArgs e)
        {
            CurrentMacro.KeyCode = (VirtualKeyCode) comboKeyCode.SelectedValue;
            CurrentMacro.TimeoutDuration = (int)numTimeoutDuration.Value;
            
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
