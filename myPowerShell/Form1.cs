using System;
using System.IO;
using System.Windows.Forms;
using help_about;
using System.Management.Automation.Runspaces; // get from NuGet if .net > 2.0

namespace myPowerShell
{
    public partial class Form1 : Form, IDisposable
    {
        /// <summary>
        /// Powershell runspace
        /// </summary>
        private Runspace runSpace;

        /// <summary>
        /// The active PipelineExecutor instance
        /// </summary>
        private PipelineExecutor pipelineExecutor;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fill Combobox with data from folder.
            FillComboBox();

            // Runspace creation.
            runSpace = RunspaceFactory.CreateRunspace();  // create Powershell runspace
            runSpace.Open(); // open it

            // Richtextbox treats drag and drop differently so we need to be creative here.
            // These are not in properties menu so we need to add by hand
            rchtxbx_script.AllowDrop = true;
            rchtxbx_script.DragEnter += rchtxbx_script_DragEnter;
            rchtxbx_script.DragDrop += rchtxbx_script_DragDrop;

            foreach (DataGridViewColumn col in dgv_result.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            FillComboBox();
            rchtxbx_script.Clear();
            dgv_result.Rows.Clear();
            rchtxbx_result.Clear();
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            rchtxbx_result.Clear();
            rchtxbx_script.Clear();
            dgv_result.Rows.Clear();
            cmbobx_scripts.SelectedIndex = cmbobx_scripts.Items.IndexOf("User_Defined");
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            var f1 = new Help_Form();
            f1.ShowDialog();
            GC.Collect();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopScript(); // stop any running scripts
            runSpace.Close(); // close the powershell runspace
        }

        private void btn_start_script_Click(object sender, EventArgs e)
        {
            StopScript();
            dgv_result.Rows.Clear();
            rchtxbx_result.Clear();
            //rchtxtbx_result.AppendText("Starting script...\r");
            pipelineExecutor = new PipelineExecutor(runSpace, this, rchtxbx_script.Text);
            pipelineExecutor.OnDataReady += pipelineExecutor_OnDataReady;
            pipelineExecutor.OnDataEnd += pipelineExecutor_OnDataEnd;
            pipelineExecutor.OnErrorReady += pipelineExecutor_OnErrorReady;
            pipelineExecutor.Start();
        }

        private void btn_stop_script_Click(object sender, EventArgs e)
        {
            StopScript();
        }

        private void StopScript()
        {
            if (pipelineExecutor != null)
            {
                pipelineExecutor.OnDataReady -= pipelineExecutor_OnDataReady;
                pipelineExecutor.OnDataEnd -= pipelineExecutor_OnDataEnd;
                pipelineExecutor.Stop();
                pipelineExecutor = null;
            }
        }

        void FillComboBox()
        {
            // fill the combobox with entries
            cmbobx_scripts.Items.Clear();


            DirectoryInfo d = new DirectoryInfo(@"scripts"); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                cmbobx_scripts.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
            }

            // this is not a file but an entry to allow users to add items, always start on it.
            cmbobx_scripts.Items.Add("User_Defined");
            cmbobx_scripts.SelectedIndex = cmbobx_scripts.Items.IndexOf("User_Defined");
        }

        private void cmbobx_scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_result.Rows.Clear();
            rchtxbx_result.Clear();

            if (cmbobx_scripts.Text != "User_Defined")
            {
                try
                {
                    rchtxbx_script.Text = File.ReadAllText(Application.StartupPath + "\\scripts\\" + cmbobx_scripts.Text + ".txt");

                }
                catch
                {
                    MessageBox.Show("File not found, click on refresh and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                rchtxbx_script.Clear();                
            }

            //we tick the box depending on what result we are likely to get.
            string FN = cmbobx_scripts.Text;
            int index = FN.IndexOf('_');
            if (FN.Substring(0, index) == "Info")
            {
                chkbx_text.Checked = false;
            }
            else
            {
                chkbx_text.Checked = true;
            }

        }
    }
}
