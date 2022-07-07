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
    public partial class course_report_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public course_report_form()
        {
            InitializeComponent();
        }
        public void showCourses()
        {
            var select = "SELECT * FROM [Courses]";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_courses.DataSource = dtrecord;
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

        private void course_report_form_Load(object sender, EventArgs e)
        {
            showCourses();
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT * FROM [Courses] WHERE course_name LIKE '%" + txt_search.Text + "%'";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_courses.DataSource = dtrecord;
        }

        private void grid_courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_courses.CurrentRow.Selected = true;
            lb_data_cid.Text = grid_courses.Rows[e.RowIndex].Cells["course_ID"].Value.ToString();
            lb_data_cname.Text = grid_courses.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            lb_data_ccode.Text = grid_courses.Rows[e.RowIndex].Cells["course_code"].Value.ToString();
            lb_data_cfee.Text = grid_courses.Rows[e.RowIndex].Cells["course_fee"].Value.ToString();
            lb_data_start.Text = grid_courses.Rows[e.RowIndex].Cells["start_date"].Value.ToString();
            lb_data_end.Text = grid_courses.Rows[e.RowIndex].Cells["end_date"].Value.ToString();

            SqlCommand select = new SqlCommand("Select course_name,[Teachers].t_ID,[Teachers].t_firstname,[Teachers].t_lastname from [TeacherEnrolls] RIGHT JOIN [Courses] ON [TeacherEnrolls].course_ID=[Courses].course_ID RIGHT JOIN [Teachers] ON [Teachers].t_ID=[TeacherEnrolls].t_ID WHERE [TeacherEnrolls].course_ID IS NOT NULL AND [TeacherEnrolls].course_ID=@course_ID");
            select.Connection = conn;
            select.Parameters.AddWithValue("@course_ID", lb_data_cid.Text);

            var dataAdapter = new SqlDataAdapter(select);

            DataTable enroldtrecord = new DataTable();
            dataAdapter.Fill(enroldtrecord);
            grid_data_teachers.DataSource = enroldtrecord;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand countstring = new SqlCommand("SELECT COUNT(*) FROM [Enrolls] WHERE course_ID=@course_ID");
            countstring.Connection = conn;
            countstring.Parameters.AddWithValue("course_ID", lb_data_cid.Text);
            lb_data_ctotalst.Text = countstring.ExecuteScalar().ToString();
            conn.Close();

            lb_data_cearning.Text = (Int32.Parse(lb_data_cfee.Text) * Int32.Parse(lb_data_ctotalst.Text)).ToString();


        }


    }
}
