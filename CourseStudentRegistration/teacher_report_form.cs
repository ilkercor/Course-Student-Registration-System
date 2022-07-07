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
    public partial class teacher_report_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public teacher_report_form()
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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void teacher_report_form_Load(object sender, EventArgs e)
        {
            showTeachers();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT * FROM [Teachers] WHERE t_firstname LIKE '%" + txt_search.Text + "%'";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_teachers.DataSource = dtrecord;
        }

        private void grid_teachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_teachers.CurrentRow.Selected = true;
            lb_data_ID.Text = grid_teachers.Rows[e.RowIndex].Cells["t_ID"].Value.ToString();
            lb_data_fname.Text = grid_teachers.Rows[e.RowIndex].Cells["t_firstname"].Value.ToString();
            lb_data_lname.Text = grid_teachers.Rows[e.RowIndex].Cells["t_lastname"].Value.ToString();
            lb_data_email.Text = grid_teachers.Rows[e.RowIndex].Cells["t_email"].Value.ToString();
            lb_data_phone.Text = grid_teachers.Rows[e.RowIndex].Cells["t_phone"].Value.ToString();
            if (grid_teachers.Rows[e.RowIndex].Cells["t_gender"].Value.ToString() == "Male")
                lb_data_gender.Text = "Male";
            else
                lb_data_gender.Text = "Female";


            SqlCommand select = new SqlCommand("Select [Teachers].t_firstname,course_name,[TeacherEnrolls].course_ID from [TeacherEnrolls] RIGHT JOIN [Courses] ON [TeacherEnrolls].course_ID=[Courses].course_ID RIGHT JOIN [Teachers] ON [Teachers].t_ID=[TeacherEnrolls].t_ID WHERE [TeacherEnrolls].course_ID IS NOT NULL AND [TeacherEnrolls].t_ID=@t_ID");
            select.Connection = conn;
            select.Parameters.AddWithValue("@t_ID", lb_data_ID.Text);

            var dataAdapter = new SqlDataAdapter(select);

            DataTable enroldtrecord = new DataTable();
            dataAdapter.Fill(enroldtrecord);
            grid_data_courses.DataSource = enroldtrecord;
        }
    }
}
