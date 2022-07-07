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
    public partial class teacher_registration_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public teacher_registration_form()
        {
            InitializeComponent();
        }
        private void teacher_registration_form_Load(object sender, EventArgs e)
        {
            showTeachers();
        }

        public void showTeachers()
        {
            var select = "SELECT * FROM [Teachers]";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_teachers.DataSource = dtrecord;

            if (conn.State.ToString() == "Closed")
                conn.Open();

            string countstring = "SELECT COUNT(*) FROM [Teachers]";
            SqlCommand countcmd = new SqlCommand(countstring, conn);
            Int32 count = Convert.ToInt32(countcmd.ExecuteScalar());
            txt_t_id.Text = (count + 1).ToString();
            conn.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_t_fname.Text != "")
            {if (txt_t_lname.Text != "")
                {if (txt_t_email.Text != "")
                    {if (txt_t_phone.Text != "")
                        {if (txt_t_id.Text != "" && Int32.TryParse(txt_t_id.Text, out int value))
                            {if (rbtn_female.Checked || rbtn_male.Checked)
                                {
                                    if (conn.State.ToString() == "Closed")
                                        conn.Open();
                                    SqlCommand cmd = new SqlCommand();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "INSERT INTO [Teachers] values (@t_ID,@t_firstname,@t_lastname,@t_email,@t_phone,@t_gender)";
                                    cmd.Parameters.AddWithValue("@t_ID", txt_t_id.Text);
                                    cmd.Parameters.AddWithValue("@t_firstname", txt_t_fname.Text);
                                    cmd.Parameters.AddWithValue("@t_lastname", txt_t_lname.Text);
                                    cmd.Parameters.AddWithValue("@t_email", txt_t_email.Text);
                                    cmd.Parameters.AddWithValue("@t_phone", txt_t_phone.Text);
                                    if (rbtn_male.Checked)
                                        cmd.Parameters.AddWithValue("@t_gender", "Male");
                                    else
                                        cmd.Parameters.AddWithValue("@t_gender", "Female");
                                    try
                                    {
                                        int i = cmd.ExecuteNonQuery();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                    conn.Close();
                                    showTeachers();
                                }else MessageBox.Show("All information must be filled.");
                            }else MessageBox.Show("All information must be filled and ID must be numeric.");
                        }else MessageBox.Show("All information must be filled.");
                    }else MessageBox.Show("All information must be filled.");
                }else MessageBox.Show("All information must be filled.");
            }else MessageBox.Show("All information must be filled.");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_t_fname.Text = "";
            txt_t_lname.Text = "";
            txt_t_email.Text = "";
            txt_t_phone.Text = "";
            showTeachers();
            rbtn_female.Checked = false;
            rbtn_male.Checked = false;
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
            var select = "SELECT * FROM [Teachers] WHERE t_firstname LIKE '%" + txt_search.Text + "%'";
            var dataAdapter = new SqlDataAdapter(select, conn);

            DataTable dtrecord = new DataTable();
            dataAdapter.Fill(dtrecord);
            grid_teachers.DataSource = dtrecord;
        }

        private void btn_t_delete_Click(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            String st = "DELETE FROM [Teachers] WHERE t_ID =" + txt_t_id.Text;

            SqlCommand sqlcom = new SqlCommand(st, conn);
            try
            {

                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            showTeachers();
            if (conn.State.ToString() != "Closed")
            {
                conn.Close();
            }
        }

        private void grid_teachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_teachers.CurrentRow.Selected = true;
            txt_t_id.Text = grid_teachers.Rows[e.RowIndex].Cells["t_ID"].Value.ToString();
            txt_t_fname.Text = grid_teachers.Rows[e.RowIndex].Cells["t_firstname"].Value.ToString();
            txt_t_lname.Text = grid_teachers.Rows[e.RowIndex].Cells["t_lastname"].Value.ToString();
            txt_t_email.Text = grid_teachers.Rows[e.RowIndex].Cells["t_email"].Value.ToString();
            txt_t_phone.Text = grid_teachers.Rows[e.RowIndex].Cells["t_phone"].Value.ToString();
            if (grid_teachers.Rows[e.RowIndex].Cells["t_gender"].Value.ToString() == "Male")
                rbtn_male.Checked = true;
            else
                rbtn_female.Checked = true;
        }

        private void btn_t_update_Click(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcommand = new SqlCommand();
            newcommand.Connection = conn;
            newcommand.CommandText = "UPDATE [Teachers] SET t_firstname =@t_firstname, t_lastname=@t_lastname, t_email=@t_email, t_phone=@t_phone, t_gender=@t_gender WHERE t_ID=@t_ID";
            newcommand.Parameters.AddWithValue("@t_ID", txt_t_id.Text);
            newcommand.Parameters.AddWithValue("@t_firstname", txt_t_fname.Text);
            newcommand.Parameters.AddWithValue("@t_lastname", txt_t_lname.Text);
            newcommand.Parameters.AddWithValue("@t_email", txt_t_email.Text);
            newcommand.Parameters.AddWithValue("@t_phone", txt_t_phone.Text);
            if (rbtn_male.Checked)
                newcommand.Parameters.AddWithValue("@t_gender", "Male");
            else
                newcommand.Parameters.AddWithValue("@t_gender", "Female");

            int j = newcommand.ExecuteNonQuery();
            conn.Close();
            if (j != 0)
                MessageBox.Show("Updated");
            else
                MessageBox.Show("Error!! Try Again!!");
            showTeachers();
        }
    }
}
