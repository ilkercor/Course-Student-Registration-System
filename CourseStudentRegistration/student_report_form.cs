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
    public partial class student_report_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public student_report_form()
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
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void student_report_form_Load(object sender, EventArgs e)
        {
            showStudents();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var select = "SELECT * FROM [Students] WHERE st_firstname LIKE '%" + txt_search.Text + "%'";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_students.DataSource = dtrecord;    
        }

        private void grid_students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_students.CurrentRow.Selected = true;
            lb_data_ID.Text = grid_students.Rows[e.RowIndex].Cells["st_ID"].Value.ToString();
            lb_data_fname.Text = grid_students.Rows[e.RowIndex].Cells["st_firstname"].Value.ToString();
            lb_data_lname.Text = grid_students.Rows[e.RowIndex].Cells["st_lastname"].Value.ToString();
            lb_data_email.Text = grid_students.Rows[e.RowIndex].Cells["st_email"].Value.ToString();
            lb_data_phone.Text = grid_students.Rows[e.RowIndex].Cells["st_phone"].Value.ToString();
            if (grid_students.Rows[e.RowIndex].Cells["st_gender"].Value.ToString() == "Male")
                lb_data_gender.Text = "Male";
            else
                lb_data_gender.Text = "Female";




            SqlCommand select = new SqlCommand("Select [Enrolls].course_ID,course_name,registration_date,[Enrolls].st_debt from [Enrolls] RIGHT JOIN [Courses] ON [Enrolls].course_ID=[Courses].course_ID RIGHT JOIN [Students] ON [Students].st_ID=[Enrolls].st_ID WHERE [Enrolls].course_ID IS NOT NULL AND [Enrolls].st_ID=@st_ID");
            select.Connection = conn;
            select.Parameters.AddWithValue("@st_ID", lb_data_ID.Text);

            var dataAdapter = new SqlDataAdapter(select);

            DataTable enroldtrecord = new DataTable();
            dataAdapter.Fill(enroldtrecord);
            grid_data_courses.DataSource = enroldtrecord;
        }

    }
}
