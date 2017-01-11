namespace ADOProjectJoshDeLauraClient
{
    partial class frmOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtSerialNo = new System.Windows.Forms.MaskedTextBox();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.mtxtCustNo = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEmpNo = new System.Windows.Forms.MaskedTextBox();
            this.lstOrderInfo = new System.Windows.Forms.ListBox();
            this.lstCustInfo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocumentation
            // 
            this.lblDocumentation.Size = new System.Drawing.Size(898, 27);
            // 
            // picTitleImage
            // 
            this.picTitleImage.Size = new System.Drawing.Size(898, 69);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lstCustInfo);
            this.panel3.Controls.Add(this.lstOrderInfo);
            this.panel3.Controls.Add(this.mtxtEmpNo);
            this.panel3.Controls.Add(this.mtxtCustNo);
            this.panel3.Controls.Add(this.btnPlaceOrder);
            this.panel3.Controls.Add(this.mtxtSerialNo);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Size = new System.Drawing.Size(894, 334);
            this.panel3.Controls.SetChildIndex(this.label1, 0);
            this.panel3.Controls.SetChildIndex(this.label2, 0);
            this.panel3.Controls.SetChildIndex(this.label3, 0);
            this.panel3.Controls.SetChildIndex(this.mtxtSerialNo, 0);
            this.panel3.Controls.SetChildIndex(this.btnPlaceOrder, 0);
            this.panel3.Controls.SetChildIndex(this.mtxtCustNo, 0);
            this.panel3.Controls.SetChildIndex(this.mtxtEmpNo, 0);
            this.panel3.Controls.SetChildIndex(this.lstOrderInfo, 0);
            this.panel3.Controls.SetChildIndex(this.lstCustInfo, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Serial Number";
            // 
            // mtxtSerialNo
            // 
            this.mtxtSerialNo.Location = new System.Drawing.Point(552, 100);
            this.mtxtSerialNo.Mask = "LL999";
            this.mtxtSerialNo.Name = "mtxtSerialNo";
            this.mtxtSerialNo.Size = new System.Drawing.Size(49, 22);
            this.mtxtSerialNo.TabIndex = 2;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.Red;
            this.btnPlaceOrder.Location = new System.Drawing.Point(385, 200);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(216, 23);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // mtxtCustNo
            // 
            this.mtxtCustNo.Location = new System.Drawing.Point(552, 24);
            this.mtxtCustNo.Mask = "9999";
            this.mtxtCustNo.Name = "mtxtCustNo";
            this.mtxtCustNo.Size = new System.Drawing.Size(49, 22);
            this.mtxtCustNo.TabIndex = 0;
            // 
            // mtxtEmpNo
            // 
            this.mtxtEmpNo.Location = new System.Drawing.Point(552, 62);
            this.mtxtEmpNo.Mask = "9999";
            this.mtxtEmpNo.Name = "mtxtEmpNo";
            this.mtxtEmpNo.Size = new System.Drawing.Size(49, 22);
            this.mtxtEmpNo.TabIndex = 1;
            // 
            // lstOrderInfo
            // 
            this.lstOrderInfo.FormattingEnabled = true;
            this.lstOrderInfo.ItemHeight = 16;
            this.lstOrderInfo.Location = new System.Drawing.Point(625, 24);
            this.lstOrderInfo.Name = "lstOrderInfo";
            this.lstOrderInfo.Size = new System.Drawing.Size(253, 196);
            this.lstOrderInfo.TabIndex = 4;
            // 
            // lstCustInfo
            // 
            this.lstCustInfo.FormattingEnabled = true;
            this.lstCustInfo.ItemHeight = 16;
            this.lstCustInfo.Location = new System.Drawing.Point(16, 27);
            this.lstCustInfo.Name = "lstCustInfo";
            this.lstCustInfo.Size = new System.Drawing.Size(162, 196);
            this.lstCustInfo.TabIndex = 5;
            this.lstCustInfo.SelectedIndexChanged += new System.EventHandler(this.lstCustInfo_SelectedIndexChanged);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(914, 485);
            this.Name = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitleImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxtSerialNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtEmpNo;
        private System.Windows.Forms.MaskedTextBox mtxtCustNo;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.ListBox lstOrderInfo;
        private System.Windows.Forms.ListBox lstCustInfo;
    }
}
