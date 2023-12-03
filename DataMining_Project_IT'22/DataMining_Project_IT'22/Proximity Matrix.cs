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

                pnlMenu.Enabled = true;
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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.DataSource != null)
                {
                    if (cbDistanceType.SelectedIndex == 1)
                    {

                    }
                    lblResult.BackColor = Color.LightSteelBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string selected1="", selected2 = "";
        int row1=0, row2=0;
        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 0)
            {
                if (selected1 == "") {
                    selected1 = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    row1 = e.RowIndex;
                }
                else {
                    selected2 = dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    row2 = e.RowIndex;
                }

                CalculateManualSelection();
            }
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            if (selected1 != "" && selected2 != "")
            {
                lblCalculate.Text = "D(_, _) = ";
                lblReset.Text = "Click the first column of a row to select it";
                selected1 = "";
                selected2 = "";
            }
        }
        private void CalculateManualSelection()
        {
            lblCalculate.Text = string.Format("D({0}, {1}) = ", selected1, selected2);
            if (selected1 != "" && selected2 != "")
            {
                lblReset.Text = "Click here to reset calculation";

                double res = 0;
                if (cbDistanceType.SelectedIndex == 0)
                {
                    res = ProjectLib.CalculateCityBlockDistance(((DataTable)dgvData.DataSource).Rows[row1], ((DataTable)dgvData.DataSource).Rows[row2]);
                }
                else if (cbDistanceType.SelectedIndex == 1)
                {
                    res = ProjectLib.CalculateEuclideanDistance(((DataTable)dgvData.DataSource).Rows[row1], ((DataTable)dgvData.DataSource).Rows[row2]);
                }
                else if (cbDistanceType.SelectedIndex == 2)
                {
                    res = ProjectLib.CalculateSupremumDistance(((DataTable)dgvData.DataSource).Rows[row1], ((DataTable)dgvData.DataSource).Rows[row2]);
                }

                if (cbDistanceType.SelectedIndex == -1)
                {
                    lblReset.Text = "Please select the distance type first";
                }
                else
                {
                    if (res != 0)
                        lblCalculate.Text += res.ToString("#.###");
                    else lblCalculate.Text += res.ToString();
                }
            }
        }
        private void cbDistanceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDistanceType.SelectedIndex != -1) lblReset.Text = "Click the first column of a row to select it";
            CalculateManualSelection();
        }
    }
}
