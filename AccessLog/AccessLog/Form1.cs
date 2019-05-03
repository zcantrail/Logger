using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;


namespace AccessLog
{

    public partial class Log : Form
    {
        public String UserName = "";

        public Log()
        {
            InitializeComponent();
        }

        private void Log_Load(object sender, EventArgs e)
        {

        }

        private void CloseMicrosoftProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ClearWindowsCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process proc = null;
            try { 
            string batDir = string.Format(@"\AccessLog");
            proc = new Process();
            proc.StartInfo.WorkingDirectory = batDir;
            proc.StartInfo.FileName = "ClearWindowsCredentials.bat";
            proc.StartInfo.CreateNoWindow = false;
            proc.Start();
            proc.WaitForExit();
            MessageBox.Show("Bat file executed !!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
        }

        private void ClearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            UserName = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UserName = textBox1.Text;
            try
            {
                String command = "net use /domain";
                var processInfo = new ProcessStartInfo("cmd.exe", "/c" + command + " " + UserName);

                processInfo.CreateNoWindow = true;

                processInfo.UseShellExecute = false;

                processInfo.RedirectStandardError = true;
                processInfo.RedirectStandardOutput = true;

                var process = Process.Start(processInfo);

                process.Start();

                process.WaitForExit();

                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                DialogBox.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
