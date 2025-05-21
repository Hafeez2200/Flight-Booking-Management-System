namespace FlightBookingManagementSystem
{
    partial class RegistrationForm
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
            txtfullname = new TextBox();
            txtemail = new TextBox();
            txtphone = new TextBox();
            txtpassport = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(291, 40);
            txtfullname.Margin = new Padding(3, 4, 3, 4);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(177, 27);
            txtfullname.TabIndex = 0;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(291, 123);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(177, 27);
            txtemail.TabIndex = 1;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(291, 207);
            txtphone.Margin = new Padding(3, 4, 3, 4);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(177, 27);
            txtphone.TabIndex = 2;
            // 
            // txtpassport
            // 
            txtpassport.Location = new Point(291, 303);
            txtpassport.Margin = new Padding(3, 4, 3, 4);
            txtpassport.Name = "txtpassport";
            txtpassport.Size = new Size(177, 27);
            txtpassport.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 44);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 4;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 127);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(51, 211);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(51, 301);
            label4.Name = "label4";
            label4.Size = new Size(169, 25);
            label4.TabIndex = 7;
            label4.Text = "Passport Number";
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.Location = new Point(181, 384);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(159, 76);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 517);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpassport);
            Controls.Add(txtphone);
            Controls.Add(txtemail);
            Controls.Add(txtfullname);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtfullname;
        private TextBox txtemail;
        private TextBox txtphone;
        private TextBox txtpassport;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRegister;
    }
}