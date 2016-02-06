namespace testapp
{
    partial class frmLogOnUser
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPassConf = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER CREATE PAGE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(155, 83);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(155, 109);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.HideSelection = false;
            this.txtPass.Location = new System.Drawing.Point(155, 135);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(77, 207);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(100, 23);
            this.btnMake.TabIndex = 5;
            this.btnMake.Text = "Make Account";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(21, 141);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 113);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 86);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Phone Number";
            // 
            // txtPassConf
            // 
            this.txtPassConf.Location = new System.Drawing.Point(155, 161);
            this.txtPassConf.Name = "txtPassConf";
            this.txtPassConf.Size = new System.Drawing.Size(100, 20);
            this.txtPassConf.TabIndex = 4;
            this.txtPassConf.UseSystemPasswordChar = true;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(21, 165);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(91, 13);
            this.lblConfirm.TabIndex = 9;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // frmLogOnUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtPassConf);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Name = "frmLogOnUser";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPassConf;
        private System.Windows.Forms.Label lblConfirm;
    }
}