
namespace DataMining_Project_IT_22
{
    partial class Proxy_MAtrix
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbDistanceType = new System.Windows.Forms.ComboBox();
            this.gbProxMatrix = new System.Windows.Forms.GroupBox();
            this.rdbDissim = new System.Windows.Forms.RadioButton();
            this.rdbSim = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRecordName = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblReset = new System.Windows.Forms.Label();
            this.lblCalculate = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.gbProxMatrix.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.pnlResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.cbDistanceType);
            this.pnlMenu.Controls.Add(this.gbProxMatrix);
            this.pnlMenu.Controls.Add(this.groupBox1);
            this.pnlMenu.Enabled = false;
            this.pnlMenu.Location = new System.Drawing.Point(16, 14);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(281, 554);
            this.pnlMenu.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Distance Type:";
            // 
            // cbDistanceType
            // 
            this.cbDistanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistanceType.FormattingEnabled = true;
            this.cbDistanceType.Items.AddRange(new object[] {
            "City Block",
            "Euclidean",
            "Supremum"});
            this.cbDistanceType.Location = new System.Drawing.Point(18, 50);
            this.cbDistanceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDistanceType.Name = "cbDistanceType";
            this.cbDistanceType.Size = new System.Drawing.Size(247, 28);
            this.cbDistanceType.TabIndex = 29;
            // 
            // gbProxMatrix
            // 
            this.gbProxMatrix.Controls.Add(this.rdbDissim);
            this.gbProxMatrix.Controls.Add(this.rdbSim);
            this.gbProxMatrix.Controls.Add(this.label1);
            this.gbProxMatrix.Controls.Add(this.cbRecordName);
            this.gbProxMatrix.Controls.Add(this.button1);
            this.gbProxMatrix.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold);
            this.gbProxMatrix.Location = new System.Drawing.Point(18, 267);
            this.gbProxMatrix.Name = "gbProxMatrix";
            this.gbProxMatrix.Size = new System.Drawing.Size(247, 247);
            this.gbProxMatrix.TabIndex = 25;
            this.gbProxMatrix.TabStop = false;
            this.gbProxMatrix.Text = "Proximity Matrix";
            // 
            // rdbDissim
            // 
            this.rdbDissim.AutoSize = true;
            this.rdbDissim.Checked = true;
            this.rdbDissim.Font = new System.Drawing.Font("Montserrat", 7F);
            this.rdbDissim.Location = new System.Drawing.Point(16, 133);
            this.rdbDissim.Name = "rdbDissim";
            this.rdbDissim.Size = new System.Drawing.Size(123, 24);
            this.rdbDissim.TabIndex = 27;
            this.rdbDissim.TabStop = true;
            this.rdbDissim.Text = "Dissimilarity";
            this.rdbDissim.UseVisualStyleBackColor = true;
            // 
            // rdbSim
            // 
            this.rdbSim.AutoSize = true;
            this.rdbSim.Font = new System.Drawing.Font("Montserrat", 7F);
            this.rdbSim.Location = new System.Drawing.Point(16, 103);
            this.rdbSim.Name = "rdbSim";
            this.rdbSim.Size = new System.Drawing.Size(102, 24);
            this.rdbSim.TabIndex = 26;
            this.rdbSim.TabStop = true;
            this.rdbSim.Text = "Similarity";
            this.rdbSim.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 7F);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Select column of record name";
            // 
            // cbRecordName
            // 
            this.cbRecordName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRecordName.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecordName.FormattingEnabled = true;
            this.cbRecordName.Items.AddRange(new object[] {
            "City Block",
            "Euclidean",
            "Supremum"});
            this.cbRecordName.Location = new System.Drawing.Point(16, 57);
            this.cbRecordName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRecordName.Name = "cbRecordName";
            this.cbRecordName.Size = new System.Drawing.Size(214, 30);
            this.cbRecordName.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate Distance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblReset);
            this.groupBox1.Controls.Add(this.lblCalculate);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(18, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 144);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculate Distance";
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(16, 81);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(214, 57);
            this.lblReset.TabIndex = 24;
            this.lblReset.Text = "Click the first column of a row to select it";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // lblCalculate
            // 
            this.lblCalculate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculate.Location = new System.Drawing.Point(16, 34);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(225, 40);
            this.lblCalculate.TabIndex = 23;
            this.lblCalculate.Text = "D(_ , _) =";
            // 
            // pnlData
            // 
            this.pnlData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlData.Controls.Add(this.btnView);
            this.pnlData.Controls.Add(this.dgvData);
            this.pnlData.Controls.Add(this.btnImport);
            this.pnlData.Location = new System.Drawing.Point(304, 14);
            this.pnlData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(880, 554);
            this.pnlData.TabIndex = 22;
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(575, 12);
            this.btnView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(290, 49);
            this.btnView.TabIndex = 15;
            this.btnView.Text = "View Proximity Matrix";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Visible = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
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
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
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
            // pnlResult
            // 
            this.pnlResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlResult.Controls.Add(this.btnExport);
            this.pnlResult.Controls.Add(this.dgvResult);
            this.pnlResult.Controls.Add(this.btnBack);
            this.pnlResult.Location = new System.Drawing.Point(304, 14);
            this.pnlResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(880, 554);
            this.pnlResult.TabIndex = 23;
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
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(11, 75);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowHeadersVisible = false;
            this.dgvResult.RowHeadersWidth = 62;
            this.dgvResult.RowTemplate.Height = 28;
            this.dgvResult.Size = new System.Drawing.Size(854, 458);
            this.dgvResult.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(267, 49);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "View Original Data";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Proxy_MAtrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlResult);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Proxy_MAtrix";
            this.Size = new System.Drawing.Size(1199, 581);
            this.Load += new System.EventHandler(this.Proxy_MAtrix_Load);
            this.pnlMenu.ResumeLayout(false);
            this.gbProxMatrix.ResumeLayout(false);
            this.gbProxMatrix.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.pnlResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblCalculate;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.GroupBox gbProxMatrix;
        private System.Windows.Forms.RadioButton rdbDissim;
        private System.Windows.Forms.RadioButton rdbSim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRecordName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDistanceType;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnBack;
    }
}
