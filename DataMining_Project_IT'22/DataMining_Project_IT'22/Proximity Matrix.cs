using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace DataMining_Project_IT_22
{
    public partial class Proxy_MAtrix : UserControl
    {
        public Proxy_MAtrix()
        {
            InitializeComponent();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Browse Records";
            ofd.DefaultExt = "csv";
            ofd.Filter = "csv files (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var path = ofd.FileName;
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines[0].Contains(";"))
                    dgvData.DataSource = ProjectLib.NewDataTable(path, ";", true);
                else dgvData.DataSource = ProjectLib.NewDataTable(path, ",", true);
            }
        }
        private void Proxy_MAtrix_Load(object sender, EventArgs e)
        {
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60,77,129);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                string[] texts = lblResult.Text.Split(';');
                string createText = "";
                foreach (string text in texts)
                {
                    createText += text + "\n";
                }
                createText += lblResult.Text;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Export to File";
                sfd.DefaultExt = "txt";
                sfd.Filter = "txt files (*.txt)|*.txt|out files (*.out)|*.out";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, createText);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.DataSource != null)
                {
                    
                    lblResult.BackColor = Color.LightSteelBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rdbMahal_CheckedChanged(object sender, EventArgs e)
        {
            CheckedDistance();
        }

        private void rdbMink_CheckedChanged(object sender, EventArgs e)
        {
            CheckedDistance();
        }
        private void CheckedDistance()
        {
            if (rdbMahal.Checked)
            {
                cbDistanceType.SelectedIndex = -1;
                cbDistanceType.Enabled = false;
            }
            else
            {
                if (!cbDistanceType.Enabled) cbDistanceType.Enabled = true;
            }
        }
    }
}
