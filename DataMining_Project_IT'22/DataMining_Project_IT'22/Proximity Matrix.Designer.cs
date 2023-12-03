
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDistanceType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            this.rdbMink = new System.Windows.Forms.RadioButton();
            this.rdbMahal = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.lblResult);
            this.panel2.Controls.Add(this.rdbMahal);
            this.panel2.Controls.Add(this.rdbMink);
            this.panel2.Controls.Add(this.cbDistanceType);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(16, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 554);
            this.panel2.TabIndex = 23;
            // 
            // cbDistanceType
            // 
            this.cbDistanceType.FormattingEnabled = true;
            this.cbDistanceType.Items.AddRange(new object[] {
            "City Block",
            "Euclidean",
            "Supremum"});
            this.cbDistanceType.Location = new System.Drawing.Point(18, 111);
            this.cbDistanceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDistanceType.Name = "cbDistanceType";
            this.cbDistanceType.Size = new System.Drawing.Size(247, 28);
            this.cbDistanceType.TabIndex = 18;
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
            this.button1.Location = new System.Drawing.Point(18, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 54);
            this.button1.TabIndex = 15;
            this.button1.Text = "Calculate Distance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // 
            // rdbMink
            // 
            this.rdbMink.AutoSize = true;
            this.rdbMink.Location = new System.Drawing.Point(18, 65);
            this.rdbMink.Name = "rdbMink";
            this.rdbMink.Size = new System.Drawing.Size(106, 24);
            this.rdbMink.TabIndex = 19;
            this.rdbMink.TabStop = true;
            this.rdbMink.Text = "Minkowski";
            this.rdbMink.UseVisualStyleBackColor = true;
            this.rdbMink.CheckedChanged += new System.EventHandler(this.rdbMink_CheckedChanged);
            // 
            // rdbMahal
            // 
            this.rdbMahal.AutoSize = true;
            this.rdbMahal.Location = new System.Drawing.Point(141, 65);
            this.rdbMahal.Name = "rdbMahal";
            this.rdbMahal.Size = new System.Drawing.Size(124, 24);
            this.rdbMahal.TabIndex = 20;
            this.rdbMahal.TabStop = true;
            this.rdbMahal.Text = "Mahalanobis";
            this.rdbMahal.UseVisualStyleBackColor = true;
            this.rdbMahal.CheckedChanged += new System.EventHandler(this.rdbMahal_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Montserrat", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(18, 231);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(247, 83);
            this.lblResult.TabIndex = 22;
            // 
            // Proxy_MAtrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Proxy_MAtrix";
            this.Size = new System.Drawing.Size(1199, 581);
            this.Load += new System.EventHandler(this.Proxy_MAtrix_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDistanceType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RadioButton rdbMahal;
        private System.Windows.Forms.RadioButton rdbMink;
        private System.Windows.Forms.Label lblResult;
    }
}
