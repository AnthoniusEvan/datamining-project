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
    public partial class FrmGini : Form
    {
        public FrmGini()
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


                /*using (TextFieldParser csvParser = new TextFieldParser(path))
                {
                    csvParser.CommentTokens = new string[] { "#" };
                    csvParser.SetDelimiters(new string[] { "," });
                    csvParser.HasFieldsEnclosedInQuotes = true;

                    // Skip the row with the column names
                    csvParser.ReadLine();

                    while (!csvParser.EndOfData)
                    {
                        // Read current line fields, pointer moves to the next line.
                        string[] fields = csvParser.ReadFields();
                        string Name = fields[0];
                        string Address = fields[1];
                    }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvData.DataSource != null)
                {
                    Dictionary<string, double> res = ProjectLib.GetGini((DataTable)dgvData.DataSource);
                    label1.Text = "";
                    foreach (KeyValuePair<string, double> kvp in res)
                        label1.Text += String.Format("Name: {0}, GINI: {1};", kvp.Key, kvp.Value);
                    string name;
                    double gain;
                    double value = ProjectLib.CalculateBestSplit((DataTable)dgvData.DataSource, out name, out gain);
                    lblBestSplit.Text = String.Format("The best attribut to split:\nName: {0}, GINI: {1}, GAIN: {2}", name, value, gain);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                string[] texts = label1.Text.Split(';');
                string createText = "";
                foreach (string text in texts)
                {
                    createText += text + "\n";
                }
                createText += lblBestSplit.Text;
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
    }
}
