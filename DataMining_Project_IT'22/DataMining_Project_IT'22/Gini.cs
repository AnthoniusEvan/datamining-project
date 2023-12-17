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

namespace DataMining_Project_IT_22
{
    public partial class Gini : UserControl
    {
        public Gini()
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

                cbClass.Items.Clear();
                for (int i = 0; i < dgvData.Columns.Count; i++)
                {
                    cbClass.Items.Add(dgvData.Columns[i].Name);
                }
                cbClass.SelectedIndex = dgvData.Columns.Count - 1;

                pnlMenu.Enabled = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (lblResult.Text != "")
            {
                string[] texts = lblInfo.Text.Split('\n');
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
                    Dictionary<string, double> res = ProjectLib.GetGini((DataTable)dgvData.DataSource, cbClass.SelectedIndex);
                    lblInfo.Text = "";
                    int i = 1;
                    foreach (KeyValuePair<string, double> kvp in res)
                    {
                        lblInfo.Text += String.Format("Attribute {0}:\nName: {1}\nGINI: {2}\n\n", i, kvp.Key, kvp.Value);
                        i++;
                    }
                    while (lblInfo.Height < System.Windows.Forms.TextRenderer.MeasureText(lblInfo.Text,
     new Font(lblInfo.Font.FontFamily, lblInfo.Font.Size, lblInfo.Font.Style)).Height)
                    {
                        lblInfo.Font = new Font(lblInfo.Font.FontFamily, lblInfo.Font.Size - 0.5f, lblInfo.Font.Style);
                    }
                    string name;
                    double gain;
                    double value = ProjectLib.CalculateBestSplit((DataTable)dgvData.DataSource, cbClass.SelectedIndex,out name, out gain);
                    lblResult.Text = String.Format("The best attribute to split is by {0} with GINI of {1} and GAIN {2}", name, value, gain);

                    lblInfo.BackColor = Color.LightSteelBlue;
                    lblResult.BackColor = Color.LightSteelBlue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Gini_Load(object sender, EventArgs e)
        {
            dgvData.EnableHeadersVisualStyles = false;
            dgvData.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(60, 77, 129);
            dgvData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvData.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat", 8, FontStyle.Bold);
        }
    }
}
