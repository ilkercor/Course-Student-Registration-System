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
    public partial class accept_payment : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");
        public int st_ID;
        public int course_ID;
        public int st_debt = 0;
        public accept_payment()
        {
            InitializeComponent();
        }

        private void accept_payment_Load(object sender, EventArgs e)
        {
            showStudents();
        }
        public void showStudents()
        {
            var select = "SELECT st_ID,st_firstname,st_lastname,st_phone FROM [Students]";
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
            lb_data_stname.Text = grid_students.Rows[e.RowIndex].Cells["st_firstname"].Value.ToString();
            lb_data_stname.Text += " "+ grid_students.Rows[e.RowIndex].Cells["st_lastname"].Value.ToString();
            st_ID = Int32.Parse(grid_students.Rows[e.RowIndex].Cells["st_ID"].Value.ToString());
            showAllCourses();
            
        }

        public void showAllCourses()
        {
            SqlCommand comm = new SqlCommand("Select [Enrolls].st_ID,st_firstname,[Enrolls].course_ID,course_name,[Enrolls].st_debt,course_fee from [Enrolls] RIGHT JOIN [Courses] ON [Enrolls].course_ID=[Courses].course_ID RIGHT JOIN [Students] ON [Students].st_ID=[Enrolls].st_ID WHERE [Enrolls].course_ID IS NOT NULL AND [Enrolls].st_debt <= 0 AND [Enrolls].st_ID=@st_ID");
            comm.Connection = conn;
            comm.Parameters.AddWithValue("@st_ID", st_ID);
            comm.Parameters.AddWithValue("@st_debt",st_debt);
            var dataAdaptercomm = new SqlDataAdapter(comm);

            DataTable dtrecordcomm = new DataTable();
            dataAdaptercomm.Fill(dtrecordcomm);
            grid_paid.DataSource = dtrecordcomm;


            SqlCommand select = new SqlCommand("Select [Enrolls].st_ID,st_firstname,[Enrolls].course_ID,course_name,[Enrolls].st_debt,course_fee from [Enrolls] RIGHT JOIN [Courses] ON [Enrolls].course_ID=[Courses].course_ID RIGHT JOIN [Students] ON [Students].st_ID=[Enrolls].st_ID WHERE [Enrolls].course_ID IS NOT NULL AND [Enrolls].st_debt > 0 AND [Enrolls].st_ID=@st_ID");
            select.Connection = conn;
            select.Parameters.AddWithValue("@st_ID", st_ID);
            select.Parameters.AddWithValue("@st_debt", st_debt);
            var dataAdapter = new SqlDataAdapter(select);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_unpaid.DataSource = dtrecord;
        }

        private void grid_paid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_paid.CurrentRow.Selected = true;
            lbl_data_course.Text= grid_paid.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            lb_data_payment.ForeColor = Color.Green;
            lb_data_payment.Text = "Paid";
            lb_data_debt.Text = grid_paid.Rows[e.RowIndex].Cells["st_debt"].Value.ToString();
            course_ID = Int32.Parse(grid_paid.Rows[e.RowIndex].Cells["course_ID"].Value.ToString());
            lb_course_fee.Text = grid_paid.Rows[e.RowIndex].Cells["course_fee"].Value.ToString();

        }

        private void grid_unpaid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_unpaid.CurrentRow.Selected = true;
            lbl_data_course.Text = grid_unpaid.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            lb_data_payment.ForeColor = Color.Red;
            lb_data_payment.Text = "Unpaid !!!";
            lb_data_debt.Text = grid_unpaid.Rows[e.RowIndex].Cells["st_debt"].Value.ToString();
            course_ID = Int32.Parse(grid_unpaid.Rows[e.RowIndex].Cells["course_ID"].Value.ToString());
            lb_course_fee.Text = grid_unpaid.Rows[e.RowIndex].Cells["course_fee"].Value.ToString();
        }

        private void btn_get_full_Click(object sender, EventArgs e)
        {
            txt_amount.Text = lb_data_debt.Text;
        }

        private void btn_get_half_Click(object sender, EventArgs e)
        {
            try { 
            txt_amount.Text = (Int32.Parse(lb_data_debt.Text)/2).ToString();
            }
            catch
            {
                MessageBox.Show("FIRST Select a Course!");
            }
        }

        private void btn_get_16_Click(object sender, EventArgs e)
        {
            try { 
            txt_amount.Text = (Int32.Parse(lb_data_debt.Text) / 6).ToString();
            }
            catch
            {
                MessageBox.Show("FIRST Select a Course!");
                
            }
        }
        private void btn_accept_payment_Click(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
                conn.Open();
            if (Int32.Parse(txt_amount.Text) > Int32.Parse(lb_data_debt.Text)) { 
                MessageBox.Show("Amount can not be bigger than debt!");
                txt_amount.Text = "0";
                }
            if (Int32.Parse(txt_amount.Text) >= 0)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE [Enrolls] SET  st_debt=@st_debt WHERE st_ID=@st_ID AND course_ID=@course_ID";
                command.Parameters.AddWithValue("@st_ID", st_ID);
                command.Parameters.AddWithValue("@course_ID", course_ID);
                command.Parameters.AddWithValue("@st_debt", (Int32.Parse(lb_data_debt.Text) - Int32.Parse(txt_amount.Text)));

                try
                {
                    int i = command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Try Again");
                }
                showAllCourses();
                lb_data_debt.Text = (Int32.Parse(lb_data_debt.Text) - Int32.Parse(txt_amount.Text)).ToString();
            }
            else
                MessageBox.Show("Enter Positive Amount");
        }

        private void btn_half_fee_Click(object sender, EventArgs e)
        {
            try
            {
                txt_amount.Text = (Int32.Parse(lb_course_fee.Text) / 2).ToString();
            }
            catch
            {
                MessageBox.Show("FIRST Select a Course!");
            }
        }

        private void btn_half_16_Click(object sender, EventArgs e)
        {
            try
            {
                txt_amount.Text = (Int32.Parse(lb_course_fee.Text) / 6).ToString();
            }
            catch
            {
                MessageBox.Show("FIRST Select a Course!");
            }
        }
    }
}
