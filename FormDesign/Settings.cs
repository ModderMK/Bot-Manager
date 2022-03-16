using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;

namespace FormDesign
{
    public partial class Settings : Form
    {
        string path1;
        string path2;
        string path3;
        string path4;
        string path5;
        public Settings()
        {
            InitializeComponent();
            path1 = txtStartupCommandBot1.Text;
            path2 = txtStartupCommandBot2.Text;
            path3 = txtStartupCommandBot3.Text;
            path4 = txtStartupCommandBot4.Text;
            path5 = txtStartupCommandBot5.Text;
        }

        private void btnSelectPathBot1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\fmmmo\Desktop\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path1 = dialog.FileName;
            }
        }
        private void btnSelectPathBot2_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\fmmmo\Desktop\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path2 = dialog.FileName;
            }
        }
        private void btnSelectPathBot3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\fmmmo\Desktop\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path3 = dialog.FileName;
            }
        }
        private void btnSelectPathBot4_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\fmmmo\Desktop\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path4 = dialog.FileName;
            }
        }
        private void btnSelectPathBot5_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = @"C:\Users\fmmmo\Desktop\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                path5 = dialog.FileName;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
