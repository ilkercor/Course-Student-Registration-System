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
    public partial class course_creation_from : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public course_creation_from()
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

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            string countstring = "SELECT COUNT(*) FROM [Courses]";
            SqlCommand countcmd = new SqlCommand(countstring, conn);
            Int32 count = Convert.ToInt32(countcmd.ExecuteScalar());
            txt_cid.Text = (count + 1).ToString();
            conn.Close();
        }
        private void course_creation_from_Load(object sender, EventArgs e)
        {
            showCourses();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            showCourses();
            txt_cname.Text = "";
            txt_ccode.Text = "";
            txt_cprice.Text = "";
            date_startdate.Value = DateTime.Now;
            date_enddate.Value = DateTime.Now;
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

        private void btn_save_Click(object sender, EventArgs e)
        {if (txt_cid.Text != "" && Int32.TryParse(txt_cid.Text, out int value))
            {if (txt_cname.Text != "")
                {if (txt_ccode.Text != "")
                    {if (txt_cprice.Text != "" && Int32.TryParse(txt_cprice.Text, out int value2))
                        {
                            if (conn.State.ToString() == "Closed")
                            {
                                conn.Open();
                            }
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "INSERT INTO [Courses] values (@course_ID,@course_name,@course_code,@start_date,@end_date,@course_fee)";
                            cmd.Parameters.AddWithValue("@course_ID", txt_cid.Text);
                            cmd.Parameters.AddWithValue("@course_name", txt_cname.Text);
                            cmd.Parameters.AddWithValue("@course_code", txt_ccode.Text);
                            cmd.Parameters.AddWithValue("@start_date", date_startdate.Value);
                            cmd.Parameters.AddWithValue("@end_date", date_enddate.Value);
                            cmd.Parameters.AddWithValue("@course_fee", txt_cprice.Text);
                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            conn.Close();
                            showCourses();
                        }else MessageBox.Show("All information must be filled and PRICE must be numeric.");
                    }else MessageBox.Show("All information must be filled.");
                }else MessageBox.Show("All information must be filled.");
            }else MessageBox.Show("All information must be filled and ID must be numeric.");
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
            txt_cid.Text = grid_courses.Rows[e.RowIndex].Cells["course_ID"].Value.ToString();
            txt_cname.Text = grid_courses.Rows[e.RowIndex].Cells["course_name"].Value.ToString();
            txt_ccode.Text = grid_courses.Rows[e.RowIndex].Cells["course_code"].Value.ToString();
            txt_cprice.Text = grid_courses.Rows[e.RowIndex].Cells["course_fee"].Value.ToString();
            date_startdate.Value = DateTime.Parse(grid_courses.Rows[e.RowIndex].Cells["start_date"].Value.ToString());
            date_enddate.Value = DateTime.Parse(grid_courses.Rows[e.RowIndex].Cells["end_date"].Value.ToString());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            String st = "DELETE FROM [Courses] WHERE course_ID =" + txt_cid.Text;

            SqlCommand sqlcom = new SqlCommand(st, conn);
            try
            {
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("delete successful");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            showCourses();
            if (conn.State.ToString() != "Closed")
            {
                conn.Close();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcommand = new SqlCommand();
            newcommand.Connection = conn;
            newcommand.CommandText = "UPDATE [Courses] SET course_ID =@course_ID, course_name=@course_name, course_code=@course_code, start_date=@start_date, end_date=@end_date, course_fee=@course_fee WHERE course_ID=@course_ID";
            newcommand.Parameters.AddWithValue("@course_ID", txt_cid.Text);
            newcommand.Parameters.AddWithValue("@course_name", txt_cname.Text);
            newcommand.Parameters.AddWithValue("@course_code", txt_ccode.Text);
            newcommand.Parameters.AddWithValue("@course_fee", txt_cprice.Text);
            newcommand.Parameters.AddWithValue("@start_date", date_startdate.Value);
            newcommand.Parameters.AddWithValue("@end_date", date_enddate.Value);

            int j = newcommand.ExecuteNonQuery();
            conn.Close();
            if (j != 0)
                MessageBox.Show("Updated");
            else
                MessageBox.Show("Error!! Try Again!!");
            showCourses();
        }
    }
}
