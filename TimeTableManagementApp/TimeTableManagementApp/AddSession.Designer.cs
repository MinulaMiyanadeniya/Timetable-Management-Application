namespace TimeTableManagementApp
{
    partial class AddSession
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
            this.label2 = new System.Windows.Forms.Label();
            this.lec2 = new System.Windows.Forms.ComboBox();
            this.lec1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupid = new System.Windows.Forms.ComboBox();
            this.code = new System.Windows.Forms.ComboBox();
            this.students = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmins = new System.Windows.Forms.TextBox();
            this.txthours = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tag = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(235, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADD SESSION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(25, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 132;
            this.label2.Text = "Select Lecturer 1 :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lec2
            // 
            this.lec2.FormattingEnabled = true;
            this.lec2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.lec2.Location = new System.Drawing.Point(584, 162);
            this.lec2.Name = "lec2";
            this.lec2.Size = new System.Drawing.Size(212, 21);
            this.lec2.TabIndex = 137;
            // 
            // lec1
            // 
            this.lec1.FormattingEnabled = true;
            this.lec1.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.lec1.Location = new System.Drawing.Point(163, 162);
            this.lec1.Name = "lec1";
            this.lec1.Size = new System.Drawing.Size(212, 21);
            this.lec1.TabIndex = 136;
            this.lec1.SelectedIndexChanged += new System.EventHandler(this.faculty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(418, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 138;
            this.label3.Text = "Select Lecturer 2 :";
            // 
            // groupid
            // 
            this.groupid.FormattingEnabled = true;
            this.groupid.Items.AddRange(new object[] {
            "IT",
            "SE",
            "IM",
            "ISE",
            "ENG"});
            this.groupid.Location = new System.Drawing.Point(165, 266);
            this.groupid.Name = "groupid";
            this.groupid.Size = new System.Drawing.Size(212, 21);
            this.groupid.TabIndex = 144;
            // 
            // code
            // 
            this.code.FormattingEnabled = true;
            this.code.Items.AddRange(new object[] {
            "Computing",
            "Engineering",
            "Business",
            "Humanities & Sciences"});
            this.code.Location = new System.Drawing.Point(165, 211);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(212, 21);
            this.code.TabIndex = 143;
            // 
            // students
            // 
            this.students.Location = new System.Drawing.Point(165, 330);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(212, 20);
            this.students.TabIndex = 142;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(433, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 141;
            this.label8.Text = "Select Subject :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(505, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 140;
            this.label7.Text = "Tag :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(25, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 139;
            this.label6.Text = "Select Group :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(484, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 145;
            this.label4.Text = "Duration :";
            // 
            // txtmins
            // 
            this.txtmins.Location = new System.Drawing.Point(723, 326);
            this.txtmins.Multiline = true;
            this.txtmins.Name = "txtmins";
            this.txtmins.Size = new System.Drawing.Size(73, 20);
            this.txtmins.TabIndex = 158;
            // 
            // txthours
            // 
            this.txthours.Location = new System.Drawing.Point(584, 324);
            this.txthours.Multiline = true;
            this.txthours.Name = "txthours";
            this.txthours.Size = new System.Drawing.Size(73, 20);
            this.txthours.TabIndex = 157;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(670, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 156;
            this.label13.Text = "Min:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.Location = new System.Drawing.Point(656, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 41);
            this.button3.TabIndex = 160;
            this.button3.Text = "SUBMIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Location = new System.Drawing.Point(497, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 41);
            this.button2.TabIndex = 159;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(25, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 161;
            this.label5.Text = "Select Code :";
            // 
            // tag
            // 
            this.tag.FormattingEnabled = true;
            this.tag.Items.AddRange(new object[] {
            "IT",
            "SE",
            "IM",
            "ISE",
            "ENG"});
            this.tag.Location = new System.Drawing.Point(584, 266);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(212, 21);
            this.tag.TabIndex = 162;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(25, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 16);
            this.label9.TabIndex = 163;
            this.label9.Text = "No of Students :";
            // 
            // subject
            // 
            this.subject.FormattingEnabled = true;
            this.subject.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.subject.Location = new System.Drawing.Point(584, 210);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(212, 21);
            this.subject.TabIndex = 164;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(340, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 165;
            this.button1.Text = "GENERATE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(165, 373);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(631, 20);
            this.generate.TabIndex = 166;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(25, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 16);
            this.label10.TabIndex = 167;
            this.label10.Text = "Selected Lecturer:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // AddSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 522);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmins);
            this.Controls.Add(this.txthours);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupid);
            this.Controls.Add(this.code);
            this.Controls.Add(this.students);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lec2);
            this.Controls.Add(this.lec1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSession";
            this.Text = "AddSession";
            this.Load += new System.EventHandler(this.AddSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lec2;
        private System.Windows.Forms.ComboBox lec1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox groupid;
        private System.Windows.Forms.ComboBox code;
        private System.Windows.Forms.TextBox students;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmins;
        private System.Windows.Forms.TextBox txthours;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tag;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox subject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox generate;
        private System.Windows.Forms.Label label10;
    }
}