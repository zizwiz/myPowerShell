using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Windows.Forms;

namespace myPowerShell
{
    public partial class Form1
    {


        private void pipelineExecutor_OnDataEnd(PipelineExecutor sender)
        {
            if (sender.Pipeline.PipelineStateInfo.State == PipelineState.Failed)
            {
                MessageBox.Show(string.Format("Error in script: {0}\r", sender.Pipeline.PipelineStateInfo.Reason));
            }

        }

        private void pipelineExecutor_OnDataReady(PipelineExecutor sender, ICollection<PSObject> data)
        {
            if (!chkbx_text.Checked)
            {
                try
                {
                    dgv_result.Visible = true;
                    rchtxbx_result.Visible = false;
                    dgv_result.Rows.Clear();

                    foreach (PSObject obj in data)
                    {
                        foreach (PSPropertyInfo psPropertyInfo in obj.Properties)

                        {
                            string[] row = new string[] { psPropertyInfo.Name, "" + psPropertyInfo.Value, psPropertyInfo.MemberType.ToString() };
                            dgv_result.Rows.Add(row);
                        }
                    }

                    dgv_result.FirstDisplayedScrollingRowIndex = dgv_result.RowCount - 1; //remove bootom grey section
                    dgv_result.RowHeadersVisible = false; //remove left hand column

                    dgv_result.FirstDisplayedScrollingRowIndex = 0; //start at top row
                    dgv_result.ClearSelection(); //do not select anything*/
                }
                catch
                {
                    MessageBox.Show("That did not work/rCheck you ticked correct box/rCheck Script");
                }
            }
            else
            {
                try
                {
                    dgv_result.Visible = false;
                    rchtxbx_result.Visible = true;
                    foreach (PSObject obj in data)
                    {

                        rchtxbx_result.AppendText(obj + "\r");

                    }

                }
                catch
                {
                    MessageBox.Show("That did not work/rCheck you ticked correct box/rCheck Script");
                }
            }
        }

        void pipelineExecutor_OnErrorReady(PipelineExecutor sender, ICollection<object> data)
        {
            foreach (object e in data)
            {
                MessageBox.Show("Error : " + e.ToString());
            }
        }


    }
}
