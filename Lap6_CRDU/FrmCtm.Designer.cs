namespace Lap6_CRDU
{
    partial class FrmCtm
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
            btnSave = new Button();
            btnCancle = new Button();
            txtCustomerID = new TextBox();
            txtCompanyName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(127, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "บันทึก";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancle
            // 
            btnCancle.Location = new Point(262, 260);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(75, 23);
            btnCancle.TabIndex = 1;
            btnCancle.Text = "ยกเลิก";
            btnCancle.UseVisualStyleBackColor = true;
            btnCancle.Click += btnCancle_Click;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(127, 79);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 2;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(127, 123);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(348, 23);
            txtCompanyName.TabIndex = 3;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(127, 171);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(210, 23);
            txtPhone.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 83);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 5;
            label1.Text = "รหัสลูกค้า";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 126);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 6;
            label2.Text = "ชื่อบริษัทของลูกค้า";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 177);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 7;
            label3.Text = "โทรศัพท์";
            // 
            // FrmCtm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtCompanyName);
            Controls.Add(txtCustomerID);
            Controls.Add(btnCancle);
            Controls.Add(btnSave);
            Name = "FrmCtm";
            Text = "FrmCtm";
            Load += FrmCtm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancle;
        private TextBox txtCustomerID;
        private TextBox txtCompanyName;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}