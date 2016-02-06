namespace testapp
{
    partial class frmMainMenu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnAct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::testapp.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(36, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Featured";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(117, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Profile";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Location = new System.Drawing.Point(198, 93);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(47, 13);
            this.lblPoints.TabIndex = 4;
            this.lblPoints.Text = "Points: x";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search";
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(93, 143);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(75, 23);
            this.btnRest.TabIndex = 7;
            this.btnRest.Text = "Restaurants";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(93, 186);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(75, 23);
            this.btnHotel.TabIndex = 8;
            this.btnHotel.Text = "Hotels";
            this.btnHotel.UseVisualStyleBackColor = true;
            // 
            // btnAct
            // 
            this.btnAct.Location = new System.Drawing.Point(93, 226);
            this.btnAct.Name = "btnAct";
            this.btnAct.Size = new System.Drawing.Size(75, 23);
            this.btnAct.TabIndex = 9;
            this.btnAct.Text = "Activities";
            this.btnAct.UseVisualStyleBackColor = true;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAct);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMainMenu";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnAct;
    }
}