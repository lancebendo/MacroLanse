using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace MacroLanse
{
    public class MacroApplicationContext : ApplicationContext
    {
        private static InputSimulator ip = new InputSimulator();

        private readonly int pressTimeout = 90;
        private bool isStarted = false;

        private IKeyboardMouseEvents m_GlobalHook;
        private readonly Combination start = Combination.FromString("Shift+A");
        private readonly Combination stop = Combination.FromString("Shift+S");

        private NotifyIcon trayIcon;

        public MacroApplicationContext()
        {

            FileStream iconStream = File.OpenRead("C:\\Users\\lunch\\source\\repos\\MacroLanse\\MacroLanse\\icon.ico");

            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Text = "Lanse Hotkey",
                Icon = new System.Drawing.Icon(iconStream),
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Exit", Exit)
            }),
                Visible = true
            };

            m_GlobalHook = Hook.GlobalEvents();

            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
                {start, StartHotkey },
                {stop, () =>  isStarted = false }
            });
        }

 
        //START TASK
        private void StartHotkey()
        {
            if (isStarted) return;

            isStarted = true;
            Task.Factory.StartNew(() =>
            {
            while (isStarted)
                {
                    ip.Keyboard.Sleep(pressTimeout);
                    ip.Keyboard.KeyDown(VirtualKeyCode.VK_Q);
                    ip.Keyboard.KeyUp(VirtualKeyCode.VK_Q);
                    ip.Keyboard.Sleep(pressTimeout);
                    ip.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                    ip.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                    ip.Keyboard.Sleep(pressTimeout);
                    ip.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    ip.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                }
            });

        }


        void Exit(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.

            if (isStarted) isStarted = false;

            //ALSO, STOP TASK HERE. 
            trayIcon.Visible = false;
            m_GlobalHook.Dispose();
            Application.Exit();
        }
        


    }
}
