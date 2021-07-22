using System;
using System.IO;
using System.Windows.Forms;

namespace myPowerShell
{
    public partial class Form1
    {
       //Richtextbox treats drag and drop differently so we need to be creative here. 
       //Not the best solution but it works and maybe there is a better way we will find 

       private void rchtxbx_script_DragDrop(object sender, DragEventArgs e)
        {
            //get text and write it to richtextbox
           try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    string s = a.GetValue(0).ToString();
                    this.Activate();
                    OpenFile(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in DragDrop function: " + ex.Message);
            }
        }

       private void rchtxbx_script_DragEnter(object sender, DragEventArgs e)
        {
            // only accept the dropped data if it has the correct format else do nothing
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }

        private void OpenFile(string sFile)
        {
            try
            {
                StreamReader StreamReader1 = new StreamReader(sFile);
                rchtxbx_script.Text = StreamReader1.ReadToEnd();
                StreamReader1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error loading from file");
            }
        }
    }
}
