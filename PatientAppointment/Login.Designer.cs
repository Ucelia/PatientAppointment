namespace PatientAppointment
{
    partial class Login
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(350, 468);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(239, 20);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "You don\'t have account? Signup";
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.loginbutton.Location = new System.Drawing.Point(379, 355);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(155, 61);
            this.loginbutton.TabIndex = 23;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(24, 270);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '$';
            this.passwordtextBox.Size = new System.Drawing.Size(366, 37);
            this.passwordtextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "Passsword";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(24, 166);
            this.emailtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(366, 37);
            this.emailtextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(96, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 71);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(275, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 518);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}