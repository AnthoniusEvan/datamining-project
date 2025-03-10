﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMining_Project_IT_22
{
    public partial class Cluster : UserControl
    {
        public Cluster()
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
                btnResetTable_Click(sender, e);
                var path = ofd.FileName;
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines[0].Contains(";"))
                    dgvData.DataSource = ProjectLib.NewDataTable(path, ";", true);
                else dgvData.DataSource = ProjectLib.NewDataTable(path, ",", true);
                pnlMenu.Enabled = true;
                nudK.Maximum = dgvData.Rows.Count-1;

                lblInfo.Text = "";
                btnViewResult.Visible = false;
            }
        }
        List<List<double>> res;
        private void btnCluster_Click(object sender, EventArgs e)
        {
            DataTable dt = ((DataTable)dgvData.DataSource).Copy();
            List<List<DataRow>> members;
            List<int> removedIndex = new List<int>();
            for (int i = 0; i < dgvData.Columns.Count; i++)
            {
                if (!dgvData.Columns[i].Visible)
                    removedIndex.Add(i);
            }
            foreach (int i in removedIndex)
            {
                dt.Columns.RemoveAt(i);
            }
            res = ProjectLib.ClusterData(dt, (int)nudK.Value, out members);
            if (res.Count != (int)nudK.Value)
            {
                btnCluster_Click(sender, e);
                return;
            }
            string text = "";
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";
            for (int i = 0; i < res.Count; i++)
            {
                text += string.Format("C{0} = (", i);
                foreach (double r in res[i])
                {
                    text += Math.Round(r, 2).ToString(nfi) + ", ";
                }
                text = text.TrimEnd(new char[] { ',', ' ' });
                text += ")\n";
            }
            lblInfo.Text = text;
            while (lblInfo.Height < System.Windows.Forms.TextRenderer.MeasureText(lblInfo.Text,
     new Font(lblInfo.Font.FontFamily, lblInfo.Font.Size, lblInfo.Font.Style)).Height)
            {
                lblInfo.Font = new Font(lblInfo.Font.FontFamily, lblInfo.Font.Size - 0.5f, lblInfo.Font.Style);
            }
            dgvResult.Columns.Clear();
            dgvResult.Columns.Add("class", "Class");
            foreach (DataColumn c in dt.Columns)
            {
                dgvResult.Columns.Add(c.ColumnName, c.ColumnName);
            }
            int rowIndex = 0;
            for (int i = 0; i < members.Count; i++)
            {
                for (int j = 0; j < members[i].Count; j++)
                {
                    dgvResult.Rows.Add();
                    dgvResult.Rows[rowIndex].Cells[0].Value = "C" + i;
                    for (int k = 0; k < members[i][j].ItemArray.Count(); k++)
                    {
                        dgvResult.Rows[rowIndex].Cells[k + 1].Value = members[i][j][k];
                    }
                    rowIndex++;
                }
            }
            lblInfo.BackColor = Color.LightSteelBlue;
            pnlResult.BringToFront();
            btnViewResult.Visible = true;
        }

        private void btnResetTable_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dgvData.Columns.Count;i++)
            {
                dgvData.Columns[i].Visible = true;
            }
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                dgvData.Columns[e.ColumnIndex].Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlData.BringToFront();
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
                for (int i = 0; i < dgvResult.Columns.Count; i++)
                {
                    createText += dgvResult.Columns[i].HeaderText + ";";
                }
                createText = createText.TrimEnd(';');
                createText += "\n";
                foreach (DataGridViewRow row in dgvResult.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        createText += row.Cells[i].Value + ";";
                    }
                    createText = createText.TrimEnd(';');
                    createText += "\n";
                }
                createText = createText.TrimEnd('\n');

                int curIndex = 0;
                for (int i = 0; i < res.Count; i++){
                    string text = "";
                    NumberFormatInfo nfi = new NumberFormatInfo();
                    nfi.NumberDecimalSeparator = ".";
                    text += string.Format("C{0} = (", i);
                    foreach (double r in res[i])
                    {
                        text += Math.Round(r, 2).ToString(nfi) + ", ";
                    }
                    text = text.TrimEnd(new char[] { ',', ' ' });
                    text += ")";

                    createText = createText.Substring(0, createText.IndexOf('\n', curIndex)) + "; ; ;"+ text + createText.Substring(createText.IndexOf('\n', curIndex), createText.Length - createText.IndexOf('\n', curIndex));

                    curIndex = createText.IndexOf('\n', curIndex) + 1;
                }
 
                File.WriteAllText(sfd.FileName, createText);
            }

        }
        private void btnViewResult_Click(object sender, EventArgs e)
        {
            pnlResult.BringToFront();
        }

        private void Cluster_Load(object sender, EventArgs e)
        {
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 77, 129);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
        }
    }
}
