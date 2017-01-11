namespace ADOProjectJoshDeLauraClient
{
	partial class frmMain
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
            this.btnEnterNewStock = new System.Windows.Forms.Button();
            this.btnEnterNewCustomer = new System.Windows.Forms.Button();
            this.btnEnterNewEmployee = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
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
            this.panel3.Controls.Add(this.btnOrder);
            this.panel3.Controls.Add(this.btnEnterNewEmployee);
            this.panel3.Controls.Add(this.btnEnterNewCustomer);
            this.panel3.Controls.Add(this.btnEnterNewStock);
            this.panel3.Controls.SetChildIndex(this.btnEnterNewStock, 0);
            this.panel3.Controls.SetChildIndex(this.btnEnterNewCustomer, 0);
            this.panel3.Controls.SetChildIndex(this.btnEnterNewEmployee, 0);
            this.panel3.Controls.SetChildIndex(this.btnOrder, 0);
            // 
            // btnReturnToMain
            // 
            this.btnReturnToMain.Visible = false;
            // 
            // btnEnterNewStock
            // 
            this.btnEnterNewStock.BackColor = System.Drawing.Color.Red;
            this.btnEnterNewStock.Location = new System.Drawing.Point(16, 122);
            this.btnEnterNewStock.Name = "btnEnterNewStock";
            this.btnEnterNewStock.Size = new System.Drawing.Size(177, 23);
            this.btnEnterNewStock.TabIndex = 2;
            this.btnEnterNewStock.Text = "Enter New Stock";
            this.btnEnterNewStock.UseVisualStyleBackColor = false;
            this.btnEnterNewStock.Click += new System.EventHandler(this.btnEnterNewStock_Click);
            // 
            // btnEnterNewCustomer
            // 
            this.btnEnterNewCustomer.BackColor = System.Drawing.Color.Red;
            this.btnEnterNewCustomer.Location = new System.Drawing.Point(16, 75);
            this.btnEnterNewCustomer.Name = "btnEnterNewCustomer";
            this.btnEnterNewCustomer.Size = new System.Drawing.Size(177, 23);
            this.btnEnterNewCustomer.TabIndex = 1;
            this.btnEnterNewCustomer.Text = "Customers";
            this.btnEnterNewCustomer.UseVisualStyleBackColor = false;
            this.btnEnterNewCustomer.Click += new System.EventHandler(this.btnEnterNewCustomer_Click);
            // 
            // btnEnterNewEmployee
            // 
            this.btnEnterNewEmployee.BackColor = System.Drawing.Color.Red;
            this.btnEnterNewEmployee.Location = new System.Drawing.Point(16, 169);
            this.btnEnterNewEmployee.Name = "btnEnterNewEmployee";
            this.btnEnterNewEmployee.Size = new System.Drawing.Size(177, 23);
            this.btnEnterNewEmployee.TabIndex = 3;
            this.btnEnterNewEmployee.Text = "Employee";
            this.btnEnterNewEmployee.UseVisualStyleBackColor = false;
            this.btnEnterNewEmployee.Click += new System.EventHandler(this.btnEnterNewEmployee_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Red;
            this.btnOrder.Location = new System.Drawing.Point(16, 28);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(177, 23);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Orders";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(702, 485);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnEnterNewEmployee;
		private System.Windows.Forms.Button btnEnterNewCustomer;
		private System.Windows.Forms.Button btnEnterNewStock;
        private System.Windows.Forms.Button btnOrder;
	}
}
