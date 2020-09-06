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
using WindowsInput.Native;


namespace MacroLanse.Forms
{
    public partial class MacroBuilderForm : Form
    {

        public Macro SelectedMacro { get; set; }


        //constructor dito arg dapat yung datacontext
        public MacroBuilderForm(MacroSet selectedMacroSet = null)
        {
            InitializeComponent();

            comboMacroSet.SelectedValueChanged += SelectedMacroSet_Changed;
            dgvMacros.SelectionChanged += SelectedMacro_Changed;

            RefreshBindings();
            
        }

        private void RefreshBindings()
        {
            var selectedMacroSet = DataContext.Instance.SelectedMacroSet;

            comboMacroSet.DataSource = new BindingSource() { DataSource = DataContext.Instance.MacroSets };
            comboMacroSet.DisplayMember = "Name";
            comboMacroSet.ValueMember = "Name";

            if (selectedMacroSet?.Name != null)
                comboMacroSet.SelectedValue = selectedMacroSet.Name;
            else
                DataContext.Instance.SelectedMacroSet = (MacroSet)comboMacroSet.SelectedItem;
            //lagay din natin siguro dito yung selected macro for the grid shit.
        }

        private void Refresh_Datagrid()
        {
            //dito yung reloading ng gridview.
            if (DataContext.Instance.SelectedMacroSet?.Macros != null)
            {
                var list = DataContext.Instance.SelectedMacroSet.Macros.OrderBy(m => m.Position).ToList();
                var bindingList = new BindingList<Macro>(list);
                var source = new BindingSource(bindingList, null);
                dgvMacros.DataSource = source;

                if (list.Count == 0) SelectedMacro = null;
            }
        }

        private void RefreshMacroSelection(Macro macro)
        {
            dgvMacros.Rows[macro.Position - 1].Selected = true;
            SelectedMacro = macro;
        }
        
        private void SelectedMacroSet_Changed(object sender, EventArgs e)
        {
            DataContext.Instance.SelectedMacroSet = (MacroSet)comboMacroSet.SelectedItem;
            Refresh_Datagrid();
        }

        private void SelectedMacro_Changed(object sender, EventArgs e)
        {
            SelectedMacro = (Macro)dgvMacros.CurrentRow.DataBoundItem;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertMacro_Click(object sender, EventArgs e)
        {
            if (DataContext.Instance.SelectedMacroSet.Name == null)
            {
                MessageBox.Show("Select a Macro Set first.");

                return;
            }
            Macro newMacro = new Macro();
            MacroForm form = new MacroForm(newMacro);

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) return;

            //dito save new macro
            DataContext.Instance.SelectedMacroSet.InsertMacro(newMacro);
            DataContext.Instance.SaveData();
            RefreshBindings();
            Refresh_Datagrid();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (DataContext.Instance.SelectedMacroSet.Name == null)
            {
                MessageBox.Show("Select a Macro Set first.");

                return;
            }

            var macro = SelectedMacro;
            if (macro == null || macro.Position <= 1) return;

            DataContext.Instance.SelectedMacroSet.SwitchMacroUp(SelectedMacro);
            DataContext.Instance.SaveData();
            RefreshBindings();
            Refresh_Datagrid();

            RefreshMacroSelection(macro);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (DataContext.Instance.SelectedMacroSet.Name == null)
            {
                MessageBox.Show("Select a Macro Set first.");

                return;
            }
            var macro = SelectedMacro;
            if (macro == null || 
                macro.Position < 1 || 
                macro.Position == DataContext.Instance.SelectedMacroSet.Macros.Count) return;


            DataContext.Instance.SelectedMacroSet.SwitchMacroDown(SelectedMacro);
            DataContext.Instance.SaveData();
            RefreshBindings();
            Refresh_Datagrid();

            RefreshMacroSelection(macro);
        }

        private void btnNewMacroSet_Click(object sender, EventArgs e)
        {
            MacroSet newMacroSet = new MacroSet();
            MacroSetForm setForm = new MacroSetForm(newMacroSet);

            var result = setForm.ShowDialog();
            //if result is ok, update all

            if (result == DialogResult.Cancel) return;

            DataContext.Instance.MacroSets.Add(newMacroSet);
            var success = DataContext.Instance.SaveData();
            if(success) success = DataContext.Instance.ReloadData();
            if (!success) MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            RefreshBindings();
        }

        private void btnDeleteMacroSet_Click(object sender, EventArgs e)
        {
            if (DataContext.Instance.SelectedMacroSet.Name == null) return;

            DataContext.Instance.MacroSets.Remove(DataContext.Instance.SelectedMacroSet);
            DataContext.Instance.SaveData();
            RefreshBindings();
        }

        private void btnRenameMacroSet_Click(object sender, EventArgs e)
        {
            if (DataContext.Instance.SelectedMacroSet.Name == null) return;
            
            MacroSetForm setForm = new MacroSetForm(DataContext.Instance.SelectedMacroSet);

            var result = setForm.ShowDialog();
            //if result is ok, update all

            if (result == DialogResult.Cancel) return;

            DataContext.Instance.SaveData();
            RefreshBindings();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedMacro == null) return;

            MacroForm form = new MacroForm(SelectedMacro);

            var result = form.ShowDialog();
            if (result == DialogResult.Cancel) return;
            
            //dito save new macro
            DataContext.Instance.SaveData();
            RefreshBindings();
            Refresh_Datagrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (SelectedMacro == null) return;
            
            DataContext.Instance.SelectedMacroSet.Macros.Remove(SelectedMacro);
            
            DataContext.Instance.SaveData();
            RefreshBindings();
            Refresh_Datagrid();
        }
    }
}
