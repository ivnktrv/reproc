using Newtonsoft.Json;
using System.Diagnostics;

namespace reproc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string>? config = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("config.json"));

            while (true)
            {
                Process[] getProc = Process.GetProcessesByName(config["targetProcess"]);
                if (getProc.Length > 0)
                {
                    foreach (Process proc in getProc)
                    {
                        proc.Kill();
                    }
                    ProcessStartInfo start = new(config["startProcess"]) { UseShellExecute = true };
                    Process.Start(start);
                }
            }
        }
    }
}
