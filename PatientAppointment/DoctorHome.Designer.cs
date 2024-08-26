namespace PatientAppointment
{
    partial class DoctorHome
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.respondcomboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invalidpassword = new System.Windows.Forms.Label();
            this.RespondButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.doctortextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 60);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Appointment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(988, 175);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 10);
            this.button1.TabIndex = 69;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // respondcomboBox
            // 
            this.respondcomboBox.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respondcomboBox.FormattingEnabled = true;
            this.respondcomboBox.Items.AddRange(new object[] {
            "Approve",
            "Deny"});
            this.respondcomboBox.Location = new System.Drawing.Point(489, 231);
            this.respondcomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.respondcomboBox.Name = "respondcomboBox";
            this.respondcomboBox.Size = new System.Drawing.Size(216, 44);
            this.respondcomboBox.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 67;
            this.label3.Text = "Respond";
            // 
            // invalidpassword
            // 
            this.invalidpassword.AutoSize = true;
            this.invalidpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidpassword.ForeColor = System.Drawing.Color.Red;
            this.invalidpassword.Location = new System.Drawing.Point(251, 443);
            this.invalidpassword.Name = "invalidpassword";
            this.invalidpassword.Size = new System.Drawing.Size(0, 25);
            this.invalidpassword.TabIndex = 66;
            // 
            // RespondButton
            // 
            this.RespondButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RespondButton.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RespondButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RespondButton.Location = new System.Drawing.Point(728, 229);
            this.RespondButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RespondButton.Name = "RespondButton";
            this.RespondButton.Size = new System.Drawing.Size(154, 44);
            this.RespondButton.TabIndex = 65;
            this.RespondButton.Text = "RESPOND";
            this.RespondButton.UseVisualStyleBackColor = false;
            this.RespondButton.Click += new System.EventHandler(this.RespondButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 255);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Department";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(28, 197);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(366, 37);
            this.emailBox.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 29);
            this.label4.TabIndex = 61;
            this.label4.Text = "Email";
            // 
            // fullNameBox
            // 
            this.fullNameBox.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameBox.Location = new System.Drawing.Point(28, 126);
            this.fullNameBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(366, 37);
            this.fullNameBox.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 59;
            this.label2.Text = "FullNames";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(748, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 46);
            this.button2.TabIndex = 70;
            this.button2.Text = "exi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // doctortextBox1
            // 
            this.doctortextBox1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctortextBox1.Location = new System.Drawing.Point(27, 289);
            this.doctortextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.doctortextBox1.Name = "doctortextBox1";
            this.doctortextBox1.Size = new System.Drawing.Size(366, 37);
            this.doctortextBox1.TabIndex = 71;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(465, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 29);
            this.label5.TabIndex = 72;
            this.label5.Text = "date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(505, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(336, 26);
            this.dateTimePicker1.TabIndex = 73;
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 582);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.doctortextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.respondcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invalidpassword);
            this.Controls.Add(this.RespondButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "DoctorHome";
            this.Text = "DoctorHome";
            this.Load += new System.EventHandler(this.DoctorHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox respondcomboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label invalidpassword;
        private System.Windows.Forms.Button RespondButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox doctortextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}