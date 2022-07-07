
namespace CourseStudentRegistration
{
    partial class teacher_report_form
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_teachers = new System.Windows.Forms.DataGridView();
            this.lb_given_course = new System.Windows.Forms.Label();
            this.lb_data_gender = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.lb_data_phone = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_data_email = new System.Windows.Forms.Label();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_data_lname = new System.Windows.Forms.Label();
            this.lb_lname = new System.Windows.Forms.Label();
            this.lb_data_fname = new System.Windows.Forms.Label();
            this.lb_fname = new System.Windows.Forms.Label();
            this.lb_data_ID = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.grid_data_courses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_teachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(261, 31);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(403, 33);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 123;
            this.label1.Text = "Search by Name:";
            // 
            // grid_teachers
            // 
            this.grid_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_teachers.Location = new System.Drawing.Point(64, 82);
            this.grid_teachers.Name = "grid_teachers";
            this.grid_teachers.Size = new System.Drawing.Size(600, 550);
            this.grid_teachers.TabIndex = 124;
            this.grid_teachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_teachers_CellClick);
            // 
            // lb_given_course
            // 
            this.lb_given_course.AutoSize = true;
            this.lb_given_course.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_given_course.Location = new System.Drawing.Point(685, 370);
            this.lb_given_course.Name = "lb_given_course";
            this.lb_given_course.Size = new System.Drawing.Size(174, 25);
            this.lb_given_course.TabIndex = 121;
            this.lb_given_course.Text = "Given Courses:";
            // 
            // lb_data_gender
            // 
            this.lb_data_gender.AutoSize = true;
            this.lb_data_gender.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_gender.Location = new System.Drawing.Point(1042, 320);
            this.lb_data_gender.Name = "lb_data_gender";
            this.lb_data_gender.Size = new System.Drawing.Size(53, 25);
            this.lb_data_gender.TabIndex = 120;
            this.lb_data_gender.Text = "Null";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_gender.Location = new System.Drawing.Point(850, 320);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(189, 25);
            this.lb_gender.TabIndex = 119;
            this.lb_gender.Text = "Teacher Gender:";
            // 
            // lb_data_phone
            // 
            this.lb_data_phone.AutoSize = true;
            this.lb_data_phone.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_phone.Location = new System.Drawing.Point(1042, 270);
            this.lb_data_phone.Name = "lb_data_phone";
            this.lb_data_phone.Size = new System.Drawing.Size(53, 25);
            this.lb_data_phone.TabIndex = 118;
            this.lb_data_phone.Text = "Null";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_phone.Location = new System.Drawing.Point(826, 270);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(213, 25);
            this.lb_phone.TabIndex = 117;
            this.lb_phone.Text = "Teacher Phone No:";
            // 
            // lb_data_email
            // 
            this.lb_data_email.AutoSize = true;
            this.lb_data_email.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_email.Location = new System.Drawing.Point(1042, 220);
            this.lb_data_email.Name = "lb_data_email";
            this.lb_data_email.Size = new System.Drawing.Size(53, 25);
            this.lb_data_email.TabIndex = 116;
            this.lb_data_email.Text = "Null";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_email.Location = new System.Drawing.Point(861, 220);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(178, 25);
            this.lb_email.TabIndex = 115;
            this.lb_email.Text = "Teacher E-Mail:";
            // 
            // lb_data_lname
            // 
            this.lb_data_lname.AutoSize = true;
            this.lb_data_lname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_lname.Location = new System.Drawing.Point(1042, 170);
            this.lb_data_lname.Name = "lb_data_lname";
            this.lb_data_lname.Size = new System.Drawing.Size(53, 25);
            this.lb_data_lname.TabIndex = 114;
            this.lb_data_lname.Text = "Null";
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_lname.Location = new System.Drawing.Point(814, 170);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(225, 25);
            this.lb_lname.TabIndex = 113;
            this.lb_lname.Text = "Teacher Last Name:";
            // 
            // lb_data_fname
            // 
            this.lb_data_fname.AutoSize = true;
            this.lb_data_fname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_fname.Location = new System.Drawing.Point(1042, 120);
            this.lb_data_fname.Name = "lb_data_fname";
            this.lb_data_fname.Size = new System.Drawing.Size(53, 25);
            this.lb_data_fname.TabIndex = 112;
            this.lb_data_fname.Text = "Null";
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_fname.Location = new System.Drawing.Point(812, 120);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(227, 25);
            this.lb_fname.TabIndex = 109;
            this.lb_fname.Text = "Teacher First Name:";
            // 
            // lb_data_ID
            // 
            this.lb_data_ID.AutoSize = true;
            this.lb_data_ID.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_ID.Location = new System.Drawing.Point(1040, 82);
            this.lb_data_ID.Name = "lb_data_ID";
            this.lb_data_ID.Size = new System.Drawing.Size(53, 25);
            this.lb_data_ID.TabIndex = 127;
            this.lb_data_ID.Text = "Null";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(901, 82);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(136, 25);
            this.lblid.TabIndex = 126;
            this.lblid.Text = "Teacher ID:";
            // 
            // grid_data_courses
            // 
            this.grid_data_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grid_data_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_data_courses.Location = new System.Drawing.Point(855, 367);
            this.grid_data_courses.Name = "grid_data_courses";
            this.grid_data_courses.Size = new System.Drawing.Size(385, 128);
            this.grid_data_courses.TabIndex = 128;
            // 
            // teacher_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grid_data_courses);
            this.Controls.Add(this.lb_data_ID);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_teachers);
            this.Controls.Add(this.lb_given_course);
            this.Controls.Add(this.lb_data_gender);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.lb_data_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_data_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_data_lname);
            this.Controls.Add(this.lb_lname);
            this.Controls.Add(this.lb_data_fname);
            this.Controls.Add(this.lb_fname);
            this.Name = "teacher_report_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Report";
            this.Load += new System.EventHandler(this.teacher_report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_teachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_data_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_teachers;
        private System.Windows.Forms.Label lb_given_course;
        private System.Windows.Forms.Label lb_data_gender;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.Label lb_data_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_data_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_data_lname;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.Label lb_data_fname;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.Label lb_data_ID;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.DataGridView grid_data_courses;
    }
}