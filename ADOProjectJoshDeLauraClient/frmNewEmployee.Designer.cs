namespace ADOProjectJoshDeLauraClient
{
	partial class frmNewEmployee
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
            this.lstEmployee = new System.Windows.Forms.ListBox();
            this.cboSampleQuery = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEnterNew = new System.Windows.Forms.Button();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnEmployeeCount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEnterFirstName = new System.Windows.Forms.TextBox();
            this.btnGetLastName = new System.Windows.Forms.Button();
            this.mtxtHireDate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTitleImage
            // 
            this.picTitleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mtxtHireDate);
            this.panel3.Controls.Add(this.btnGetLastName);
            this.panel3.Controls.Add(this.txtEnterFirstName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnEmployeeCount);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtAge);
            this.panel3.Controls.Add(this.txtLname);
            this.panel3.Controls.Add(this.txtFName);
            this.panel3.Controls.Add(this.btnEnterNew);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cboSampleQuery);
            this.panel3.Controls.Add(this.lstEmployee);
            this.panel3.Size = new System.Drawing.Size(682, 487);
            this.panel3.Controls.SetChildIndex(this.lstEmployee, 0);
            this.panel3.Controls.SetChildIndex(this.cboSampleQuery, 0);
            this.panel3.Controls.SetChildIndex(this.label1, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.label5, 0);
            this.panel3.Controls.SetChildIndex(this.label6, 0);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.btnEnterNew, 0);
            this.panel3.Controls.SetChildIndex(this.txtFName, 0);
            this.panel3.Controls.SetChildIndex(this.txtLname, 0);
            this.panel3.Controls.SetChildIndex(this.txtAge, 0);
            this.panel3.Controls.SetChildIndex(this.label8, 0);
            this.panel3.Controls.SetChildIndex(this.lblTotal, 0);
            this.panel3.Controls.SetChildIndex(this.btnEmployeeCount, 0);
            this.panel3.Controls.SetChildIndex(this.label9, 0);
            this.panel3.Controls.SetChildIndex(this.txtEnterFirstName, 0);
            this.panel3.Controls.SetChildIndex(this.btnGetLastName, 0);
            this.panel3.Controls.SetChildIndex(this.mtxtHireDate, 0);
            // 
            // lstEmployee
            // 
            this.lstEmployee.FormattingEnabled = true;
            this.lstEmployee.ItemHeight = 16;
            this.lstEmployee.Location = new System.Drawing.Point(16, 11);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(650, 84);
            this.lstEmployee.TabIndex = 1;
            // 
            // cboSampleQuery
            // 
            this.cboSampleQuery.FormattingEnabled = true;
            this.cboSampleQuery.Location = new System.Drawing.Point(16, 136);
            this.cboSampleQuery.Name = "cboSampleQuery";
            this.cboSampleQuery.Size = new System.Drawing.Size(250, 24);
            this.cboSampleQuery.TabIndex = 2;
            this.cboSampleQuery.SelectedIndexChanged += new System.EventHandler(this.cboSampleQuery_SelectedIndexChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find Employee Names by First Letter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add New Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date of Hire (mm/dd/yyyy)";
            // 
            // btnEnterNew
            // 
            this.btnEnterNew.BackColor = System.Drawing.Color.Red;
            this.btnEnterNew.Location = new System.Drawing.Point(16, 339);
            this.btnEnterNew.Name = "btnEnterNew";
            this.btnEnterNew.Size = new System.Drawing.Size(250, 23);
            this.btnEnterNew.TabIndex = 10;
            this.btnEnterNew.Text = "Enter New Employee Data";
            this.btnEnterNew.UseVisualStyleBackColor = false;
            this.btnEnterNew.Click += new System.EventHandler(this.btnEnterNew_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(214, 210);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 22);
            this.txtFName.TabIndex = 12;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(214, 235);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 22);
            this.txtLname.TabIndex = 13;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(214, 263);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Total Employees in Company";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(486, 144);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 16);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0";
            // 
            // btnEmployeeCount
            // 
            this.btnEmployeeCount.BackColor = System.Drawing.Color.Red;
            this.btnEmployeeCount.Location = new System.Drawing.Point(392, 175);
            this.btnEmployeeCount.Name = "btnEmployeeCount";
            this.btnEmployeeCount.Size = new System.Drawing.Size(208, 23);
            this.btnEmployeeCount.TabIndex = 18;
            this.btnEmployeeCount.Text = "Retrieve Employee Count";
            this.btnEmployeeCount.UseVisualStyleBackColor = false;
            this.btnEmployeeCount.Click += new System.EventHandler(this.btnEmployeeCount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(389, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Enter First Name to get Last Name";
            // 
            // txtEnterFirstName
            // 
            this.txtEnterFirstName.Location = new System.Drawing.Point(392, 253);
            this.txtEnterFirstName.Name = "txtEnterFirstName";
            this.txtEnterFirstName.Size = new System.Drawing.Size(241, 22);
            this.txtEnterFirstName.TabIndex = 20;
            // 
            // btnGetLastName
            // 
            this.btnGetLastName.BackColor = System.Drawing.Color.Red;
            this.btnGetLastName.Location = new System.Drawing.Point(392, 286);
            this.btnGetLastName.Name = "btnGetLastName";
            this.btnGetLastName.Size = new System.Drawing.Size(241, 23);
            this.btnGetLastName.TabIndex = 21;
            this.btnGetLastName.Text = "Get Last Name from First Name";
            this.btnGetLastName.UseVisualStyleBackColor = false;
            this.btnGetLastName.Click += new System.EventHandler(this.btnGetLastName_Click);
            // 
            // mtxtHireDate
            // 
            this.mtxtHireDate.Location = new System.Drawing.Point(214, 294);
            this.mtxtHireDate.Mask = "00/00/0000";
            this.mtxtHireDate.Name = "mtxtHireDate";
            this.mtxtHireDate.Size = new System.Drawing.Size(100, 22);
            this.mtxtHireDate.TabIndex = 22;
            this.mtxtHireDate.ValidatingType = typeof(System.DateTime);
            // 
            // frmNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(702, 638);
            this.Name = "frmNewEmployee";
            this.Load += new System.EventHandler(this.frmNewEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.ListBox lstEmployee;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSampleQuery;
		private System.Windows.Forms.TextBox txtAge;
		private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.Button btnEnterNew;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEmployeeCount;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btnGetLastName;
		private System.Windows.Forms.TextBox txtEnterFirstName;
		private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtHireDate;
	}
}
