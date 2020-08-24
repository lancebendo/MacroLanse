using Gma.System.MouseKeyHook;
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
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents m_GlobalHook;
        //1. Define key combinations
        Combination start = Combination.FromString("Control+Q");
        Combination stop = Combination.FromString("Control+W");

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();
            
            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
                {start, () => { Trigger(); }},
                {stop, () => { MessageBox.Show("stop"); }}
            });
       
        }

        void Trigger()
        {
            Console.WriteLine("sadfa");
        }
        

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Subscribe();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //It is recommened to dispose it
            m_GlobalHook.Dispose();
        }
    }
}
