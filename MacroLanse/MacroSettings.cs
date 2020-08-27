using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroLanse
{
    public class MacroSettings : INotifyPropertyChanged
    {

        #region singleton implemenntation
        private static MacroSettings instance = null;
        private static readonly object padlock = new object();


        public static MacroSettings Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock) instance = new MacroSettings();
                }

                return instance;
            }
        }
        #endregion

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, e);
        }

        #endregion

        private int pressTimeout = 90; //default is 90ms
        public int PressTimeout
        {
            get { return pressTimeout; }
            set
            {
                pressTimeout = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("PressTimeout"));
            }
        }

        private bool isEnabled = false; //default is false
        public bool IsEnabled
        {
            get { return isEnabled; }
            set
            {
                isEnabled = value;
                InvokePropertyChanged(new PropertyChangedEventArgs("IsEnabled"));
                InvokePropertyChanged(new PropertyChangedEventArgs("CanEdit"));
            }
        }

        public bool CanEdit
        {
            get { return IsEnabled == false; }
        }
        
    }
}
