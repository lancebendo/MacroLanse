using System.ComponentModel;
using WindowsInput.Native;

namespace MacroLanse.Structures
{
    //virtual key code mapper
    //public class VirtualKeyCodeMapper
    //{
    //    VirtualKeyCode d = VirtualKeyCode.
    //}

    public class Macro
    {

        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private int position = 1;
        public int Position
        {
            get { return position; }
            set
            {
                position = value;
                InvokePropertyChanged("Position");
            }
        }

        public string CodeName
        {
            get
            {
                return "Key: " + keyCode.ToString()?.Remove(0, 3);
            }
        }

        private VirtualKeyCode keyCode;
        public VirtualKeyCode KeyCode
        {
            get { return keyCode; }
            set
            {
                keyCode = value;
                InvokePropertyChanged("KeyCode");
            }
        }

        private int timeoutDuration;
        public int TimeoutDuration
        {
            get { return timeoutDuration; }
            set
            {
                timeoutDuration = value;
                InvokePropertyChanged("TimeoutDuration");
            }
        }


    }
}
