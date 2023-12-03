
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
            this.lblResult = new System.Windows.Forms.Label();
            this.cbDistanceType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblCalculate = new System.Windows.Forms.Label();
            this.lblReset = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMenu.Controls.Add(this.lblReset);
            this.pnlMenu.Controls.Add(this.lblCalculate);
            this.pnlMenu.Controls.Add(this.lblResult);
            this.pnlMenu.Controls.Add(this.cbDistanceType);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Enabled = false;
            this.pnlMenu.Location = new System.Drawing.Point(16, 14);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(281, 554);
            this.pnlMenu.TabIndex = 23;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(18, 270);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(247, 83);
            this.lblResult.TabIndex = 22;
            // 
            // cbDistanceType
            // 
            this.cbDistanceType.FormattingEnabled = true;
            this.cbDistanceType.Items.AddRange(new object[] {
            "City Block",
            "Euclidean",
            "Supremum"});
            this.cbDistanceType.Location = new System.Drawing.Point(18, 49);
            this.cbDistanceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDistanceType.Name = "cbDistanceType";
            this.cbDistanceType.Size = new System.Drawing.Size(247, 28);
            this.cbDistanceType.TabIndex = 18;
            this.cbDistanceType.SelectedIndexChanged += new System.EventHandler(this.cbDistanceType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 40);
            this.label2.TabIndex = 17;
            this.label2.Text = "Proximity Matrix:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate Distance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalc_Click);
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
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
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
            // lblCalculate
            // 
            this.lblCalculate.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculate.Location = new System.Drawing.Point(18, 93);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(247, 40);
            this.lblCalculate.TabIndex = 23;
            this.lblCalculate.Text = "D(_ , _) =";
            // 
            // lblReset
            // 
            this.lblReset.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.Location = new System.Drawing.Point(18, 140);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(247, 49);
            this.lblReset.TabIndex = 24;
            this.lblReset.Text = "Click the first column of a row to select it";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // Proxy_MAtrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Proxy_MAtrix";
            this.Size = new System.Drawing.Size(1199, 581);
            this.Load += new System.EventHandler(this.Proxy_MAtrix_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ComboBox cbDistanceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCalculate;
        private System.Windows.Forms.Label lblReset;
    }
}
