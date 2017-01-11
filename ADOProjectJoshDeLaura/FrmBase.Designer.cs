namespace ADOProjectJoshDeLaura
{
	partial class FrmBase
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
            this.lblDocumentation = new System.Windows.Forms.Label();
            this.picTitleImage = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.btnReturnToMain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.lblDocumentation);
            this.panel1.Controls.Add(this.picTitleImage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(702, 131);
            this.panel1.TabIndex = 0;
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.BackColor = System.Drawing.Color.LightGray;
            this.lblDocumentation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDocumentation.Location = new System.Drawing.Point(8, 96);
            this.lblDocumentation.Name = "lblDocumentation";
            this.lblDocumentation.Size = new System.Drawing.Size(686, 27);
            this.lblDocumentation.TabIndex = 1;
            this.lblDocumentation.Text = "Description";
            this.lblDocumentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picTitleImage
            // 
            this.picTitleImage.BackColor = System.Drawing.Color.LightGray;
            this.picTitleImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picTitleImage.Location = new System.Drawing.Point(8, 8);
            this.picTitleImage.Name = "picTitleImage";
            this.picTitleImage.Size = new System.Drawing.Size(686, 69);
            this.picTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTitleImage.TabIndex = 0;
            this.picTitleImage.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 131);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(702, 354);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(8);
            this.panel3.Size = new System.Drawing.Size(682, 334);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.Controls.Add(this.btnExitProgram);
            this.panel4.Controls.Add(this.btnReturnToMain);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(8, 249);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(8);
            this.panel4.Size = new System.Drawing.Size(666, 77);
            this.panel4.TabIndex = 0;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.BackColor = System.Drawing.Color.LightGray;
            this.btnExitProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitProgram.Location = new System.Drawing.Point(481, 8);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(177, 61);
            this.btnExitProgram.TabIndex = 1;
            this.btnExitProgram.TabStop = false;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = false;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.BackColor = System.Drawing.Color.LightGray;
            this.btnReturnToMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReturnToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMain.Location = new System.Drawing.Point(8, 8);
            this.btnReturnToMain.Name = "btnReturnToMain";
            this.btnReturnToMain.Size = new System.Drawing.Size(177, 61);
            this.btnReturnToMain.TabIndex = 20;
            this.btnReturnToMain.TabStop = false;
            this.btnReturnToMain.Text = "Return to Main Menu";
            this.btnReturnToMain.UseVisualStyleBackColor = false;
            this.btnReturnToMain.Click += new System.EventHandler(this.btnReturnToMain_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBase";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnExitProgram;
		protected System.Windows.Forms.Label lblDocumentation;
		protected System.Windows.Forms.PictureBox picTitleImage;
        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btnReturnToMain;
	}
}

