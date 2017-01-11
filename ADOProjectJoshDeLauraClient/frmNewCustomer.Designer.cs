namespace ADOProjectJoshDeLauraClient
{
	partial class frmNewCustomer
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
            this.lstCusts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.btnAddNewCust = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mtxtZip = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lstOrderDetail = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.Size = new System.Drawing.Size(903, 27);
            // 
            // picTitleImage
            // 
            this.picTitleImage.Size = new System.Drawing.Size(903, 69);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstOrderDetail);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cboState);
            this.panel3.Controls.Add(this.btnClearFields);
            this.panel3.Controls.Add(this.txtCustID);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.mtxtZip);
            this.panel3.Controls.Add(this.mtxtTel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnAddNewCust);
            this.panel3.Controls.Add(this.lstOrders);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Controls.Add(this.txtLName);
            this.panel3.Controls.Add(this.txtFName);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lstCusts);
            this.panel3.Size = new System.Drawing.Size(899, 356);
            this.panel3.Controls.SetChildIndex(this.lstCusts, 0);
            this.panel3.Controls.SetChildIndex(this.label1, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.label4, 0);
            this.panel3.Controls.SetChildIndex(this.label5, 0);
            this.panel3.Controls.SetChildIndex(this.label6, 0);
            this.panel3.Controls.SetChildIndex(this.txtFName, 0);
            this.panel3.Controls.SetChildIndex(this.txtLName, 0);
            this.panel3.Controls.SetChildIndex(this.txtCity, 0);
            this.panel3.Controls.SetChildIndex(this.label7, 0);
            this.panel3.Controls.SetChildIndex(this.lstOrders, 0);
            this.panel3.Controls.SetChildIndex(this.btnAddNewCust, 0);
            this.panel3.Controls.SetChildIndex(this.label8, 0);
            this.panel3.Controls.SetChildIndex(this.label9, 0);
            this.panel3.Controls.SetChildIndex(this.mtxtTel, 0);
            this.panel3.Controls.SetChildIndex(this.mtxtZip, 0);
            this.panel3.Controls.SetChildIndex(this.txtEmail, 0);
            this.panel3.Controls.SetChildIndex(this.label10, 0);
            this.panel3.Controls.SetChildIndex(this.txtCustID, 0);
            this.panel3.Controls.SetChildIndex(this.btnClearFields, 0);
            this.panel3.Controls.SetChildIndex(this.cboState, 0);
            this.panel3.Controls.SetChildIndex(this.label11, 0);
            this.panel3.Controls.SetChildIndex(this.label12, 0);
            this.panel3.Controls.SetChildIndex(this.lstOrderDetail, 0);
            // 
            // lstCusts
            // 
            this.lstCusts.FormattingEnabled = true;
            this.lstCusts.ItemHeight = 16;
            this.lstCusts.Location = new System.Drawing.Point(25, 41);
            this.lstCusts.Name = "lstCusts";
            this.lstCusts.Size = new System.Drawing.Size(168, 212);
            this.lstCusts.TabIndex = 21;
            this.lstCusts.SelectedIndexChanged += new System.EventHandler(this.lstCusts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Customer by Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "City ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Zip";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(306, 45);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(114, 22);
            this.txtFName.TabIndex = 0;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(306, 73);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(114, 22);
            this.txtLName.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(306, 101);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(114, 22);
            this.txtCity.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(445, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Order Numbers for ";
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.ItemHeight = 16;
            this.lstOrders.Location = new System.Drawing.Point(448, 57);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(76, 148);
            this.lstOrders.TabIndex = 14;
            this.lstOrders.SelectedIndexChanged += new System.EventHandler(this.lstOrders_SelectedIndexChanged);
            // 
            // btnAddNewCust
            // 
            this.btnAddNewCust.BackColor = System.Drawing.Color.Red;
            this.btnAddNewCust.Location = new System.Drawing.Point(196, 242);
            this.btnAddNewCust.Name = "btnAddNewCust";
            this.btnAddNewCust.Size = new System.Drawing.Size(224, 23);
            this.btnAddNewCust.TabIndex = 17;
            this.btnAddNewCust.Text = "Submit New Customer";
            this.btnAddNewCust.UseVisualStyleBackColor = false;
            this.btnAddNewCust.Click += new System.EventHandler(this.btnAddNewCust_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email";
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(306, 186);
            this.mtxtTel.Mask = "000-000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtTel.Size = new System.Drawing.Size(114, 22);
            this.mtxtTel.TabIndex = 5;
            // 
            // mtxtZip
            // 
            this.mtxtZip.Location = new System.Drawing.Point(306, 158);
            this.mtxtZip.Mask = "00000";
            this.mtxtZip.Name = "mtxtZip";
            this.mtxtZip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtxtZip.Size = new System.Drawing.Size(114, 22);
            this.mtxtZip.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(306, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(114, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "Customer ID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(543, 211);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(60, 22);
            this.txtCustID.TabIndex = 7;
            // 
            // btnClearFields
            // 
            this.btnClearFields.BackColor = System.Drawing.Color.Red;
            this.btnClearFields.Location = new System.Drawing.Point(448, 242);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(226, 23);
            this.btnClearFields.TabIndex = 28;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = false;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(306, 128);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(114, 24);
            this.cboState.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Selected Customer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(615, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "Selected Order Details";
            // 
            // lstOrderDetail
            // 
            this.lstOrderDetail.FormattingEnabled = true;
            this.lstOrderDetail.ItemHeight = 16;
            this.lstOrderDetail.Location = new System.Drawing.Point(618, 53);
            this.lstOrderDetail.Name = "lstOrderDetail";
            this.lstOrderDetail.Size = new System.Drawing.Size(230, 180);
            this.lstOrderDetail.TabIndex = 31;
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(919, 507);
            this.Name = "frmNewCustomer";
            this.Load += new System.EventHandler(this.frmNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCusts;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNewCust;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtxtZip;
        private System.Windows.Forms.MaskedTextBox mtxtTel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ListBox lstOrderDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;

    }
}
