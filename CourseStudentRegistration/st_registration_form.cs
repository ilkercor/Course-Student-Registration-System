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
    public partial class st_registration_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-J4PRRS2\\SQLEXPRESS;Initial Catalog=CourseStudentSystem;Integrated Security=True");

        public st_registration_form()
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

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            string countstring = "SELECT COUNT(*) FROM [Students]";
            SqlCommand countcmd = new SqlCommand(countstring, conn);
            Int32 count = Convert.ToInt32(countcmd.ExecuteScalar());
            txt_st_id.Text = (count+1).ToString();
            conn.Close();
        }

        private void st_registration_form_Load(object sender, EventArgs e)
        {
            showStudents();
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_st_fname.Text = "";
            txt_st_lname.Text = "";
            txt_st_email.Text = "";
            txt_st_phone.Text = "";
            rbtn_female.Checked = false;
            rbtn_male.Checked = false;
            showStudents();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_st_fname.Text != "")
            {if (txt_st_lname.Text != "")
                {if (txt_st_email.Text != "")
                    {if (txt_st_phone.Text != "")
                        {if (txt_st_id.Text != "" && Int32.TryParse(txt_st_id.Text, out int value))
                            {if (rbtn_female.Checked || rbtn_male.Checked)
                                {conn.Open();
                                    SqlCommand cmd = new SqlCommand();
                                    cmd.Connection = conn;
                                    cmd.CommandText = "INSERT INTO [Students] values (@st_ID,@st_firstname,@st_lastname,@st_email,@st_phone,@st_gender)";
                                    cmd.Parameters.AddWithValue("@st_ID", txt_st_id.Text);
                                    cmd.Parameters.AddWithValue("@st_firstname", txt_st_fname.Text);
                                    cmd.Parameters.AddWithValue("@st_lastname", txt_st_lname.Text);
                                    cmd.Parameters.AddWithValue("@st_email", txt_st_email.Text);
                                    cmd.Parameters.AddWithValue("@st_phone", txt_st_phone.Text);
                                    if (rbtn_male.Checked)
                                        cmd.Parameters.AddWithValue("@st_gender", "Male");
                                    else
                                        cmd.Parameters.AddWithValue("@st_gender", "Female");
                                    try 
                                    { 
                                        int i = cmd.ExecuteNonQuery(); 
                                    }
                                    catch(Exception ex) 
                                    { 
                                        MessageBox.Show(ex.Message); 
                                    }
                                    
                                    conn.Close();
                                    showStudents();
                                }else MessageBox.Show("All information must be filled.");
                            }else MessageBox.Show("All information must be filled and ID must be numeric.");
                        }else MessageBox.Show("All information must be filled.");
                    }else MessageBox.Show("All information must be filled.");
                }else MessageBox.Show("All information must be filled.");
            }else MessageBox.Show("All information must be filled.");
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
            txt_st_id.Text = grid_students.Rows[e.RowIndex].Cells["st_ID"].Value.ToString();
            txt_st_fname.Text = grid_students.Rows[e.RowIndex].Cells["st_firstname"].Value.ToString();
            txt_st_lname.Text = grid_students.Rows[e.RowIndex].Cells["st_lastname"].Value.ToString();
            txt_st_email.Text = grid_students.Rows[e.RowIndex].Cells["st_email"].Value.ToString();
            txt_st_phone.Text = grid_students.Rows[e.RowIndex].Cells["st_phone"].Value.ToString();
            if (grid_students.Rows[e.RowIndex].Cells["st_gender"].Value.ToString() == "Male")
                rbtn_male.Checked = true;
            else
                rbtn_female.Checked = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            String st = "DELETE FROM [Students] WHERE st_ID =" + txt_st_id.Text;
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
            showStudents();
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
            newcommand.CommandText = "UPDATE [Students] SET st_firstname =@st_firstname, st_lastname=@st_lastname, st_email=@st_email, st_phone=@st_phone, st_gender=@st_gender WHERE st_ID=@st_ID";
            newcommand.Parameters.AddWithValue("@st_ID", txt_st_id.Text);
            newcommand.Parameters.AddWithValue("@st_firstname", txt_st_fname.Text);
            newcommand.Parameters.AddWithValue("@st_lastname", txt_st_lname.Text);
            newcommand.Parameters.AddWithValue("@st_email", txt_st_email.Text);
            newcommand.Parameters.AddWithValue("@st_phone", txt_st_phone.Text);
            if (rbtn_male.Checked)
                newcommand.Parameters.AddWithValue("@st_gender", "Male");
            else
                newcommand.Parameters.AddWithValue("@st_gender", "Female");

            int j = newcommand.ExecuteNonQuery();
            conn.Close();
            if (j != 0)
                MessageBox.Show("Updated");
            else
                MessageBox.Show("Error!! Try Again!!");
            showStudents();
        }
    }
}
