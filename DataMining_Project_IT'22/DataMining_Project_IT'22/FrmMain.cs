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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            UnselectControl();
            btnProxy.BackColor = Color.FromArgb(11, 33, 97);
            gini1.Visible = false;
            cluster1.Visible = false;
            proxy_MAtrix1.Visible = true;
        }

        private void btnGini_Click(object sender, EventArgs e)
        {
            UnselectControl();
            btnGini.BackColor = Color.FromArgb(11, 33, 97);
            gini1.Visible = true;
            cluster1.Visible = false;
            proxy_MAtrix1.Visible = false;
        }

        private void btnCluster_Click(object sender, EventArgs e)
        {
            UnselectControl();
            btnCluster.BackColor = Color.FromArgb(11, 33, 97);
            gini1.Visible = false;
            cluster1.Visible = true;
            proxy_MAtrix1.Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnGini.BackColor = Color.FromArgb(11, 33, 97);
        }

        private void UnselectControl()
        {
            btnProxy.BackColor = Color.FromArgb(60, 77, 129);
            btnGini.BackColor = Color.FromArgb(60, 77, 129);
            btnCluster.BackColor = Color.FromArgb(60, 77, 129);
        }
    }
}
