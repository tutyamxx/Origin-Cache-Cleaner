using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace Origin_Cache_Cleaner
{
    public partial class frm_OriginForm : Form
    {
        public frm_OriginForm()
        {
            InitializeComponent();
            picOrigin.BackColor = Color.Transparent;
        }

        // --| User clicked Clear Origin Cache button
        private void btn_ClearOriginCache_Click(object sender, EventArgs e)
        {
            // --| Ask user if he's sure about the next operation
            DialogResult dialogResult = MessageBox.Show("Start clearing Origin cache?\n\nI will have to close Origin (if open) before I start doing that.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // --| User clicked Yes
            if(dialogResult == DialogResult.Yes)
            {
                // --| First, let's kill Origin.exe and OriginWebHelperService.exe so we could clear the cache properly
                Process.GetProcesses().Where(p => p.ProcessName == "Origin" || p.ProcessName == "OriginWebHelperService").ToList().ForEach(y => y.Kill());

                // --| Wait about 2.5 seconds for processes to be force killed
                Thread.Sleep(2500);

                // --| Get the C:\ProgramData hidden folder path
                string szWindowsApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

                // --| Get the %AppData%\Roaming path
                string szWindowsAppDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                // --| Get %AppData%\Local path
                string szWindowsAppDataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

                // --| Get the Origin hidden folder path in ProgramData
                // --| C:\ProgramData\Origin
                string szOriginPath = szWindowsApplicationData + "\\Origin";

                // --| Directory variable
                var szDir = new DirectoryInfo(szOriginPath);
                var szDirAppDataLocal = new DirectoryInfo(szWindowsAppDataLocal);
                var szDirAppDataRoaming = new DirectoryInfo(szWindowsAppDataRoaming);

                // --| If somehow the Origin Cache folder is non-existant, throw an error
                if(!szDir.Exists)
                {
                    MessageBox.Show("Origin Cache folder does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

                // --| --------------------------------------------------
                // --| Try deleting all cached Origin folders...
                // --| --------------------------------------------------
                foreach(DirectoryInfo dir in szDir.GetDirectories())
                {
                    try
                    {
                        // --| Ignore LocalContent folder. We don't want to delete this as per Origin guidance
                        if(dir.ToString() == "LocalContent")
                        {
                            continue;
                        }

                        // --| Delete all Origin cached folders
                        dir.Delete(true);
                    }

                    catch(Exception)
                    {
                        // --| Ignore locked directories
                    }
                }

                foreach(DirectoryInfo dir1 in szDirAppDataLocal.GetDirectories())
                {
                    try
                    {
                        // --| Find and delete the Origin folder only
                        if(dir1.ToString() == "Origin")
                        {
                            // --| Delete Origin folder
                            dir1.Delete(true);
                        }
                    }

                    catch(Exception)
                    {
                        // --| Ignore locked directories
                    }
                }

                foreach(DirectoryInfo dir2 in szDirAppDataRoaming.GetDirectories())
                {
                    try
                    {
                        // --| Find and delete the Origin folder only
                        if(dir2.ToString() == "Origin")
                        {
                            // --| Delete Origin folder
                            dir2.Delete(true);
                        }
                    }

                    catch(Exception)
                    {
                        // --| Ignore locked directories
                    }
                }


                // --| --------------------------------------------------
                // --| Try deleting all cached Origin files
                // --| --------------------------------------------------
                foreach(FileInfo szFile in szDir.GetFiles())
                {
                    try
                    {
                        szFile.Delete();
                    }

                    catch(Exception)
                    {
                        // --| Ignored locked files
                    }
                }

                MessageBox.Show("Origin cache cleared!\n\nIt is recommended to restart your computer for changes to be properly applied.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // --| User clicked No
            else if(dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
