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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
using ProcessMemoryReaderLib;
using System.Globalization;
using System.Net.Mail;

namespace AntiCheatSoftware
{
    public partial class Form1 : Form
    {

        ProcessModule mainModule;
        ProcessMemoryReader Mem = new ProcessMemoryReader();
        bool ProcessFound = false;
        static public bool detected = false;

        // Look for the games process
        Process[] MyProcess = Process.GetProcessesByName("ac_client");

        public Form1()
        {
            InitializeComponent();
        }

        private void file_scan_button_Click(object sender, EventArgs e)
        {
            string path; // Holds path to file given by the UI
            //Pull string from UI text box
            path = path_box.Text;
            // C:\Users\Laptop\Documents\CSGOHexValues.txt <- test file path
            // Search the file for key words
            if (FileScanner.keyword_search(path))
            {
                MessageBox.Show(path);
            }
            else
            {
                MessageBox.Show("Clean");
            }
            
        }

        private void start_scan_button_Click(object sender, EventArgs e)
        {
            //Store all the drive names
            /*string[] drives = System.Environment.GetLogicalDrives();

            foreach (string dr in drives)
            {
                System.IO.DriveInfo di = new System.IO.DriveInfo(dr);
                MessageBox.Show(di.Name);
                // Check if drive is ready to be scanned
                if (!di.IsReady)
                {
                    MessageBox.Show("The drive {0} could not be read", di.Name);
                    continue;
                }
            }*/

            System.IO.DirectoryInfo di = new DirectoryInfo(@"C:\Users\Laptop\Documents");
            status_bar.Value = 0;
            FileScanner.walk_directory_tree(di);
            int the_rest = status_bar.Maximum - status_bar.Value;
            status_bar.Increment(the_rest);
            MessageBox.Show("Scan Complete");
        }

        private void status_bar_Click(object sender, EventArgs e)
        {

        }

        private void start_monitor_btn_Click(object sender, EventArgs e)
        {
            while (MyProcess.Length == 0)
            {
                // Wait for game to start
                Process[] MyProcess = Process.GetProcessesByName("ac_client");
            }

            mainModule = MyProcess[0].MainModule;
            Mem.ReadProcess = MyProcess[0];
            Mem.OpenProcess();
            ProcessFound = true;
            monitor_tmr.Start();
            statusBox.BackColor = System.Drawing.Color.Green;

    
        }

        private void stop_monitor_btn_Click(object sender, EventArgs e)
        {
            monitor_tmr.Stop();
            statusBox.BackColor = System.Drawing.Color.Red;
        }

        private void monitor_tmr_Tick(object sender, EventArgs e)
        {           
            if (ProcessFound)
            {
                /* Look for virtual key Injection */
                KeyboardListener KListener = new KeyboardListener();
                KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);

                /* Monitor the games memory and check for deveation */
                monitorMemory.monitorMemoryValues(Mem);
            }
        }

        void KListener_KeyDown(object sender, RawKeyEventArgs args)
        {           
            MessageBox.Show(args.ToString());
        }
    }
}
    