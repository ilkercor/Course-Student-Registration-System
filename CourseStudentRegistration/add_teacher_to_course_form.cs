using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CourseStudentRegistration
{
    public partial class add_teacher_to_course_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public add_teacher_to_course_form()
        {
            InitializeComponent();
        }

        public void showTeachers()
        {
            var select = "SELECT * FROM [Teachers]";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_teachers.DataSource = dtrecord;
        }
        public void showCourses()
        {
            var select = "SELECT * FROM [Courses]";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_courses.DataSource = dtrecord;
        }


        private void add_teacher_to_course_form_Load(object sender, EventArgs e)
        {
            showTeachers();
            showCourses();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_courseid.Text = "";
            lbl_coursename.Text = "";
            lbl_coursecode.Text = "";
            lbl_coursefee.Text = "";

            lbl_tid.Text = "";
            lbl_tname.Text = "";
            lbl_tlast.Text = "";
            lbl_tphone.Text = "";
        }

        private void grid_courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_courses.CurrentRow.Selected = true;
            lbl_courseid.Text = grid_courses.Rows[e.RowIndex].Cells["course_ID"].Value.ToString();
            lbl_coursename.Text = grid_courses.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            lbl_coursecode.Text = grid_courses.Rows[e.RowIndex].Cells["course_code"].Value.ToString();
            lbl_coursefee.Text = grid_courses.Rows[e.RowIndex].Cells["course_fee"].Value.ToString();
        }

        private void grid_teachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_teachers.CurrentRow.Selected = true;
            lbl_tid.Text = grid_teachers.Rows[e.RowIndex].Cells["t_ID"].Value.ToString();
            lbl_tname.Text = grid_teachers.Rows[e.RowIndex].Cells["t_firstname"].Value.ToString();
            lbl_tlast.Text = grid_teachers.Rows[e.RowIndex].Cells["t_lastname"].Value.ToString();
            lbl_tphone.Text = grid_teachers.Rows[e.RowIndex].Cells["t_phone"].Value.ToString();
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            if (lbl_courseid.Text != "" && lbl_tid.Text != "")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO [TeacherEnrolls] values (@t_ID,@course_ID)";
                cmd.Parameters.AddWithValue("@t_ID", lbl_tid.Text);
                cmd.Parameters.AddWithValue("@course_ID", lbl_courseid.Text);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Teacher: " + lbl_tname.Text + " is registered to " + lbl_coursename.Text);
            }
        }
    }
}
