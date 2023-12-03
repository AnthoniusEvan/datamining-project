using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                var path = ofd.FileName;
                string[] lines = System.IO.File.ReadAllLines(path);
                if (lines[0].Contains(";"))
                    dgvData.DataSource = ProjectLib.NewDataTable(path, ";", true);
                else dgvData.DataSource = ProjectLib.NewDataTable(path, ",", true);
            }
        }

        private void btnCluster_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvData.DataSource;
            List<int> removedIndex = new List<int>();
            for (int i = 0; i < dgvData.Columns.Count; i++)
            {
                if (!dgvData.Columns[i].Visible) removedIndex.Add(i);
                else if (!double.TryParse((string)dgvData.Rows[0].Cells[i].Value, out double s))
                {
                    removedIndex.Add(i);
                }
            }
            foreach(int i in removedIndex){
                dt.Columns.RemoveAt(i);
            }
            ProjectLib.ClusterData(dt, (int)nudK.Value);
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                dgvData.Columns[e.ColumnIndex].Visible = false;
            }
        }

        private void btnResetTable_Click(object sender, EventArgs e)
        {
            for(int i=0;i<dgvData.Columns.Count;i++)
            {
                dgvData.Columns[i].Visible = true;
            }
        }
    }
}
