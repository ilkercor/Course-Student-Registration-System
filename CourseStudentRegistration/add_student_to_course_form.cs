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
    public partial class add_student_to_course_form : Form
    {
        public int debt;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");
        public add_student_to_course_form()
        {
            InitializeComponent();
        }

        public void showStudents()
        {
            var select = "SELECT * FROM [Students]";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_students.DataSource = dtrecord;
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
                this.Hide();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            if (lbl_courseid.Text != "" && lbl_stid.Text !="")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO [Enrolls] values (@st_ID,@course_ID,@payment_status,@registration_date,@st_debt)";
                cmd.Parameters.AddWithValue("@st_ID", lbl_stid.Text);
                cmd.Parameters.AddWithValue("@course_ID", lbl_courseid.Text);
                cmd.Parameters.AddWithValue("@payment_status", "Not Paid");
                cmd.Parameters.AddWithValue("@registration_date", date_regdate.Value);
                cmd.Parameters.AddWithValue("@st_debt", debt);
                int i = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Student: " + lbl_stname.Text + " is registered to " + lbl_coursename.Text);
            }
        }

        private void add_student_to_course_form_Load(object sender, EventArgs e)
        {
            showStudents();
            showCourses();
        }


        private void grid_courses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_courses.CurrentRow.Selected = true;
            lbl_courseid.Text = grid_courses.Rows[e.RowIndex].Cells["course_ID"].Value.ToString();
            lbl_coursename.Text = grid_courses.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            lbl_coursecode.Text = grid_courses.Rows[e.RowIndex].Cells["course_code"].Value.ToString();
            lbl_coursefee.Text = grid_courses.Rows[e.RowIndex].Cells["course_fee"].Value.ToString();
            debt = Int32.Parse(lbl_coursefee.Text);
        }

        private void grid_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_students.CurrentRow.Selected = true;
            lbl_stid.Text = grid_students.Rows[e.RowIndex].Cells["st_ID"].Value.ToString();
            lbl_stname.Text = grid_students.Rows[e.RowIndex].Cells["st_firstname"].Value.ToString();
            lbl_stlast.Text = grid_students.Rows[e.RowIndex].Cells["st_lastname"].Value.ToString();
            lbl_stphone.Text = grid_students.Rows[e.RowIndex].Cells["st_phone"].Value.ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            lbl_courseid.Text = "";
            lbl_coursename.Text = "";
            lbl_coursecode.Text = "";
            lbl_coursefee.Text = "";

            lbl_stid.Text = "";
            lbl_stname.Text = "";
            lbl_stlast.Text = "";
            lbl_stphone.Text = "";

            txt_search_course.Text = "";
            txt_search_st.Text = "";

            date_regdate.Value = DateTime.Now;
        }

        private void txt_search_course_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT * FROM [Courses] WHERE course_name LIKE '%" + txt_search_course.Text + "%'";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_courses.DataSource = dtrecord;
        }

        private void txt_search_st_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT * FROM [Students] WHERE st_firstname LIKE '%" + txt_search_st.Text + "%'";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_students.DataSource = dtrecord;
        }
    }
}
