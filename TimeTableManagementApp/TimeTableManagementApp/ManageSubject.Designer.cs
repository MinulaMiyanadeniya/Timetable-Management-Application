namespace TimeTableManagementApp
{
    partial class ManageSubject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtevalumins = new System.Windows.Forms.TextBox();
            this.txtevaluhours = new System.Windows.Forms.TextBox();
            this.txtlabmins = new System.Windows.Forms.TextBox();
            this.txtlabhours = new System.Windows.Forms.TextBox();
            this.txttutemins = new System.Windows.Forms.TextBox();
            this.txttutehours = new System.Windows.Forms.TextBox();
            this.txtlecmins = new System.Windows.Forms.TextBox();
            this.txtlechours = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsubcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsubject_name = new System.Windows.Forms.TextBox();
            this.rbtnsemester2 = new System.Windows.Forms.RadioButton();
            this.rbtnsemester1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.offeredyear = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(104, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE SUBJECT";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 366);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 150);
            this.dataGridView1.TabIndex = 94;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TimeTableManagementApp.Properties.Resources.aaaaa;
            this.pictureBox1.Location = new System.Drawing.Point(567, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(854, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 95;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(854, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 33);
            this.button2.TabIndex = 96;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Location = new System.Drawing.Point(854, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 33);
            this.button3.TabIndex = 97;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtevalumins
            // 
            this.txtevalumins.Location = new System.Drawing.Point(752, 325);
            this.txtevalumins.Multiline = true;
            this.txtevalumins.Name = "txtevalumins";
            this.txtevalumins.Size = new System.Drawing.Size(73, 20);
            this.txtevalumins.TabIndex = 155;
            // 
            // txtevaluhours
            // 
            this.txtevaluhours.Location = new System.Drawing.Point(602, 322);
            this.txtevaluhours.Multiline = true;
            this.txtevaluhours.Name = "txtevaluhours";
            this.txtevaluhours.Size = new System.Drawing.Size(73, 20);
            this.txtevaluhours.TabIndex = 154;
            // 
            // txtlabmins
            // 
            this.txtlabmins.Location = new System.Drawing.Point(752, 276);
            this.txtlabmins.Multiline = true;
            this.txtlabmins.Name = "txtlabmins";
            this.txtlabmins.Size = new System.Drawing.Size(73, 20);
            this.txtlabmins.TabIndex = 153;
            // 
            // txtlabhours
            // 
            this.txtlabhours.Location = new System.Drawing.Point(602, 277);
            this.txtlabhours.Multiline = true;
            this.txtlabhours.Name = "txtlabhours";
            this.txtlabhours.Size = new System.Drawing.Size(73, 20);
            this.txtlabhours.TabIndex = 152;
            // 
            // txttutemins
            // 
            this.txttutemins.Location = new System.Drawing.Point(752, 231);
            this.txttutemins.Multiline = true;
            this.txttutemins.Name = "txttutemins";
            this.txttutemins.Size = new System.Drawing.Size(73, 20);
            this.txttutemins.TabIndex = 151;
            // 
            // txttutehours
            // 
            this.txttutehours.Location = new System.Drawing.Point(602, 232);
            this.txttutehours.Multiline = true;
            this.txttutehours.Name = "txttutehours";
            this.txttutehours.Size = new System.Drawing.Size(73, 20);
            this.txttutehours.TabIndex = 150;
            // 
            // txtlecmins
            // 
            this.txtlecmins.Location = new System.Drawing.Point(752, 181);
            this.txtlecmins.Multiline = true;
            this.txtlecmins.Name = "txtlecmins";
            this.txtlecmins.Size = new System.Drawing.Size(73, 20);
            this.txtlecmins.TabIndex = 149;
            // 
            // txtlechours
            // 
            this.txtlechours.Location = new System.Drawing.Point(602, 180);
            this.txtlechours.Multiline = true;
            this.txtlechours.Name = "txtlechours";
            this.txtlechours.Size = new System.Drawing.Size(73, 20);
            this.txtlechours.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(27, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 131;
            this.label2.Text = "Offered Year:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(699, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 147;
            this.label13.Text = "Min:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(699, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 16);
            this.label12.TabIndex = 146;
            this.label12.Text = "Min:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(699, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 145;
            this.label11.Text = "Min:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(699, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 144;
            this.label10.Text = "Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(376, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 16);
            this.label9.TabIndex = 143;
            this.label9.Text = "Number of Evaluation Hours:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(376, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 16);
            this.label8.TabIndex = 142;
            this.label8.Text = "Number of Lab Hours:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(376, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 16);
            this.label7.TabIndex = 141;
            this.label7.Text = "Number of Tutorial Hours:";
            // 
            // txtsubcode
            // 
            this.txtsubcode.Location = new System.Drawing.Point(172, 325);
            this.txtsubcode.Multiline = true;
            this.txtsubcode.Name = "txtsubcode";
            this.txtsubcode.Size = new System.Drawing.Size(185, 20);
            this.txtsubcode.TabIndex = 140;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(378, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 16);
            this.label6.TabIndex = 139;
            this.label6.Text = "Number of Lecture Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(27, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 138;
            this.label5.Text = "Subject Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(27, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 137;
            this.label4.Text = "Subject Name :";
            // 
            // txtsubject_name
            // 
            this.txtsubject_name.Location = new System.Drawing.Point(172, 268);
            this.txtsubject_name.Multiline = true;
            this.txtsubject_name.Name = "txtsubject_name";
            this.txtsubject_name.Size = new System.Drawing.Size(185, 20);
            this.txtsubject_name.TabIndex = 136;
            // 
            // rbtnsemester2
            // 
            this.rbtnsemester2.AutoSize = true;
            this.rbtnsemester2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rbtnsemester2.Location = new System.Drawing.Point(279, 226);
            this.rbtnsemester2.Name = "rbtnsemester2";
            this.rbtnsemester2.Size = new System.Drawing.Size(78, 17);
            this.rbtnsemester2.TabIndex = 135;
            this.rbtnsemester2.TabStop = true;
            this.rbtnsemester2.Text = "Semester 2";
            this.rbtnsemester2.UseVisualStyleBackColor = true;
            // 
            // rbtnsemester1
            // 
            this.rbtnsemester1.AutoSize = true;
            this.rbtnsemester1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.rbtnsemester1.Location = new System.Drawing.Point(172, 225);
            this.rbtnsemester1.Name = "rbtnsemester1";
            this.rbtnsemester1.Size = new System.Drawing.Size(78, 17);
            this.rbtnsemester1.TabIndex = 134;
            this.rbtnsemester1.TabStop = true;
            this.rbtnsemester1.Text = "Semester 1";
            this.rbtnsemester1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(27, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 133;
            this.label3.Text = "Offered Semester :";
            // 
            // offeredyear
            // 
            this.offeredyear.FormattingEnabled = true;
            this.offeredyear.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021"});
            this.offeredyear.Location = new System.Drawing.Point(172, 172);
            this.offeredyear.Name = "offeredyear";
            this.offeredyear.Size = new System.Drawing.Size(185, 21);
            this.offeredyear.TabIndex = 132;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button4.Location = new System.Drawing.Point(854, 309);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 33);
            this.button4.TabIndex = 156;
            this.button4.Text = "REFREASH";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::TimeTableManagementApp.Properties.Resources.WhatsApp_Image_2021_04_05_at_3_27_00_PM;
            this.button5.Location = new System.Drawing.Point(21, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 67);
            this.button5.TabIndex = 157;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ManageSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 528);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtevalumins);
            this.Controls.Add(this.txtevaluhours);
            this.Controls.Add(this.txtlabmins);
            this.Controls.Add(this.txtlabhours);
            this.Controls.Add(this.txttutemins);
            this.Controls.Add(this.txttutehours);
            this.Controls.Add(this.txtlecmins);
            this.Controls.Add(this.txtlechours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsubcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsubject_name);
            this.Controls.Add(this.rbtnsemester2);
            this.Controls.Add(this.rbtnsemester1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.offeredyear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "ManageSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSubject";
            this.Load += new System.EventHandler(this.ManageSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtevalumins;
        private System.Windows.Forms.TextBox txtevaluhours;
        private System.Windows.Forms.TextBox txtlabmins;
        private System.Windows.Forms.TextBox txtlabhours;
        private System.Windows.Forms.TextBox txttutemins;
        private System.Windows.Forms.TextBox txttutehours;
        private System.Windows.Forms.TextBox txtlecmins;
        private System.Windows.Forms.TextBox txtlechours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsubcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsubject_name;
        private System.Windows.Forms.RadioButton rbtnsemester2;
        private System.Windows.Forms.RadioButton rbtnsemester1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox offeredyear;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}