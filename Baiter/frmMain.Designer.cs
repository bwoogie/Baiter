namespace Baiter {
    partial class frmMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbPopups = new System.Windows.Forms.ListBox();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpArgs = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPopups
            // 
            this.lbPopups.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPopups.FormattingEnabled = true;
            this.lbPopups.Location = new System.Drawing.Point(0, 0);
            this.lbPopups.Name = "lbPopups";
            this.lbPopups.Size = new System.Drawing.Size(159, 406);
            this.lbPopups.TabIndex = 0;
            this.lbPopups.SelectedIndexChanged += new System.EventHandler(this.lbPopups_SelectedIndexChanged);
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(869, 412);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 1;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lbPopups);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 406);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpArgs);
            this.groupBox1.Location = new System.Drawing.Point(170, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(200, 381);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arguments";
            // 
            // flpArgs
            // 
            this.flpArgs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpArgs.Location = new System.Drawing.Point(8, 21);
            this.flpArgs.Name = "flpArgs";
            this.flpArgs.Size = new System.Drawing.Size(184, 352);
            this.flpArgs.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLaunch);
            this.Name = "frmMain";
            this.Text = "Baiter";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPopups;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpArgs;
    }
}

