namespace Lap6_CRDU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCustomer = new DataGridView();
            txtCustomerID = new TextBox();
            txtCompanyName = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtPhone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Location = new Point(119, 12);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.Size = new Size(623, 224);
            dgvCustomer.TabIndex = 0;
            dgvCustomer.CellMouseDoubleClick += dgvCustomer_CellMouseDoubleClick;
            dgvCustomer.CellMouseUp += dgvCustomer_CellMouseUp;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(243, 263);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 1;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(243, 304);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(289, 23);
            txtCompanyName.TabIndex = 2;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(243, 411);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "เพิ่ม";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(368, 417);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "เเก้ไข";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(508, 418);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "ลบ";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(243, 344);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPhone);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCustomerID);
            Controls.Add(dgvCustomer);
            Name = "Form1";
            Text = "CRDU";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomer;
        private TextBox txtCustomerID;
        private TextBox txtCompanyName;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtPhone;
    }
}
