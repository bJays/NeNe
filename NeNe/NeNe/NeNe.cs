#define DEBUG_MODE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeNe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public List<Process> ListProcesses = new List<Process>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                this.GlassPanel.Dock = DockStyle.Fill;
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "MainForm_Load", null);
            }
        }

        private void GetProcessNameBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.ListProcesses.Clear();
                Process[] AllProc = Process.GetProcesses();

                this.ProcessNamesListView.Items.Clear();

                int i = 0; 
                foreach (Process tProc in AllProc)
                {
                    this.ListProcesses.Add(tProc);

                    if (!String.IsNullOrEmpty(tProc.MainWindowTitle))
                    {
                        this.PrintProcessInfo(i, tProc);
                    }

                    i += 1;
                }
                this.ProcessNamesListView.Focus();
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "GetProcessNameBtn_Click", null);
            }
        }
        private void PrintProcessInfo(int Index, Process CurProc)
        {
            try
            {
                int ListIndex = this.ProcessNamesListView.Items.Count;

                this.ProcessNamesListView.Items.Add(string.Format("{0:#,0}", Index));
                this.ProcessNamesListView.Items[ListIndex].SubItems.Add(string.Format("{0}", CurProc.ProcessName));
                //this.ProcessNamesListView.Items[ListIndex].SubItems.Add(string.Format("{0}", CurProc.Id));
                this.ProcessNamesListView.Items[ListIndex].SubItems.Add(string.Format("{0}", CurProc.MainWindowTitle));
                //this.ProcessNamesListView.Items[ListIndex].SubItems.Add(string.Format("{0}", CurProc.StartTime));

#if DEBUG_MODE
                Console.Write("[{0:000}] ", Index);
                Console.Write("Name : {0}.\t\t", CurProc.ProcessName);
                Console.Write("Proc ID : {0}.\t\t", CurProc.Id);
                Console.Write("Title : {0}\t\t", CurProc.MainWindowTitle);
                Console.Write("Start Time : {0}.\t\t", CurProc.StartTime);
                Console.Write("\n");
#endif
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "PrintProcessInfo", null);
            }
        }

        private static List<Process> GetChildProcesses(Process CurProc)
        {
            List<Process> ChildProc = new List<Process>();

            try
            {
                ManagementObjectSearcher ManageObjs = new ManagementObjectSearcher(string.Format("Select * From Win32_Process Where ParentProcessID={0}", CurProc.Id));

                foreach (ManagementObject ManageObj in ManageObjs.Get())
                {

                    //Console.WriteLine(string.Format("{0}", ManageObj));
                    ChildProc.Add(Process.GetProcessById(Convert.ToInt32(ManageObj["ProcessID"])));
                }

            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "GetChildProcesses", null);
            }
            finally
            {
            }

            return ChildProc;
        }
        private void ProcessNamesListView_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedIndex = Convert.ToInt32(this.ProcessNamesListView.Items[this.ProcessNamesListView.SelectedIndices[0]].SubItems[0].Text);
                List<Process> tChildProc = GetChildProcesses(this.ListProcesses[SelectedIndex]);

#if DEBUG_MODE
                foreach (Process tProc in tChildProc)
                {
                    Console.Write("[{0:000}] ", Index);
                    Console.Write("Name : {0}.\t\t", CurProc.ProcessName);
                    Console.Write("Proc ID : {0}.\t\t", CurProc.Id);
                    Console.Write("Title : {0}\t\t", CurProc.MainWindowTitle);
                    Console.Write("\n");
                }
#endif
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "ProcessNamesListView_Click", null);
            }
        }
        private void ProcessNamesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "ProcessNamesListView_SelectedIndexChanged", null);
            }
        }

        private void SetPlayRangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "SetPlayRangeBtn_Click", null);
            }
        }

        private void SetNextRangeBtn_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "SetNextRangeBtn_Click", null);
            }
        }

    }
}


/*
            try
            {
            }
            catch (System.Exception ex)
            {
                COMMON.Message.ExceptionMsgBox(ex.Message, "", null);
            }
*/
