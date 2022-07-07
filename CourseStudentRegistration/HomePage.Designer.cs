
namespace CourseStudentRegistration
{
    partial class HomePage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_st_registration = new System.Windows.Forms.Button();
            this.btn_teach_registration = new System.Windows.Forms.Button();
            this.btn_teacher_report = new System.Windows.Forms.Button();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_course_create = new System.Windows.Forms.Button();
            this.btn_course_report = new System.Windows.Forms.Button();
            this.btn_st_report = new System.Windows.Forms.Button();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_general_report = new System.Windows.Forms.Button();
            this.btn_add_teacher_course = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1273, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_st_registration
            // 
            this.btn_st_registration.Location = new System.Drawing.Point(47, 39);
            this.btn_st_registration.Name = "btn_st_registration";
            this.btn_st_registration.Size = new System.Drawing.Size(102, 48);
            this.btn_st_registration.TabIndex = 1;
            this.btn_st_registration.Text = "&Student Registration";
            this.btn_st_registration.UseVisualStyleBackColor = true;
            this.btn_st_registration.Click += new System.EventHandler(this.btn_st_registration_Click);
            // 
            // btn_teach_registration
            // 
            this.btn_teach_registration.Location = new System.Drawing.Point(247, 39);
            this.btn_teach_registration.Name = "btn_teach_registration";
            this.btn_teach_registration.Size = new System.Drawing.Size(102, 48);
            this.btn_teach_registration.TabIndex = 2;
            this.btn_teach_registration.Text = "&Teacher Registration";
            this.btn_teach_registration.UseVisualStyleBackColor = true;
            this.btn_teach_registration.Click += new System.EventHandler(this.btn_teach_registration_Click);
            // 
            // btn_teacher_report
            // 
            this.btn_teacher_report.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_teacher_report.Location = new System.Drawing.Point(110, 279);
            this.btn_teacher_report.Name = "btn_teacher_report";
            this.btn_teacher_report.Size = new System.Drawing.Size(102, 48);
            this.btn_teacher_report.TabIndex = 6;
            this.btn_teacher_report.Text = "Teache&r Report";
            this.btn_teacher_report.UseVisualStyleBackColor = false;
            this.btn_teacher_report.Click += new System.EventHandler(this.btn_teacher_report_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(1150, 39);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(102, 48);
            this.btn_log_out.TabIndex = 10;
            this.btn_log_out.Text = "E&xit";
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_course_create
            // 
            this.btn_course_create.Location = new System.Drawing.Point(447, 39);
            this.btn_course_create.Name = "btn_course_create";
            this.btn_course_create.Size = new System.Drawing.Size(102, 48);
            this.btn_course_create.TabIndex = 3;
            this.btn_course_create.Text = "&Course Creation";
            this.btn_course_create.UseVisualStyleBackColor = true;
            this.btn_course_create.Click += new System.EventHandler(this.btn_course_create_Click);
            // 
            // btn_course_report
            // 
            this.btn_course_report.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_course_report.Location = new System.Drawing.Point(110, 333);
            this.btn_course_report.Name = "btn_course_report";
            this.btn_course_report.Size = new System.Drawing.Size(102, 48);
            this.btn_course_report.TabIndex = 7;
            this.btn_course_report.Text = "Cours&e Report";
            this.btn_course_report.UseVisualStyleBackColor = false;
            this.btn_course_report.Click += new System.EventHandler(this.btn_course_report_Click);
            // 
            // btn_st_report
            // 
            this.btn_st_report.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_st_report.Location = new System.Drawing.Point(110, 225);
            this.btn_st_report.Name = "btn_st_report";
            this.btn_st_report.Size = new System.Drawing.Size(102, 48);
            this.btn_st_report.TabIndex = 5;
            this.btn_st_report.Text = "St&udent Report";
            this.btn_st_report.UseVisualStyleBackColor = false;
            this.btn_st_report.Click += new System.EventHandler(this.btn_st_report_Click);
            // 
            // btn_add_student
            // 
            this.btn_add_student.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_add_student.Location = new System.Drawing.Point(538, 225);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(102, 48);
            this.btn_add_student.TabIndex = 8;
            this.btn_add_student.Text = "A&dd Student to Course";
            this.btn_add_student.UseVisualStyleBackColor = false;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Location = new System.Drawing.Point(538, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 48);
            this.button1.TabIndex = 9;
            this.button1.Text = "Accept &Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, 447);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1273, 242);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btn_general_report
            // 
            this.btn_general_report.Location = new System.Drawing.Point(647, 39);
            this.btn_general_report.Name = "btn_general_report";
            this.btn_general_report.Size = new System.Drawing.Size(102, 48);
            this.btn_general_report.TabIndex = 4;
            this.btn_general_report.Text = "&General System Report";
            this.btn_general_report.UseVisualStyleBackColor = true;
            this.btn_general_report.Click += new System.EventHandler(this.btn_general_report_Click);
            // 
            // btn_add_teacher_course
            // 
            this.btn_add_teacher_course.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_add_teacher_course.Location = new System.Drawing.Point(538, 279);
            this.btn_add_teacher_course.Name = "btn_add_teacher_course";
            this.btn_add_teacher_course.Size = new System.Drawing.Size(102, 48);
            this.btn_add_teacher_course.TabIndex = 12;
            this.btn_add_teacher_course.Text = "Add Teacher t&o Course";
            this.btn_add_teacher_course.UseVisualStyleBackColor = false;
            this.btn_add_teacher_course.Click += new System.EventHandler(this.btn_add_teacher_course_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.lightModeToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1264, 24);
            this.Menu.TabIndex = 13;
            this.Menu.Text = "Menu";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // lightModeToolStripMenuItem
            // 
            this.lightModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.lightModeToolStripMenuItem.Name = "lightModeToolStripMenuItem";
            this.lightModeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.lightModeToolStripMenuItem.Text = "Light Mode";
            this.lightModeToolStripMenuItem.Click += new System.EventHandler(this.lightModeToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_add_teacher_course);
            this.Controls.Add(this.btn_general_report);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.btn_st_report);
            this.Controls.Add(this.btn_teacher_report);
            this.Controls.Add(this.btn_course_report);
            this.Controls.Add(this.btn_course_create);
            this.Controls.Add(this.btn_log_out);
            this.Controls.Add(this.btn_teach_registration);
            this.Controls.Add(this.btn_st_registration);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Student Registration System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_st_registration;
        private System.Windows.Forms.Button btn_teach_registration;
        private System.Windows.Forms.Button btn_teacher_report;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.Button btn_course_create;
        private System.Windows.Forms.Button btn_course_report;
        private System.Windows.Forms.Button btn_st_report;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_general_report;
        private System.Windows.Forms.Button btn_add_teacher_course;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeToolStripMenuItem;
    }
}

