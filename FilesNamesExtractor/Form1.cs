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

using System.Data.SqlClient;

using FilesNamesExtractor.Properties;


namespace FilesNamesExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            rtbFileNames.Text = "";
            rtbFileSize.Text = "";
            DirectoryInfo d = new DirectoryInfo(txtPath.Text);//Assuming Test is your Folder
            FileInfo[] Files;

            int count = 0;

            //string[] filePaths;
            //filePaths = Directory.GetFiles(txtPath.Text);
            //string[] subdirectoryEntries = Directory.GetDirectories(dir);
            ////filePaths = Directory.GetFiles(txtPath.Text);
            //foreach (var file in filePaths)
            //{
            //    rtbFileNames.AppendText(file + "\n");
            //    count++;
            //}
            
            

            if (chkExtension.Checked == false)
                Files = d.GetFiles();
            else
                Files = d.GetFiles("*." + txtExtension.Text,SearchOption.AllDirectories);
            
            foreach (var file in Files)
            {
                if (chkDisplayExtension.Checked == true)
                    rtbFileNames.AppendText(file.Name + "\n");
                else
                    rtbFileNames.AppendText(file.Name.Substring(0, file.Name.Length - file.Extension.Length) + "\n");
                count++;

                rtbFileSize.AppendText(file.Length.ToString() + "\n");
            }

            if (chkIncludeDirectories.Checked == true)
            {
                var dir = d.GetDirectories();
                foreach (var item in dir)
                {
                    rtbFileNames.AppendText(item.Name + "\n");
                    count++;
                    
                }
            }
            
            lblCount.Text = "Count " + count.ToString();
        }

        private void ChkExtension_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtension.Checked == true)
            {
                txtExtension.Enabled = true;
            }
            else txtExtension.Enabled = false;
        }
    }
}
