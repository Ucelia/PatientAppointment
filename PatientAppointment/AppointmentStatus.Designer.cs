namespace PatientAppointment
{
    partial class AppointmentStatus
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.statusmessage = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(89, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 72);
            this.panel1.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(225, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "appointment Status";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(614, 384);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(144, 52);
            this.backbutton.TabIndex = 62;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // statusmessage
            // 
            this.statusmessage.AutoSize = true;
            this.statusmessage.ForeColor = System.Drawing.Color.Red;
            this.statusmessage.Location = new System.Drawing.Point(112, 384);
            this.statusmessage.Name = "statusmessage";
            this.statusmessage.Size = new System.Drawing.Size(0, 20);
            this.statusmessage.TabIndex = 61;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(396, 384);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(144, 52);
            this.searchbutton.TabIndex = 60;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "Status";
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBox.Location = new System.Drawing.Point(103, 338);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(260, 37);
            this.statusBox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 57;
            this.label4.Text = "Email";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(102, 199);
            this.emailtextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(366, 37);
            this.emailtextBox.TabIndex = 56;
            // 
            // AppointmentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.statusmessage);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.emailtextBox);
            this.Name = "AppointmentStatus";
            this.Text = "AppointmentStatus";
            this.Load += new System.EventHandler(this.AppointmentStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Label statusmessage;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtextBox;
    }
}