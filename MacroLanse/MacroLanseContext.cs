using Gma.System.MouseKeyHook;
using MacroLanse.Forms;
using MacroLanse.Structures;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace MacroLanse
{
    public class DataContext
    {

        #region singleton implemenntation
        private static DataContext instance = null;
        private static readonly object padlock = new object();


        public static DataContext Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock) instance = new DataContext();
                }

                return instance;
            }
        }
        #endregion


        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void InvokePropertyChanged(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        #endregion
        //configure path
        private static string FILENAME = "datacontext.txt";
        private static string PATH = 
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\MacroLanse\\";
        private string FULLPATH = PATH + FILENAME;


        //dito structure ng data na masesave sa .txt file.
        private List<MacroSet> macroSets;
        public List<MacroSet> MacroSets
        {
            get
            {
                if (macroSets == null) return new List<MacroSet>();

                return macroSets;
            }
            set
            {
                macroSets = value;
                InvokePropertyChanged("MacroSets");
            }
        }

        public MacroSet SelectedMacroSet { get; set; }

        public List<VirtualKey> Keys { get; private set; } = new List<VirtualKey>();

        //may method dito na search for the macroset via name then return the macro set.

        #region DataContext methods

        public DataContext()
        {
            Directory.CreateDirectory(PATH);

            bool success = ReloadData();

            if(!success)
            {
                SelectedMacroSet = new MacroSet();
                MacroSets = new List<MacroSet>() { SelectedMacroSet };
            }
            
            foreach (VirtualKeyCode values in Enum.GetValues(typeof(VirtualKeyCode)))
            {
                if (!values.ToString().Contains("VK_")) continue;
                else if (!values.ToString().Contains("VK_A")) continue;
                else if (!values.ToString().Contains("VK_S")) continue;

                Keys.Add(new VirtualKey(values));
            }
        }

        public bool SaveData()
        {
            try
            {

                //serialize all data and convert to string.
                string jsonDataContext = JsonConvert.SerializeObject(MacroSets);
                //write to a .txt file.
                File.WriteAllText(FULLPATH, jsonDataContext);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }

        public bool ReloadData()
        {
            if (!File.Exists(FULLPATH)) return false;

            try
            {
                //read file then convert to string
                string jsonDataContext = File.ReadAllText(FULLPATH);

                //deserialize stringified json
                MacroSets = JsonConvert.DeserializeObject<List<MacroSet>>(jsonDataContext);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }
        #endregion


    }


    public struct VirtualKey
    {
        public VirtualKey(VirtualKeyCode code) => Code = code;

        public string DisplayName
        {
            get
            {
                return Code.ToString().Remove(0, 3);
            }
        }
        public VirtualKeyCode Code { get; } //readonly
    }


    public class MacroLanseContext : ApplicationContext
    {
        private static InputSimulator ip = new InputSimulator();
        private bool isEnabled = false;

        private NotifyIcon trayIcon;

        private readonly Combination startKey = Combination.FromString("Shift+A");
        private readonly Combination stopKey = Combination.FromString("Shift+S");
        
        public event EventHandler OnStartEvent;
        public event EventHandler OnStopEvent;


        public MacroLanseContext()
        {
            //    var isLoaded = ReloadData();
            //    if (!isLoaded) DataContext = new DataContext(); 

            FileStream iconStream = File.OpenRead("C:\\Users\\lunch\\source\\repos\\MacroLanse\\MacroLanse\\icon.ico");

            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Text = "Lanse Hotkey",
                Icon = new System.Drawing.Icon(iconStream),
                ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Macro Builder", InitializeBuilder),
                new MenuItem("Exit", Exit)
            }),
                Visible = true
            };

            Hook.GlobalEvents().OnCombination(new Dictionary<Combination, Action>
            {
                {startKey, Start },
                {stopKey, Stop }
            }); 


            InitializeBuilder(this, new EventArgs());
        }


        //start and stop method for the macro itself.
        private void Start()
        {
            if (isEnabled)
            {
                MessageBox.Show("Already enabled!");
                return;
            }

            if (DataContext.Instance.SelectedMacroSet?.Name == null)
            {
                MessageBox.Show("Select a Macro Set first.");
                InitializeBuilder(this, new EventArgs());
                return;
            }

            //dito na yung multi threaded logic.
            if (DataContext.Instance.SelectedMacroSet?.Macros == null)
            {
                MessageBox.Show("There's no macro to activate on this set.");
                InitializeBuilder(this, new EventArgs());
                return;
            }


            var macros = DataContext.Instance.SelectedMacroSet?.Macros.OrderBy(m => m.Position).ToList();

            isEnabled = true;

            Task.Factory.StartNew(() =>
            {
                while (isEnabled)
                {
                    foreach (var macro in macros)
                    {
                        int pto = macro.TimeoutDuration;
                        VirtualKeyCode key = macro.KeyCode;

                        if (!isEnabled) break;
                        ip.Keyboard.Sleep(20); //initial sleep. di pa sure kung need to.

                        if (!isEnabled) break;
                        else
                        {
                            ip.Keyboard.KeyPress(key);
                            //ip.Keyboard.KeyUp(key);
                        }

                        if (!isEnabled) break;
                        else ip.Keyboard.Sleep(pto);
                    }
                }
            });

            OnStartEvent?.Invoke(this, new EventArgs());
        }

        private void Stop()
        {
            isEnabled = false;

            OnStopEvent?.Invoke(this, new EventArgs());
        }


        private void Exit(object sender, EventArgs e)
        {
            if (isEnabled) Stop();

            // We must manually tidy up and remove the icon before we exit.
            // Otherwise it will be left behind until the user mouses over.
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void InitializeBuilder(object sender, EventArgs e)
        {
            MacroBuilderForm builderForm = new MacroBuilderForm(DataContext.Instance.SelectedMacroSet);

            builderForm.ShowDialog();
        }

    }
}
