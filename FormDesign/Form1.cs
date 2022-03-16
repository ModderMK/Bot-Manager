using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FormDesign
{
    public partial class DesignUI : Form
    {
        Dashboard dashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Settings settings = new Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Bot1 bot1 = new Bot1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Bot2 bot2 = new Bot2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Bot3 bot3 = new Bot3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Bot4 bot4 = new Bot4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        Bot5 bot5 = new Bot5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftReact, int nTopReact, int nRightReac, int nBottomReact, int nWidthReact, int nHeightReact);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public DesignUI()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            moveSelection(btnDashboard, null);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void dragForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void moveSelection(object sender, EventArgs e)
        {
            var button = (Button)sender;
            String buttonName = button.Name.ToString();
            pnlNavBar.Height = button.Height;
            pnlNavBar.Top = button.Top;
            pnlNavBar.Left = button.Left;
            switch (buttonName){
                case "btnDashboard":
                    lblPageName.Text = "Dashboard";
                    pnlInfo.Controls.Clear();
                    pnlInfo.Controls.Add(dashboard);
                    dashboard.Show();
                    break;
                case "btnSettings":
                    lblPageName.Text = "Settings";
                    pnlInfo.Controls.Clear();
                    pnlInfo.Controls.Add(settings);
                    settings.Show();
                    break;
                case "btnBot1":
                    lblPageName.Text = "Bot 1";
                    pnlInfo.Controls.Clear();
                    pnlInfo.Controls.Add(bot1);
                    bot1.Show();
                    break;
                case "btnBot2":
                    lblPageName.Text = "Bot 2";
                    pnlInfo.Controls.Clear();
                    pnlInfo.Controls.Add(bot2);
                    bot2.Show();
                    break;
                case "btnBot3":
                    lblPageName.Text = "Bot 3";
                    pnlInfo.Controls.Clear();
                    pnlInfo.Controls.Add(bot3);
                    bot3.Show();
                    break;
                case "btnBot4":
                    lblPageName.Text = "Bot 4";
                    pnlInfo.Controls.Clear();
                    pnlInfo.Controls.Add(bot4);
                    bot4.Show();
                    break;
                case "btnBot5":
                    lblPageName.Text = "Bot 5";
                    pnlInfo.Controls.Clear();
                    pnlInfo.Controls.Add(bot5);
                    bot5.Show();
                    break;
                default:
                    lblPageName.Text = "ERRO!";
                    pnlInfo.Controls.Clear();
                    break;
            }
        }
    }
}
