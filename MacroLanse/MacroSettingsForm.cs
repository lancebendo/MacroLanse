using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroLanse
{
    public partial class MacroSettingsForm : Form
    {

        private MacroApplicationContext appContext;

        public MacroSettingsForm(MacroApplicationContext _appContext)
        {
            appContext = _appContext;

            InitializeComponent();

            InputPressTimeout.DataBindings.Add(new Binding("Text", appContext.MacroSettings, "PressTimeout"));
            InputPressTimeout.DataBindings.Add(new Binding("Enabled", appContext.MacroSettings, "CanEdit"));
            
        }
        
    }
}
