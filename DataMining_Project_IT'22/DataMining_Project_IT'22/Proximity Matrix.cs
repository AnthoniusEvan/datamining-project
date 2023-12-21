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
                
                cbRecordName.Items.Clear();
                for (int i = 0; i < dgvData.Columns.Count; i++)
                {
                    cbRecordName.Items.Add(dgvData.Columns[i].Name);
                }
                cbRecordName.SelectedIndex = 0;
                pnlMenu.Enabled = true;

                selected1 = "1";
                selected2 = "2";
                lblReset_Click(sender, e);

                btnView.Visible = false;
            }
        }
        private void Proxy_MAtrix_Load(object sender, EventArgs e)
        {
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60,77,129);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (dgvData.DataSource != null)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add(" ");
                for (int i = 0; i < dgvData.Rows.Count - 1; i++)
                {
                    if (dt.Columns.Contains(dgvData.Rows[i].Cells[cbRecordName.SelectedIndex].Value.ToString()))
                        dt.Columns.Add(dgvData.Rows[i].Cells[cbRecordName.SelectedIndex].Value.ToString()+i);
                    else
                        dt.Columns.Add(dgvData.Rows[i].Cells[cbRecordName.SelectedIndex].Value.ToString());
                }
                for (int i = 0; i < dgvData.Rows.Count - 1; i++)
                {
                    DataRow rowA = ((DataTable)dgvData.DataSource).Rows[i];

                    DataRow row = dt.NewRow();
                    if (i>0 && dgvData.Rows[i-1].Cells[cbRecordName.SelectedIndex].Value.ToString() == dgvData.Rows[i].Cells[cbRecordName.SelectedIndex].Value.ToString())
                        row[0] = dgvData.Rows[i].Cells[cbRecordName.SelectedIndex].Value.ToString()+i;
                    else
                        row[0] = dgvData.Rows[i].Cells[cbRecordName.SelectedIndex].Value.ToString();

                    for (int j = 0; j < dgvData.Rows.Count - 1; j++)
                    {
                        DataRow rowB = ((DataTable)dgvData.DataSource).Rows[j];
                        if (cbDistanceType.SelectedIndex == 0)
                            row[j + 1] = Math.Round(ProjectLib.CalculateCityBlockDistance(rowA, rowB),3);
                        else if (cbDistanceType.SelectedIndex == 1)
                            row[j + 1] = Math.Round(ProjectLib.CalculateEuclideanDistance(rowA, rowB),3);
                        else if (cbDistanceType.SelectedIndex == 2)
                            row[j + 1] = Math.Round(ProjectLib.CalculateSupremumDistance(rowA, rowB),3);
                        else
                        {
                            MessageBox.Show("Please select the distance type first!", "Information");
                            return;
                        }

                        if (rdbSim.Checked)
                        {
                            if (Convert.ToDouble(row[j + 1]) == 0)
                                row[j + 1] = 1;
                            else
                                row[j + 1] = Convert.ToDouble(row[j + 1]) * -1;
                        }
                    }
                    dt.Rows.Add(row);
                }
                dgvResult.DataSource = dt;
                btnView.Visible = true;
                pnlResult.BringToFront();

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            string createText = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Export to File";
            sfd.DefaultExt = "csv";
            sfd.Filter = "csv files (*.csv)|*.csv|txt files (*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < dgvResult.Columns.Count; i++)
                {
                    createText += dgvResult.Columns[i].HeaderText + ";";
                }
                createText = createText.TrimEnd(';');
                createText += "\n";
                foreach(DataRow row in ((DataTable)dgvResult.DataSource).Rows)
                {
                    for(int i = 0; i < row.ItemArray.Count(); i++)
                    {
                        createText += row[i] + ";";
                    }
                    createText = createText.TrimEnd(';');
                    createText += "\n";
                }

                File.WriteAllText(sfd.FileName, createText);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlData.BringToFront();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            pnlResult.BringToFront();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
