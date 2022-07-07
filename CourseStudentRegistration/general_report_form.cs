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
    
    public partial class general_report_form : Form
    {
        DateTime Now = DateTime.Now;
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public general_report_form()
        {
            InitializeComponent();
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
        
        public void showActiveCourses()
        {
            SqlCommand select = new SqlCommand();
            select.CommandText = "SELECT * FROM [Courses] WHERE end_date >= @Now";
            select.Connection = conn;
            select.Parameters.AddWithValue("@Now", Now);
            var dataAdapter = new SqlDataAdapter(select);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_active_courses.DataSource = dtrecord;grid_active_courses.Columns[0].HeaderText = "ID";
            grid_active_courses.Columns[1].HeaderText = "Name";
            grid_active_courses.Columns[2].HeaderText = "Code";
            grid_active_courses.Columns[3].HeaderText = "Start";
            grid_active_courses.Columns[4].HeaderText = "End";
            grid_active_courses.Columns[5].HeaderText = "Fee";

            
        }
        public void showExpiredCourses()
        {
            SqlCommand selectex = new SqlCommand();
            selectex.CommandText = "SELECT * FROM [Courses] WHERE end_date < @Now";
            selectex.Connection = conn;
            selectex.Parameters.AddWithValue("@Now", Now);
            var dataAdapterex = new SqlDataAdapter(selectex);

            DataTable dtrecordex = new DataTable();
            dataAdapterex.Fill(dtrecordex);
            grid_expired_courses.DataSource = dtrecordex;

            grid_expired_courses.Columns[0].HeaderText = "ID";
            grid_expired_courses.Columns[1].HeaderText = "Name";
            grid_expired_courses.Columns[2].HeaderText = "Code";
            grid_expired_courses.Columns[3].HeaderText = "Start";
            grid_expired_courses.Columns[4].HeaderText = "End";
            grid_expired_courses.Columns[5].HeaderText = "Fee";

        }

        private void general_report_form_Load(object sender, EventArgs e)
        {
            conn.Open();
            
            string countstring = "SELECT COUNT(*) FROM [Students]";
            SqlCommand countcmd = new SqlCommand(countstring, conn);
            Int32 count = Convert.ToInt32(countcmd.ExecuteScalar());
            lb_data_totalst.Text = count.ToString();

            string countinstructorstring = "SELECT COUNT(*) FROM [Teachers]";
            SqlCommand countcmdinstructor = new SqlCommand(countinstructorstring, conn);
            Int32 countinstructor = Convert.ToInt32(countcmdinstructor.ExecuteScalar());
            lb_data_total_instructor.Text = countinstructor.ToString();

            showActiveCourses();
            showExpiredCourses();

            conn.Close();
        }
    }
}
