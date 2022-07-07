
namespace CourseStudentRegistration
{
    partial class teacher_registration_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_t_id = new System.Windows.Forms.TextBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_gender = new System.Windows.Forms.Label();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.txt_t_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.txt_t_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.txt_t_lname = new System.Windows.Forms.TextBox();
            this.lb_lname = new System.Windows.Forms.Label();
            this.txt_t_fname = new System.Windows.Forms.TextBox();
            this.lb_fname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_t_delete = new System.Windows.Forms.Button();
            this.btn_t_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_teachers = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_teachers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Olive;
            this.groupBox1.Controls.Add(this.txt_t_id);
            this.groupBox1.Controls.Add(this.lb_id);
            this.groupBox1.Controls.Add(this.lb_gender);
            this.groupBox1.Controls.Add(this.rbtn_female);
            this.groupBox1.Controls.Add(this.rbtn_male);
            this.groupBox1.Controls.Add(this.txt_t_phone);
            this.groupBox1.Controls.Add(this.lb_phone);
            this.groupBox1.Controls.Add(this.txt_t_email);
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.txt_t_lname);
            this.groupBox1.Controls.Add(this.lb_lname);
            this.groupBox1.Controls.Add(this.txt_t_fname);
            this.groupBox1.Controls.Add(this.lb_fname);
            this.groupBox1.Location = new System.Drawing.Point(682, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 550);
            this.groupBox1.TabIndex = 9999;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher";
            // 
            // txt_t_id
            // 
            this.txt_t_id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_t_id.Location = new System.Drawing.Point(100, 50);
            this.txt_t_id.Multiline = true;
            this.txt_t_id.Name = "txt_t_id";
            this.txt_t_id.ReadOnly = true;
            this.txt_t_id.Size = new System.Drawing.Size(141, 32);
            this.txt_t_id.TabIndex = 99999;
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_id.Location = new System.Drawing.Point(62, 50);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(28, 16);
            this.lb_id.TabIndex = 11;
            this.lb_id.Text = "ID:";
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_gender.Location = new System.Drawing.Point(30, 400);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(60, 16);
            this.lb_gender.TabIndex = 10;
            this.lb_gender.Text = "Gender:";
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(100, 424);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(59, 17);
            this.rbtn_female.TabIndex = 8;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "&Female";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(100, 400);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(48, 17);
            this.rbtn_male.TabIndex = 7;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "&Male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // txt_t_phone
            // 
            this.txt_t_phone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_t_phone.Location = new System.Drawing.Point(100, 330);
            this.txt_t_phone.Multiline = true;
            this.txt_t_phone.Name = "txt_t_phone";
            this.txt_t_phone.Size = new System.Drawing.Size(141, 32);
            this.txt_t_phone.TabIndex = 6;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_phone.Location = new System.Drawing.Point(18, 330);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(76, 16);
            this.lb_phone.TabIndex = 6;
            this.lb_phone.Text = "Phone No:";
            // 
            // txt_t_email
            // 
            this.txt_t_email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_t_email.Location = new System.Drawing.Point(100, 260);
            this.txt_t_email.Multiline = true;
            this.txt_t_email.Name = "txt_t_email";
            this.txt_t_email.Size = new System.Drawing.Size(141, 32);
            this.txt_t_email.TabIndex = 5;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_email.Location = new System.Drawing.Point(40, 260);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 16);
            this.lb_email.TabIndex = 4;
            this.lb_email.Text = "E-Mail:";
            // 
            // txt_t_lname
            // 
            this.txt_t_lname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_t_lname.Location = new System.Drawing.Point(100, 190);
            this.txt_t_lname.Multiline = true;
            this.txt_t_lname.Name = "txt_t_lname";
            this.txt_t_lname.Size = new System.Drawing.Size(141, 32);
            this.txt_t_lname.TabIndex = 4;
            // 
            // lb_lname
            // 
            this.lb_lname.AutoSize = true;
            this.lb_lname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_lname.Location = new System.Drawing.Point(11, 190);
            this.lb_lname.Name = "lb_lname";
            this.lb_lname.Size = new System.Drawing.Size(83, 16);
            this.lb_lname.TabIndex = 2;
            this.lb_lname.Text = "Last Name:";
            // 
            // txt_t_fname
            // 
            this.txt_t_fname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_t_fname.Location = new System.Drawing.Point(100, 120);
            this.txt_t_fname.Multiline = true;
            this.txt_t_fname.Name = "txt_t_fname";
            this.txt_t_fname.Size = new System.Drawing.Size(141, 32);
            this.txt_t_fname.TabIndex = 3;
            // 
            // lb_fname
            // 
            this.lb_fname.AutoSize = true;
            this.lb_fname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_fname.Location = new System.Drawing.Point(10, 120);
            this.lb_fname.Name = "lb_fname";
            this.lb_fname.Size = new System.Drawing.Size(84, 16);
            this.lb_fname.TabIndex = 0;
            this.lb_fname.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Olive;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.btn_t_delete);
            this.groupBox2.Controls.Add(this.btn_t_update);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Location = new System.Drawing.Point(958, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 550);
            this.groupBox2.TabIndex = 9999999;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // btn_t_delete
            // 
            this.btn_t_delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_t_delete.Location = new System.Drawing.Point(80, 270);
            this.btn_t_delete.Name = "btn_t_delete";
            this.btn_t_delete.Size = new System.Drawing.Size(102, 44);
            this.btn_t_delete.TabIndex = 11;
            this.btn_t_delete.Text = "&Delete";
            this.btn_t_delete.UseVisualStyleBackColor = false;
            this.btn_t_delete.Click += new System.EventHandler(this.btn_t_delete_Click);
            // 
            // btn_t_update
            // 
            this.btn_t_update.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_t_update.Location = new System.Drawing.Point(80, 170);
            this.btn_t_update.Name = "btn_t_update";
            this.btn_t_update.Size = new System.Drawing.Size(102, 44);
            this.btn_t_update.TabIndex = 10;
            this.btn_t_update.Text = "&Update";
            this.btn_t_update.UseVisualStyleBackColor = false;
            this.btn_t_update.Click += new System.EventHandler(this.btn_t_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_save.Location = new System.Drawing.Point(80, 70);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 44);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_clear.Location = new System.Drawing.Point(80, 480);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(102, 44);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "&Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(214, 49);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(403, 33);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by Name:";
            // 
            // grid_teachers
            // 
            this.grid_teachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid_teachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_teachers.Location = new System.Drawing.Point(17, 100);
            this.grid_teachers.Name = "grid_teachers";
            this.grid_teachers.Size = new System.Drawing.Size(600, 550);
            this.grid_teachers.TabIndex = 9999999;
            this.grid_teachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_teachers_CellClick);
            // 
            // teacher_registration_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_teachers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "teacher_registration_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Registration";
            this.Load += new System.EventHandler(this.teacher_registration_form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_teachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_t_id;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.RadioButton rbtn_female;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.TextBox txt_t_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox txt_t_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox txt_t_lname;
        private System.Windows.Forms.Label lb_lname;
        private System.Windows.Forms.TextBox txt_t_fname;
        private System.Windows.Forms.Label lb_fname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_t_delete;
        private System.Windows.Forms.Button btn_t_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_teachers;
    }
}