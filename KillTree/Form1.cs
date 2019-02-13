using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Management;
using System.Windows.Forms;

namespace KillTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetbtnKillForestList();
            
        }

        /// Kill a process, and all of its children, grandchildren, etc.
        /// <param name="pid">Process ID.</param>

        private static void KillProcessAndChildren(int pid)
        {
            // Cannot close 'system idle process'.
            if (pid == 0)
            {
                return;
            }
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
                    ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }

        private void rtbKillTree_Click_1(object sender, EventArgs e)
        {
            rtbKillTree.Clear();

            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                /*Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id); */
                rtbKillTree.Text += "Process > " + theprocess.ProcessName + " ID: " + theprocess.Id + Environment.NewLine;
            }
        }

        private void btnFindProcess_Click(object sender, EventArgs e)
        {
            StringBuilder holdProcessFound = new StringBuilder();

            foreach (string line in rtbKillTree.Lines)
                if (line.Contains(tbFindProcess.Text.Trim()))
                {
                    holdProcessFound.Append(line.ToString() + Environment.NewLine);
                }
                    
            // clear process list and fill with found

            rtbKillTree.Clear();

            rtbKillTree.Text += holdProcessFound;

            // ENABLE forest kill...

            btnKillForest.Enabled = true;
        }

        private void btnKillTree_Click(object sender, EventArgs e)
        {
            int removePid = Convert.ToInt32(tbKillProcess.Text);
            KillProcessAndChildren(removePid);
        }

        private void btnKillForest_Click(object sender, EventArgs e)
        {
            // I was going to do a combined function but went with a standalone for killing all found...
            /*
             * ok:)  This function will take whatever has been found in rtbKillTree and take the pid on the end and kill it!
             * My advise is to make sure that you did a find first otherwise bad things will happen:)
             * 
             * You've been warned!!!
             * 
             */

            int fstart = 0;
            int fend = 0;

            // get rtbkilltree by line

            string[] RichTextBoxLines = rtbKillTree.Lines;
            string outCome = "";

            foreach (string line in RichTextBoxLines)
            {
                // get everything after the ":" clean it up and then kill it!...

                //outCome += line.Substring(line.IndexOf(':'), line.Length -1);
                //count = count + 1;

                // this is a test...

                fstart = line.IndexOf(":");
                fend = line.Length - fstart;

                outCome = line.Substring(fstart + 1, fend - 1);

                // killForest Member...

                if (line.Length > 0)
                {
                    KillProcessAndChildren(Convert.ToInt32(outCome));
                }

            }

            // refresh rtbKillTree list, general cleanup...

            resetbtnKillForestList();
     }

        private void resetbtnKillForestList()
        {
            rtbKillTree.Clear();

            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                /*Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id); */
                rtbKillTree.Text += "Process> " + theprocess.ProcessName + " ID: " + theprocess.Id + Environment.NewLine;
            }

            btnKillForest.Enabled = false;
        }

        private void rtbKillTree_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

