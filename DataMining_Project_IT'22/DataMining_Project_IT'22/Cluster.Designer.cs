
namespace DataMining_Project_IT_22
{
    partial class Cluster
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnResetTable = new System.Windows.Forms.Button();
            this.nudK = new System.Windows.Forms.NumericUpDown();
            this.lblInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCluster = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMenu.Controls.Add(this.lblWarning);
            this.pnlMenu.Controls.Add(this.btnResetTable);
            this.pnlMenu.Controls.Add(this.nudK);
            this.pnlMenu.Controls.Add(this.lblInfo);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.btnCluster);
            this.pnlMenu.Enabled = false;
            this.pnlMenu.Location = new System.Drawing.Point(16, 14);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(281, 554);
            this.pnlMenu.TabIndex = 23;
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Montserrat Medium", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(22, 69);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(243, 40);
            this.lblWarning.TabIndex = 22;
            this.lblWarning.Text = "Click Header Column to Remove from Cluster Analysis (Optional)";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnResetTable
            // 
            this.btnResetTable.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetTable.Location = new System.Drawing.Point(22, 111);
            this.btnResetTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetTable.Name = "btnResetTable";
            this.btnResetTable.Size = new System.Drawing.Size(243, 54);
            this.btnResetTable.TabIndex = 21;
            this.btnResetTable.Text = "Reset Table";
            this.btnResetTable.UseVisualStyleBackColor = true;
            this.btnResetTable.Click += new System.EventHandler(this.btnResetTable_Click);
            // 
            // nudK
            // 
            this.nudK.Location = new System.Drawing.Point(84, 30);
            this.nudK.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudK.Name = "nudK";
            this.nudK.Size = new System.Drawing.Size(156, 26);
            this.nudK.TabIndex = 20;
            this.nudK.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Montserrat Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(18, 257);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(247, 276);
            this.lblInfo.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 40);
            this.label2.TabIndex = 17;
            this.label2.Text = "K:";
            // 
            // btnCluster
            // 
            this.btnCluster.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCluster.Location = new System.Drawing.Point(22, 180);
            this.btnCluster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCluster.Name = "btnCluster";
            this.btnCluster.Size = new System.Drawing.Size(243, 54);
            this.btnCluster.TabIndex = 15;
            this.btnCluster.Text = "Cluster Data";
            this.btnCluster.UseVisualStyleBackColor = true;
            this.btnCluster.Click += new System.EventHandler(this.btnCluster_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.dgvData);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Location = new System.Drawing.Point(304, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(880, 554);
            this.panel1.TabIndex = 22;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(740, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(125, 49);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(11, 75);
            this.dgvData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(854, 458);
            this.dgvData.TabIndex = 14;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(11, 12);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(125, 49);
            this.btnImport.TabIndex = 13;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Cluster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Cluster";
            this.Size = new System.Drawing.Size(1199, 581);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCluster;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.NumericUpDown nudK;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnResetTable;
    }
}
