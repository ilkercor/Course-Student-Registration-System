
namespace CourseStudentRegistration
{
    partial class general_report_form
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
            this.lb_active_courses = new System.Windows.Forms.Label();
            this.lb_total_student = new System.Windows.Forms.Label();
            this.lb_data_totalst = new System.Windows.Forms.Label();
            this.lb_total_instructor = new System.Windows.Forms.Label();
            this.lb_data_total_instructor = new System.Windows.Forms.Label();
            this.lb_expired_courses = new System.Windows.Forms.Label();
            this.grid_active_courses = new System.Windows.Forms.DataGridView();
            this.grid_expired_courses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_active_courses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_expired_courses)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_active_courses
            // 
            this.lb_active_courses.AutoSize = true;
            this.lb_active_courses.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_active_courses.Location = new System.Drawing.Point(104, 124);
            this.lb_active_courses.Name = "lb_active_courses";
            this.lb_active_courses.Size = new System.Drawing.Size(168, 25);
            this.lb_active_courses.TabIndex = 1;
            this.lb_active_courses.Text = "Active Courses";
            // 
            // lb_total_student
            // 
            this.lb_total_student.AutoSize = true;
            this.lb_total_student.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_total_student.Location = new System.Drawing.Point(525, 205);
            this.lb_total_student.Name = "lb_total_student";
            this.lb_total_student.Size = new System.Drawing.Size(214, 50);
            this.lb_total_student.TabIndex = 2;
            this.lb_total_student.Text = "Total Number of\r\nRegistered Student\r\n";
            this.lb_total_student.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_data_totalst
            // 
            this.lb_data_totalst.AutoSize = true;
            this.lb_data_totalst.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_totalst.Location = new System.Drawing.Point(594, 276);
            this.lb_data_totalst.Name = "lb_data_totalst";
            this.lb_data_totalst.Size = new System.Drawing.Size(67, 25);
            this.lb_data_totalst.TabIndex = 3;
            this.lb_data_totalst.Text = "NULL";
            // 
            // lb_total_instructor
            // 
            this.lb_total_instructor.AutoSize = true;
            this.lb_total_instructor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_total_instructor.Location = new System.Drawing.Point(516, 395);
            this.lb_total_instructor.Name = "lb_total_instructor";
            this.lb_total_instructor.Size = new System.Drawing.Size(246, 50);
            this.lb_total_instructor.TabIndex = 4;
            this.lb_total_instructor.Text = "Total Number of\r\nRegistered Instructors";
            this.lb_total_instructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_data_total_instructor
            // 
            this.lb_data_total_instructor.AutoSize = true;
            this.lb_data_total_instructor.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_total_instructor.Location = new System.Drawing.Point(594, 468);
            this.lb_data_total_instructor.Name = "lb_data_total_instructor";
            this.lb_data_total_instructor.Size = new System.Drawing.Size(67, 25);
            this.lb_data_total_instructor.TabIndex = 5;
            this.lb_data_total_instructor.Text = "NULL";
            // 
            // lb_expired_courses
            // 
            this.lb_expired_courses.AutoSize = true;
            this.lb_expired_courses.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_expired_courses.Location = new System.Drawing.Point(965, 124);
            this.lb_expired_courses.Name = "lb_expired_courses";
            this.lb_expired_courses.Size = new System.Drawing.Size(183, 25);
            this.lb_expired_courses.TabIndex = 7;
            this.lb_expired_courses.Text = "Expired Courses";
            // 
            // grid_active_courses
            // 
            this.grid_active_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_active_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_active_courses.Location = new System.Drawing.Point(12, 165);
            this.grid_active_courses.Name = "grid_active_courses";
            this.grid_active_courses.Size = new System.Drawing.Size(479, 386);
            this.grid_active_courses.TabIndex = 48;
            // 
            // grid_expired_courses
            // 
            this.grid_expired_courses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_expired_courses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_expired_courses.Location = new System.Drawing.Point(798, 165);
            this.grid_expired_courses.Name = "grid_expired_courses";
            this.grid_expired_courses.Size = new System.Drawing.Size(454, 386);
            this.grid_expired_courses.TabIndex = 49;
            // 
            // general_report_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.grid_expired_courses);
            this.Controls.Add(this.grid_active_courses);
            this.Controls.Add(this.lb_expired_courses);
            this.Controls.Add(this.lb_data_total_instructor);
            this.Controls.Add(this.lb_total_instructor);
            this.Controls.Add(this.lb_data_totalst);
            this.Controls.Add(this.lb_total_student);
            this.Controls.Add(this.lb_active_courses);
            this.Name = "general_report_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Report";
            this.Load += new System.EventHandler(this.general_report_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_active_courses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_expired_courses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_active_courses;
        private System.Windows.Forms.Label lb_total_student;
        private System.Windows.Forms.Label lb_data_totalst;
        private System.Windows.Forms.Label lb_total_instructor;
        private System.Windows.Forms.Label lb_data_total_instructor;
        private System.Windows.Forms.Label lb_expired_courses;
        private System.Windows.Forms.DataGridView grid_active_courses;
        private System.Windows.Forms.DataGridView grid_expired_courses;
    }
}