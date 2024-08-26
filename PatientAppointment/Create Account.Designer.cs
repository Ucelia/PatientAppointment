namespace PatientAppointment
{
    partial class Form1
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(559, 443);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 20);
            this.linkLabel1.TabIndex = 41;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "I already have Account....";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.submitBtn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submitBtn.Location = new System.Drawing.Point(534, 380);
            this.submitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(244, 42);
            this.submitBtn.TabIndex = 39;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(32, 351);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(366, 37);
            this.passwordBox.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 316);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 29);
            this.label8.TabIndex = 36;
            this.label8.Text = "Password";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(32, 230);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(366, 37);
            this.emailBox.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Email";
            // 
            // fullnameBox
            // 
            this.fullnameBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameBox.Location = new System.Drawing.Point(32, 135);
            this.fullnameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullnameBox.Name = "fullnameBox";
            this.fullnameBox.Size = new System.Drawing.Size(366, 37);
            this.fullnameBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fullname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 60);
            this.panel1.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 536);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

