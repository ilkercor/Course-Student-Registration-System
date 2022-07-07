using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseStudentRegistration
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btn_st_registration_Click(object sender, EventArgs e)
        {
            st_registration_form obj = new st_registration_form();
            obj.Show();
        }

        private void btn_teach_registration_Click(object sender, EventArgs e)
        {
            teacher_registration_form obj = new teacher_registration_form();
            obj.Show();
        }

        private void btn_course_create_Click(object sender, EventArgs e)
        {
            course_creation_from obj = new course_creation_from();
            obj.Show();
        }

        private void btn_st_report_Click(object sender, EventArgs e)
        {
            student_report_form obj = new student_report_form();
            obj.Show();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_teacher_report_Click(object sender, EventArgs e)
        {
            teacher_report_form obj = new teacher_report_form();
            obj.Show();
        }

        private void btn_course_report_Click(object sender, EventArgs e)
        {
            course_report_form obj = new course_report_form();
            obj.Show();
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            add_student_to_course_form obj = new add_student_to_course_form();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accept_payment obj = new accept_payment();
            obj.Show();
        }

        private void btn_general_report_Click(object sender, EventArgs e)
        {
            general_report_form obj = new general_report_form();
            obj.Show();
        }

        private void btn_add_teacher_course_Click(object sender, EventArgs e)
        {
            add_teacher_to_course_form obj = new add_teacher_to_course_form();
            obj.Show();
        }


        private void darkModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.PowderBlue;
        }
    }
}
