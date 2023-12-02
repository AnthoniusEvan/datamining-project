
namespace DataMining_Project_IT_22
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProxy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCluster = new System.Windows.Forms.Button();
            this.btnGini = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gini1 = new DataMining_Project_IT_22.Gini();
            this.proxy_MAtrix1 = new DataMining_Project_IT_22.Proxy_MAtrix();
            this.cluster1 = new DataMining_Project_IT_22.Cluster();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(129)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 31);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Mining Project";
            // 
            // btnProxy
            // 
            this.btnProxy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(129)))));
            this.btnProxy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))));
            this.btnProxy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))));
            this.btnProxy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProxy.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProxy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProxy.Location = new System.Drawing.Point(6, 66);
            this.btnProxy.Name = "btnProxy";
            this.btnProxy.Size = new System.Drawing.Size(188, 43);
            this.btnProxy.TabIndex = 0;
            this.btnProxy.Text = "Proxy Matrix";
            this.btnProxy.UseVisualStyleBackColor = false;
            this.btnProxy.Click += new System.EventHandler(this.btnProxy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(129)))));
            this.panel2.Controls.Add(this.btnCluster);
            this.panel2.Controls.Add(this.btnGini);
            this.panel2.Controls.Add(this.btnProxy);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 463);
            this.panel2.TabIndex = 1;
            // 
            // btnCluster
            // 
            this.btnCluster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(129)))));
            this.btnCluster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))));
            this.btnCluster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))));
            this.btnCluster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCluster.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCluster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCluster.Location = new System.Drawing.Point(6, 187);
            this.btnCluster.Name = "btnCluster";
            this.btnCluster.Size = new System.Drawing.Size(188, 43);
            this.btnCluster.TabIndex = 2;
            this.btnCluster.Text = "Cluster";
            this.btnCluster.UseVisualStyleBackColor = false;
            this.btnCluster.Click += new System.EventHandler(this.btnCluster_Click);
            // 
            // btnGini
            // 
            this.btnGini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(77)))), ((int)(((byte)(129)))));
            this.btnGini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))));
            this.btnGini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(33)))), ((int)(((byte)(97)))));
            this.btnGini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGini.Font = new System.Drawing.Font("Montserrat SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGini.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGini.Location = new System.Drawing.Point(6, 127);
            this.btnGini.Name = "btnGini";
            this.btnGini.Size = new System.Drawing.Size(188, 43);
            this.btnGini.TabIndex = 1;
            this.btnGini.Text = "Gini Index";
            this.btnGini.UseVisualStyleBackColor = false;
            this.btnGini.Click += new System.EventHandler(this.btnGini_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gini1);
            this.panel3.Controls.Add(this.proxy_MAtrix1);
            this.panel3.Controls.Add(this.cluster1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 463);
            this.panel3.TabIndex = 2;
            // 
            // gini1
            // 
            this.gini1.Location = new System.Drawing.Point(6, -2);
            this.gini1.Name = "gini1";
            this.gini1.Size = new System.Drawing.Size(1066, 465);
            this.gini1.TabIndex = 2;
            // 
            // proxy_MAtrix1
            // 
            this.proxy_MAtrix1.Location = new System.Drawing.Point(0, -2);
            this.proxy_MAtrix1.Name = "proxy_MAtrix1";
            this.proxy_MAtrix1.Size = new System.Drawing.Size(1066, 465);
            this.proxy_MAtrix1.TabIndex = 1;
            // 
            // cluster1
            // 
            this.cluster1.Location = new System.Drawing.Point(0, -2);
            this.cluster1.Name = "cluster1";
            this.cluster1.Size = new System.Drawing.Size(1066, 465);
            this.cluster1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 494);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProxy;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCluster;
        private System.Windows.Forms.Button btnGini;
        private System.Windows.Forms.Panel panel3;
        private Proxy_MAtrix proxy_MAtrix1;
        private Cluster cluster1;
        private Gini gini1;
    }
}