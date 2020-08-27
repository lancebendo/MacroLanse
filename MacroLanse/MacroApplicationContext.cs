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
        public MacroSettings MacroSettings = MacroSettings.Instance;
        
        private readonly Combination startKey = Combination.FromString("Shift+A");
        private readonly Combination stopKey = Combination.FromString("Shift+S");

        public event EventHandler OnStartEvent;
        public event EventHandler OnStopEvent;

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
                // new MenuItem("Enable Macro (Shift + A)", (object sender, EventArgs e) => { int x = 2; }),
                new MenuItem("Configure", InitializeSettings),
                new MenuItem("Exit", Exit)
            }),
                Visible = true
            };

            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
                {startKey, Start },
                {stopKey, Stop }
            });
        }
       

        private void InitializeSettings(object sender, EventArgs e)
        {
            MacroSettingsForm settingsForm = new MacroSettingsForm(this);
            settingsForm.ShowDialog();
        }

        private void Exit(object sender, EventArgs e)
        {
            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.

            if (MacroSettings.IsEnabled) Stop();

            //ALSO, STOP TASK HERE. 
            trayIcon.Visible = false;
            Application.Exit();
        }

        public void Start()
        {
            if (MacroSettings.IsEnabled) return;

            MacroSettings.IsEnabled = true;
            Task.Factory.StartNew(() =>
            {
                while (MacroSettings.IsEnabled)
                {
                    int pto = MacroSettings.PressTimeout;

                    ip.Keyboard.Sleep(pto);
                    ip.Keyboard.KeyDown(VirtualKeyCode.VK_Q);
                    ip.Keyboard.KeyUp(VirtualKeyCode.VK_Q);
                    ip.Keyboard.Sleep(pto);
                    ip.Keyboard.KeyDown(VirtualKeyCode.VK_W);
                    ip.Keyboard.KeyUp(VirtualKeyCode.VK_W);
                    ip.Keyboard.Sleep(pto);
                    ip.Keyboard.KeyDown(VirtualKeyCode.VK_E);
                    ip.Keyboard.KeyUp(VirtualKeyCode.VK_E);
                }
            });

            OnStartEvent?.Invoke(this, new EventArgs());
        }

        public void Stop()
        {
            MacroSettings.IsEnabled = false;

            OnStopEvent?.Invoke(this, new EventArgs());
        }

    }
}
