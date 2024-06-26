﻿namespace LMS_Lab7_68
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.teachercombobox = new System.Windows.Forms.ComboBox();
            this.semestercombobox = new System.Windows.Forms.ComboBox();
            this.coursecodetextbox = new System.Windows.Forms.TextBox();
            this.teachertypecombobox = new System.Windows.Forms.ComboBox();
            this.coursetypecombobox = new System.Windows.Forms.ComboBox();
            this.studentsemestertextbox = new System.Windows.Forms.ComboBox();
            this.studentcoursetextbox = new System.Windows.Forms.ComboBox();
            this.showteacherinfocombobox = new System.Windows.Forms.ComboBox();
            this.showstudentinfocombobox = new System.Windows.Forms.ComboBox();
            this.showTeacherInfoListbox = new System.Windows.Forms.ListBox();
            this.showStudentyInfoListbox = new System.Windows.Forms.ListBox();
            this.coursetitletextbox = new System.Windows.Forms.TextBox();
            this.studentnametextbox = new System.Windows.Forms.TextBox();
            this.teachernametextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1061, 476);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 24);
            this.button5.TabIndex = 69;
            this.button5.Text = "Show Teacher Info";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 24);
            this.button4.TabIndex = 68;
            this.button4.Text = "Show Student Info";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(599, 259);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 37);
            this.button3.TabIndex = 67;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(999, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 66;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 65;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // teachercombobox
            // 
            this.teachercombobox.FormattingEnabled = true;
            this.teachercombobox.Location = new System.Drawing.Point(547, 229);
            this.teachercombobox.Name = "teachercombobox";
            this.teachercombobox.Size = new System.Drawing.Size(214, 24);
            this.teachercombobox.TabIndex = 64;
            // 
            // semestercombobox
            // 
            this.semestercombobox.FormattingEnabled = true;
            this.semestercombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.semestercombobox.Location = new System.Drawing.Point(547, 194);
            this.semestercombobox.Name = "semestercombobox";
            this.semestercombobox.Size = new System.Drawing.Size(214, 24);
            this.semestercombobox.TabIndex = 63;
            // 
            // coursecodetextbox
            // 
            this.coursecodetextbox.Location = new System.Drawing.Point(547, 104);
            this.coursecodetextbox.Name = "coursecodetextbox";
            this.coursecodetextbox.Size = new System.Drawing.Size(214, 22);
            this.coursecodetextbox.TabIndex = 62;
            // 
            // teachertypecombobox
            // 
            this.teachertypecombobox.FormattingEnabled = true;
            this.teachertypecombobox.Items.AddRange(new object[] {
            "Professor",
            "Lecturer"});
            this.teachertypecombobox.Location = new System.Drawing.Point(185, 138);
            this.teachertypecombobox.Name = "teachertypecombobox";
            this.teachertypecombobox.Size = new System.Drawing.Size(214, 24);
            this.teachertypecombobox.TabIndex = 61;
            // 
            // coursetypecombobox
            // 
            this.coursetypecombobox.FormattingEnabled = true;
            this.coursetypecombobox.Items.AddRange(new object[] {
            "Lab",
            "Theory"});
            this.coursetypecombobox.Location = new System.Drawing.Point(547, 138);
            this.coursetypecombobox.Name = "coursetypecombobox";
            this.coursetypecombobox.Size = new System.Drawing.Size(214, 24);
            this.coursetypecombobox.TabIndex = 60;
            this.coursetypecombobox.SelectedIndexChanged += new System.EventHandler(this.coursetypecombobox_SelectedIndexChanged);
            // 
            // studentsemestertextbox
            // 
            this.studentsemestertextbox.FormattingEnabled = true;
            this.studentsemestertextbox.Location = new System.Drawing.Point(910, 137);
            this.studentsemestertextbox.Name = "studentsemestertextbox";
            this.studentsemestertextbox.Size = new System.Drawing.Size(214, 24);
            this.studentsemestertextbox.TabIndex = 59;
            // 
            // studentcoursetextbox
            // 
            this.studentcoursetextbox.FormattingEnabled = true;
            this.studentcoursetextbox.Location = new System.Drawing.Point(910, 167);
            this.studentcoursetextbox.Name = "studentcoursetextbox";
            this.studentcoursetextbox.Size = new System.Drawing.Size(214, 24);
            this.studentcoursetextbox.TabIndex = 58;
            // 
            // showteacherinfocombobox
            // 
            this.showteacherinfocombobox.FormattingEnabled = true;
            this.showteacherinfocombobox.Location = new System.Drawing.Point(856, 476);
            this.showteacherinfocombobox.Name = "showteacherinfocombobox";
            this.showteacherinfocombobox.Size = new System.Drawing.Size(175, 24);
            this.showteacherinfocombobox.TabIndex = 57;
            // 
            // showstudentinfocombobox
            // 
            this.showstudentinfocombobox.FormattingEnabled = true;
            this.showstudentinfocombobox.Location = new System.Drawing.Point(124, 486);
            this.showstudentinfocombobox.Name = "showstudentinfocombobox";
            this.showstudentinfocombobox.Size = new System.Drawing.Size(175, 24);
            this.showstudentinfocombobox.TabIndex = 56;
            // 
            // showTeacherInfoListbox
            // 
            this.showTeacherInfoListbox.FormattingEnabled = true;
            this.showTeacherInfoListbox.ItemHeight = 16;
            this.showTeacherInfoListbox.Location = new System.Drawing.Point(717, 294);
            this.showTeacherInfoListbox.Name = "showTeacherInfoListbox";
            this.showTeacherInfoListbox.Size = new System.Drawing.Size(394, 164);
            this.showTeacherInfoListbox.TabIndex = 55;
            // 
            // showStudentyInfoListbox
            // 
            this.showStudentyInfoListbox.FormattingEnabled = true;
            this.showStudentyInfoListbox.ItemHeight = 16;
            this.showStudentyInfoListbox.Location = new System.Drawing.Point(112, 294);
            this.showStudentyInfoListbox.Name = "showStudentyInfoListbox";
            this.showStudentyInfoListbox.Size = new System.Drawing.Size(394, 164);
            this.showStudentyInfoListbox.TabIndex = 54;
            // 
            // coursetitletextbox
            // 
            this.coursetitletextbox.Location = new System.Drawing.Point(547, 166);
            this.coursetitletextbox.Name = "coursetitletextbox";
            this.coursetitletextbox.Size = new System.Drawing.Size(214, 22);
            this.coursetitletextbox.TabIndex = 53;
            // 
            // studentnametextbox
            // 
            this.studentnametextbox.Location = new System.Drawing.Point(910, 104);
            this.studentnametextbox.Name = "studentnametextbox";
            this.studentnametextbox.Size = new System.Drawing.Size(214, 22);
            this.studentnametextbox.TabIndex = 52;
            // 
            // teachernametextbox
            // 
            this.teachernametextbox.Location = new System.Drawing.Point(185, 110);
            this.teachernametextbox.Name = "teachernametextbox";
            this.teachernametextbox.Size = new System.Drawing.Size(214, 22);
            this.teachernametextbox.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(853, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 50;
            this.label13.Text = "Course";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(109, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(455, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Course Code";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(887, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "Student Info";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(86, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 46;
            this.label9.Text = "Teacher Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Course Info";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Course Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Course Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Teacher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(860, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(839, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Teacher Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 564);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teachercombobox);
            this.Controls.Add(this.semestercombobox);
            this.Controls.Add(this.coursecodetextbox);
            this.Controls.Add(this.teachertypecombobox);
            this.Controls.Add(this.coursetypecombobox);
            this.Controls.Add(this.studentsemestertextbox);
            this.Controls.Add(this.studentcoursetextbox);
            this.Controls.Add(this.showteacherinfocombobox);
            this.Controls.Add(this.showstudentinfocombobox);
            this.Controls.Add(this.showTeacherInfoListbox);
            this.Controls.Add(this.showStudentyInfoListbox);
            this.Controls.Add(this.coursetitletextbox);
            this.Controls.Add(this.studentnametextbox);
            this.Controls.Add(this.teachernametextbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox teachercombobox;
        private System.Windows.Forms.ComboBox semestercombobox;
        private System.Windows.Forms.TextBox coursecodetextbox;
        private System.Windows.Forms.ComboBox teachertypecombobox;
        private System.Windows.Forms.ComboBox coursetypecombobox;
        private System.Windows.Forms.ComboBox studentsemestertextbox;
        private System.Windows.Forms.ComboBox studentcoursetextbox;
        private System.Windows.Forms.ComboBox showteacherinfocombobox;
        private System.Windows.Forms.ComboBox showstudentinfocombobox;
        private System.Windows.Forms.ListBox showTeacherInfoListbox;
        private System.Windows.Forms.ListBox showStudentyInfoListbox;
        private System.Windows.Forms.TextBox coursetitletextbox;
        private System.Windows.Forms.TextBox studentnametextbox;
        private System.Windows.Forms.TextBox teachernametextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

