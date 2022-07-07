
namespace CourseStudentRegistration
{
    partial class add_student_to_course_form
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
            this.btn_add_student = new System.Windows.Forms.Button();
            this.lb_choose_course = new System.Windows.Forms.Label();
            this.lb_search_st = new System.Windows.Forms.Label();
            this.date_regdate = new System.Windows.Forms.DateTimePicker();
            this.lb_rg_date = new System.Windows.Forms.Label();
            this.grid_courses = new System.Windows.Forms.DataGridView();
            this.grid_students = new System.Windows.Forms.DataGridView();
            this.txt_search_course = new System.Windows.Forms.TextBox();
            this.txt_search_st = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_coursefee = new System.Windows.Forms.Label();
            this.lbl_coursecode = new System.Windows.Forms.Label();
            this.lbl_coursename = new System.Windows.Forms.Label();
            this.lbl_courseid = new System.Windows.Forms.Label();
            this.lbl_stphone = new System.Windows.Forms.Label();
            this.lbl_stlast = new System.Windows.Forms.Label();
            this.lbl_stname = new System.Windows.Forms.Label();
            this.lbl_stid = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_student
            // 
            this.btn_add_student.BackColor = System.Drawing.Color.Lime;
            this.btn_add_student.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add_student.Location = new System.Drawing.Point(558, 627);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(150, 50);
            this.btn_add_student.TabIndex = 4;
            this.btn_add_student.Text = "&Add";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // lb_choose_course
            // 
            this.lb_choose_course.AutoSize = true;
            this.lb_choose_course.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_choose_course.Location = new System.Drawing.Point(116, 43);
            this.lb_choose_course.Name = "lb_choose_course";
            this.lb_choose_course.Size = new System.Drawing.Size(176, 25);
            this.lb_choose_course.TabIndex = 30;
            this.lb_choose_course.Text = "Search Course:";
            // 
            // lb_search_st
            // 
            this.lb_search_st.AutoSize = true;
            this.lb_search_st.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_search_st.Location = new System.Drawing.Point(757, 38);
            this.lb_search_st.Name = "lb_search_st";
            this.lb_search_st.Size = new System.Drawing.Size(184, 25);
            this.lb_search_st.TabIndex = 33;
            this.lb_search_st.Text = "Search Student:";
            // 
            // date_regdate
            // 
            this.date_regdate.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date_regdate.Location = new System.Drawing.Point(649, 588);
            this.date_regdate.Name = "date_regdate";
            this.date_regdate.Size = new System.Drawing.Size(200, 33);
            this.date_regdate.TabIndex = 3;
            // 
            // lb_rg_date
            // 
            this.lb_rg_date.AutoSize = true;
            this.lb_rg_date.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_rg_date.Location = new System.Drawing.Point(437, 594);
            this.lb_rg_date.Name = "lb_rg_date";
            this.lb_rg_date.Size = new System.Drawing.Size(206, 25);
            this.lb_rg_date.TabIndex = 38;
            this.lb_rg_date.Text = "Registration Date:";
            // 
            // grid_courses
            // 
            this.grid_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_courses.Location = new System.Drawing.Point(12, 93);
            this.grid_courses.Name = "grid_courses";
            this.grid_courses.Size = new System.Drawing.Size(600, 300);
            this.grid_courses.TabIndex = 39;
            this.grid_courses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_courses_CellClick);
            // 
            // grid_students
            // 
            this.grid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_students.Location = new System.Drawing.Point(649, 93);
            this.grid_students.Name = "grid_students";
            this.grid_students.Size = new System.Drawing.Size(600, 300);
            this.grid_students.TabIndex = 40;
            this.grid_students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_students_CellClick);
            // 
            // txt_search_course
            // 
            this.txt_search_course.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search_course.Location = new System.Drawing.Point(303, 40);
            this.txt_search_course.Name = "txt_search_course";
            this.txt_search_course.Size = new System.Drawing.Size(178, 33);
            this.txt_search_course.TabIndex = 1;
            this.txt_search_course.TextChanged += new System.EventHandler(this.txt_search_course_TextChanged);
            // 
            // txt_search_st
            // 
            this.txt_search_st.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search_st.Location = new System.Drawing.Point(947, 35);
            this.txt_search_st.Name = "txt_search_st";
            this.txt_search_st.Size = new System.Drawing.Size(178, 33);
            this.txt_search_st.TabIndex = 2;
            this.txt_search_st.TextChanged += new System.EventHandler(this.txt_search_st_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 100;
            this.label2.Text = "Course ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 101;
            this.label3.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 102;
            this.label4.Text = "Course Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(9, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 103;
            this.label5.Text = "Course Fee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(646, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 18);
            this.label6.TabIndex = 107;
            this.label6.Text = "Student Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(646, 475);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 106;
            this.label7.Text = "Student Lastname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(646, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 105;
            this.label8.Text = "Student Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(646, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 18);
            this.label9.TabIndex = 104;
            this.label9.Text = "Student ID:";
            // 
            // lbl_coursefee
            // 
            this.lbl_coursefee.AutoSize = true;
            this.lbl_coursefee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_coursefee.Location = new System.Drawing.Point(148, 505);
            this.lbl_coursefee.Name = "lbl_coursefee";
            this.lbl_coursefee.Size = new System.Drawing.Size(50, 18);
            this.lbl_coursefee.TabIndex = 111;
            this.lbl_coursefee.Text = "NULL";
            // 
            // lbl_coursecode
            // 
            this.lbl_coursecode.AutoSize = true;
            this.lbl_coursecode.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_coursecode.Location = new System.Drawing.Point(148, 475);
            this.lbl_coursecode.Name = "lbl_coursecode";
            this.lbl_coursecode.Size = new System.Drawing.Size(50, 18);
            this.lbl_coursecode.TabIndex = 110;
            this.lbl_coursecode.Text = "NULL";
            // 
            // lbl_coursename
            // 
            this.lbl_coursename.AutoSize = true;
            this.lbl_coursename.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_coursename.Location = new System.Drawing.Point(148, 445);
            this.lbl_coursename.Name = "lbl_coursename";
            this.lbl_coursename.Size = new System.Drawing.Size(50, 18);
            this.lbl_coursename.TabIndex = 109;
            this.lbl_coursename.Text = "NULL";
            // 
            // lbl_courseid
            // 
            this.lbl_courseid.AutoSize = true;
            this.lbl_courseid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_courseid.Location = new System.Drawing.Point(148, 415);
            this.lbl_courseid.Name = "lbl_courseid";
            this.lbl_courseid.Size = new System.Drawing.Size(50, 18);
            this.lbl_courseid.TabIndex = 108;
            this.lbl_courseid.Text = "NULL";
            // 
            // lbl_stphone
            // 
            this.lbl_stphone.AutoSize = true;
            this.lbl_stphone.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stphone.Location = new System.Drawing.Point(817, 505);
            this.lbl_stphone.Name = "lbl_stphone";
            this.lbl_stphone.Size = new System.Drawing.Size(50, 18);
            this.lbl_stphone.TabIndex = 115;
            this.lbl_stphone.Text = "NULL";
            // 
            // lbl_stlast
            // 
            this.lbl_stlast.AutoSize = true;
            this.lbl_stlast.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stlast.Location = new System.Drawing.Point(817, 475);
            this.lbl_stlast.Name = "lbl_stlast";
            this.lbl_stlast.Size = new System.Drawing.Size(50, 18);
            this.lbl_stlast.TabIndex = 114;
            this.lbl_stlast.Text = "NULL";
            // 
            // lbl_stname
            // 
            this.lbl_stname.AutoSize = true;
            this.lbl_stname.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stname.Location = new System.Drawing.Point(817, 445);
            this.lbl_stname.Name = "lbl_stname";
            this.lbl_stname.Size = new System.Drawing.Size(50, 18);
            this.lbl_stname.TabIndex = 113;
            this.lbl_stname.Text = "NULL";
            // 
            // lbl_stid
            // 
            this.lbl_stid.AutoSize = true;
            this.lbl_stid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stid.Location = new System.Drawing.Point(817, 415);
            this.lbl_stid.Name = "lbl_stid";
            this.lbl_stid.Size = new System.Drawing.Size(50, 18);
            this.lbl_stid.TabIndex = 112;
            this.lbl_stid.Text = "NULL";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(558, 25);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(150, 50);
            this.btn_clear.TabIndex = 116;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // add_student_to_course_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_stphone);
            this.Controls.Add(this.lbl_stlast);
            this.Controls.Add(this.lbl_stname);
            this.Controls.Add(this.lbl_stid);
            this.Controls.Add(this.lbl_coursefee);
            this.Controls.Add(this.lbl_coursecode);
            this.Controls.Add(this.lbl_coursename);
            this.Controls.Add(this.lbl_courseid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_search_st);
            this.Controls.Add(this.txt_search_course);
            this.Controls.Add(this.grid_students);
            this.Controls.Add(this.grid_courses);
            this.Controls.Add(this.lb_rg_date);
            this.Controls.Add(this.date_regdate);
            this.Controls.Add(this.lb_search_st);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.lb_choose_course);
            this.Name = "add_student_to_course_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student To Course";
            this.Load += new System.EventHandler(this.add_student_to_course_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Label lb_choose_course;
        private System.Windows.Forms.Label lb_search_st;
        private System.Windows.Forms.DateTimePicker date_regdate;
        private System.Windows.Forms.Label lb_rg_date;
        private System.Windows.Forms.DataGridView grid_courses;
        private System.Windows.Forms.DataGridView grid_students;
        private System.Windows.Forms.TextBox txt_search_course;
        private System.Windows.Forms.TextBox txt_search_st;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_coursefee;
        private System.Windows.Forms.Label lbl_coursecode;
        private System.Windows.Forms.Label lbl_coursename;
        private System.Windows.Forms.Label lbl_courseid;
        private System.Windows.Forms.Label lbl_stphone;
        private System.Windows.Forms.Label lbl_stlast;
        private System.Windows.Forms.Label lbl_stname;
        private System.Windows.Forms.Label lbl_stid;
        private System.Windows.Forms.Button btn_clear;
    }
}