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

        private void AccountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClearWindowsCredentialsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ClearFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("net user /domain" + textBox1.Text);
            toolStripStatusLabel1.Text = cmd.StandardOutput.ReadToEnd();
        }
    }
}
