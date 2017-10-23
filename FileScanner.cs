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
    class FileScanner
    {

        /* Read files and check them for suspiciouse words */
        static public bool keyword_search(string path)
        {
            string[] keyWords = { "hack", "cheat", "bot", "trainer"}; // Suspicious words
            string line = string.Empty; // Store line read from file

            try
            {
                // Open file stream
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.Peek() >= 0) // While there are still characters to read
                    {
                        // Change every line to lower case
                        string lowerLine = sr.ReadLine().ToLower();

                        for (int i = 0; i < keyWords.Length; i++)
                        {
                            // For each suspicious word check streamed line
                            // for that specific word
                            if (lowerLine.Contains(keyWords[i]))
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /* Function so go through directories and            *
         * obtaining the fies under the specified Directory. */
        static public void walk_directory_tree(System.IO.DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            var form = Form.ActiveForm as Form1;

            // Process all files under folder
            try
            {
                files = root.GetFiles("*.*");
            }
            catch
            {
                MessageBox.Show("Permission denied");
            }

            if (files != null)
            {
                foreach (System.IO.FileInfo fi in files)
                {
                    // Scan file for key words
                    if (keyword_search(fi.FullName))
                    {
                        // Dont report files under this directory for cheats
                        if (fi.FullName.Contains(@"Visual Studio 2015\Projects\AntiCheatSoftware"))
                        {
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Possible cheat detected: " + fi.FullName);
                            form.status_bar.Increment(1);
                        }
                    }
                    else
                    {
                        form.status_bar.Increment(1);
                        continue;
                    }
                }

                // Get all sub directories
                subDirs = root.GetDirectories();

                foreach (System.IO.DirectoryInfo dirInfo in subDirs)
                {
                    // Recursive walk through tree again for subdirectory
                    walk_directory_tree(dirInfo);
                }
            }
        }
    }
}
