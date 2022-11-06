using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDesign
{
    public partial class Bot1 : Form
    {
        string path = @"C:\Users\fmmmo\Desktop\Code\ModderZin v3";
        string startup = "node index.js";
        public Bot1()
        {
            InitializeComponent();
        }
        private void changeColorlbl(String text, Color color)
        {
            lblCurrentStatus.Text = text;
            lblCurrentStatus.ForeColor = color;
            lblCurrentStatus.Refresh();
        }

        delegate void VoidDelegate();
        public static void ControlInvoke(System.Windows.Forms.Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;
            if (control.InvokeRequired)
            {
                control.Invoke(new VoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }
        private void ExecuteCommand(string command)
        {
            ControlInvoke(richtxtConsole, () => richtxtConsole.Text += command + "\n");
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (sender, args) => {

                Process process = new Process()
                {
                    StartInfo = new ProcessStartInfo("cmd.exe")
                    {
                        Arguments = "/C " + command,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardError = true,
                        RedirectStandardOutput = true,
                        RedirectStandardInput = true
                    }
                };
                process.Start();
                if (process != null)
                {
                    process.OutputDataReceived += ((s, ev) => {
                        string sData = ev.Data;
                        if(sData != null)
                        {
                            sData += "\r\n";
                        }
                        ControlInvoke(richtxtConsole, () => richtxtConsole.Text += sData);
                        System.Threading.Thread.Sleep(10);
                        if (ev.Data == null)
                        {
                            //End of Execution
                        }
                        Console.WriteLine(ev.Data);
                    });
                    process.BeginOutputReadLine();
                }
            };
            bw.RunWorkerAsync();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnRestart.Enabled = true;
            richtxtConsole.Clear();
            ExecuteCommand(("cd " + path + " && " + startup).ToString());
            System.Threading.Thread.Sleep(1000);
            changeColorlbl("ONLINE", Color.Green);
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnRestart.Enabled = false;
            richtxtConsole.Text += "\nKilling Process...";
            Process[] _proceses = null;
            _proceses = Process.GetProcessesByName("node");
            foreach (Process proces in _proceses)
            {
                proces.Kill();
            }
            richtxtConsole.Text += "\nDone.";
            changeColorlbl("OFFLINE", Color.Red);
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = false;
            btnRestart.Enabled = false;
            richtxtConsole.Text += "\nRestarting...\n";
            changeColorlbl("RESTARTING", Color.Orange);
            System.Threading.Thread.Sleep(1000);
            btnStop_Click(null, null);
            changeColorlbl("RESTARTING", Color.Orange);
            btnStart_Click(null, null);

        }
    }
}
