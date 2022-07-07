
namespace CourseStudentRegistration
{
    partial class accept_payment
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
            this.lb_payment_status = new System.Windows.Forms.Label();
            this.lb_choose_student = new System.Windows.Forms.Label();
            this.lb_data_payment = new System.Windows.Forms.Label();
            this.lb_sname = new System.Windows.Forms.Label();
            this.lb_data_stname = new System.Windows.Forms.Label();
            this.btn_accept_payment = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.grid_paid = new System.Windows.Forms.DataGridView();
            this.grid_unpaid = new System.Windows.Forms.DataGridView();
            this.lbl_data_course = new System.Windows.Forms.Label();
            this.lbl_selected = new System.Windows.Forms.Label();
            this.lbl_paid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_get_half = new System.Windows.Forms.Button();
            this.btn_get_16 = new System.Windows.Forms.Button();
            this.btn_get_full = new System.Windows.Forms.Button();
            this.lb_data_debt = new System.Windows.Forms.Label();
            this.lb_student_debt = new System.Windows.Forms.Label();
            this.grid_students = new System.Windows.Forms.DataGridView();
            this.lb_course_fee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_half_16 = new System.Windows.Forms.Button();
            this.btn_half_fee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_paid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_unpaid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_payment_status
            // 
            this.lb_payment_status.AutoSize = true;
            this.lb_payment_status.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_payment_status.Location = new System.Drawing.Point(116, 360);
            this.lb_payment_status.Name = "lb_payment_status";
            this.lb_payment_status.Size = new System.Drawing.Size(187, 25);
            this.lb_payment_status.TabIndex = 99;
            this.lb_payment_status.Text = "Payment Status:";
            // 
            // lb_choose_student
            // 
            this.lb_choose_student.AutoSize = true;
            this.lb_choose_student.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_choose_student.Location = new System.Drawing.Point(133, 63);
            this.lb_choose_student.Name = "lb_choose_student";
            this.lb_choose_student.Size = new System.Drawing.Size(184, 25);
            this.lb_choose_student.TabIndex = 41;
            this.lb_choose_student.Text = "Search Student:";
            // 
            // lb_data_payment
            // 
            this.lb_data_payment.AutoSize = true;
            this.lb_data_payment.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_payment.ForeColor = System.Drawing.Color.Black;
            this.lb_data_payment.Location = new System.Drawing.Point(300, 360);
            this.lb_data_payment.Name = "lb_data_payment";
            this.lb_data_payment.Size = new System.Drawing.Size(53, 25);
            this.lb_data_payment.TabIndex = 43;
            this.lb_data_payment.Text = "Null";
            // 
            // lb_sname
            // 
            this.lb_sname.AutoSize = true;
            this.lb_sname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sname.Location = new System.Drawing.Point(130, 280);
            this.lb_sname.Name = "lb_sname";
            this.lb_sname.Size = new System.Drawing.Size(173, 25);
            this.lb_sname.TabIndex = 99;
            this.lb_sname.Text = "Student Name:";
            // 
            // lb_data_stname
            // 
            this.lb_data_stname.AutoSize = true;
            this.lb_data_stname.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_stname.Location = new System.Drawing.Point(300, 280);
            this.lb_data_stname.Name = "lb_data_stname";
            this.lb_data_stname.Size = new System.Drawing.Size(53, 25);
            this.lb_data_stname.TabIndex = 45;
            this.lb_data_stname.Text = "Null";
            // 
            // btn_accept_payment
            // 
            this.btn_accept_payment.BackColor = System.Drawing.Color.Lime;
            this.btn_accept_payment.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_accept_payment.Location = new System.Drawing.Point(214, 626);
            this.btn_accept_payment.Name = "btn_accept_payment";
            this.btn_accept_payment.Size = new System.Drawing.Size(193, 43);
            this.btn_accept_payment.TabIndex = 3;
            this.btn_accept_payment.Text = "&Accept Payment";
            this.btn_accept_payment.UseVisualStyleBackColor = false;
            this.btn_accept_payment.Click += new System.EventHandler(this.btn_accept_payment_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_search.Location = new System.Drawing.Point(323, 60);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(301, 33);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // grid_paid
            // 
            this.grid_paid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grid_paid.BackgroundColor = System.Drawing.Color.Green;
            this.grid_paid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_paid.Location = new System.Drawing.Point(658, 36);
            this.grid_paid.Name = "grid_paid";
            this.grid_paid.Size = new System.Drawing.Size(541, 288);
            this.grid_paid.TabIndex = 101;
            this.grid_paid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_paid_CellClick);
            // 
            // grid_unpaid
            // 
            this.grid_unpaid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grid_unpaid.BackgroundColor = System.Drawing.Color.Red;
            this.grid_unpaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_unpaid.Location = new System.Drawing.Point(658, 366);
            this.grid_unpaid.Name = "grid_unpaid";
            this.grid_unpaid.Size = new System.Drawing.Size(541, 288);
            this.grid_unpaid.TabIndex = 102;
            this.grid_unpaid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_unpaid_CellClick);
            // 
            // lbl_data_course
            // 
            this.lbl_data_course.AutoSize = true;
            this.lbl_data_course.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_data_course.Location = new System.Drawing.Point(300, 320);
            this.lbl_data_course.Name = "lbl_data_course";
            this.lbl_data_course.Size = new System.Drawing.Size(53, 25);
            this.lbl_data_course.TabIndex = 103;
            this.lbl_data_course.Text = "Null";
            // 
            // lbl_selected
            // 
            this.lbl_selected.AutoSize = true;
            this.lbl_selected.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_selected.Location = new System.Drawing.Point(109, 320);
            this.lbl_selected.Name = "lbl_selected";
            this.lbl_selected.Size = new System.Drawing.Size(194, 25);
            this.lbl_selected.TabIndex = 104;
            this.lbl_selected.Text = "Selected Course:";
            // 
            // lbl_paid
            // 
            this.lbl_paid.AutoSize = true;
            this.lbl_paid.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_paid.ForeColor = System.Drawing.Color.Green;
            this.lbl_paid.Location = new System.Drawing.Point(899, 8);
            this.lbl_paid.Name = "lbl_paid";
            this.lbl_paid.Size = new System.Drawing.Size(148, 25);
            this.lbl_paid.TabIndex = 106;
            this.lbl_paid.Text = "Paid Courses";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(899, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 107;
            this.label1.Text = "Unpaid Courses";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_amount.Location = new System.Drawing.Point(312, 576);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(161, 33);
            this.txt_amount.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(105, 579);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 109;
            this.label2.Text = "Payment Amount:";
            // 
            // btn_get_half
            // 
            this.btn_get_half.BackColor = System.Drawing.Color.SeaShell;
            this.btn_get_half.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_half.Location = new System.Drawing.Point(395, 489);
            this.btn_get_half.Name = "btn_get_half";
            this.btn_get_half.Size = new System.Drawing.Size(36, 25);
            this.btn_get_half.TabIndex = 110;
            this.btn_get_half.Text = "1/2";
            this.btn_get_half.UseVisualStyleBackColor = false;
            this.btn_get_half.Click += new System.EventHandler(this.btn_get_half_Click);
            // 
            // btn_get_16
            // 
            this.btn_get_16.BackColor = System.Drawing.Color.SeaShell;
            this.btn_get_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_16.Location = new System.Drawing.Point(437, 489);
            this.btn_get_16.Name = "btn_get_16";
            this.btn_get_16.Size = new System.Drawing.Size(36, 25);
            this.btn_get_16.TabIndex = 111;
            this.btn_get_16.Text = "1/6";
            this.btn_get_16.UseVisualStyleBackColor = false;
            this.btn_get_16.Click += new System.EventHandler(this.btn_get_16_Click);
            // 
            // btn_get_full
            // 
            this.btn_get_full.BackColor = System.Drawing.Color.SeaShell;
            this.btn_get_full.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_full.Location = new System.Drawing.Point(395, 526);
            this.btn_get_full.Name = "btn_get_full";
            this.btn_get_full.Size = new System.Drawing.Size(78, 33);
            this.btn_get_full.TabIndex = 112;
            this.btn_get_full.Text = "Full";
            this.btn_get_full.UseVisualStyleBackColor = false;
            this.btn_get_full.Click += new System.EventHandler(this.btn_get_full_Click);
            // 
            // lb_data_debt
            // 
            this.lb_data_debt.AutoSize = true;
            this.lb_data_debt.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_data_debt.Location = new System.Drawing.Point(300, 490);
            this.lb_data_debt.Name = "lb_data_debt";
            this.lb_data_debt.Size = new System.Drawing.Size(53, 25);
            this.lb_data_debt.TabIndex = 113;
            this.lb_data_debt.Text = "Null";
            // 
            // lb_student_debt
            // 
            this.lb_student_debt.AutoSize = true;
            this.lb_student_debt.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_student_debt.Location = new System.Drawing.Point(145, 490);
            this.lb_student_debt.Name = "lb_student_debt";
            this.lb_student_debt.Size = new System.Drawing.Size(161, 25);
            this.lb_student_debt.TabIndex = 114;
            this.lb_student_debt.Text = "Student Debt:";
            // 
            // grid_students
            // 
            this.grid_students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.grid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_students.Location = new System.Drawing.Point(110, 99);
            this.grid_students.Name = "grid_students";
            this.grid_students.Size = new System.Drawing.Size(514, 161);
            this.grid_students.TabIndex = 1000000;
            this.grid_students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_students_CellClick);
            // 
            // lb_course_fee
            // 
            this.lb_course_fee.AutoSize = true;
            this.lb_course_fee.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_course_fee.ForeColor = System.Drawing.Color.Black;
            this.lb_course_fee.Location = new System.Drawing.Point(300, 421);
            this.lb_course_fee.Name = "lb_course_fee";
            this.lb_course_fee.Size = new System.Drawing.Size(53, 25);
            this.lb_course_fee.TabIndex = 1000001;
            this.lb_course_fee.Text = "Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(163, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 25);
            this.label4.TabIndex = 1000002;
            this.label4.Text = "Course Fee:";
            // 
            // btn_half_16
            // 
            this.btn_half_16.BackColor = System.Drawing.Color.SeaShell;
            this.btn_half_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_half_16.Location = new System.Drawing.Point(437, 421);
            this.btn_half_16.Name = "btn_half_16";
            this.btn_half_16.Size = new System.Drawing.Size(36, 25);
            this.btn_half_16.TabIndex = 1000004;
            this.btn_half_16.Text = "1/6";
            this.btn_half_16.UseVisualStyleBackColor = false;
            this.btn_half_16.Click += new System.EventHandler(this.btn_half_16_Click);
            // 
            // btn_half_fee
            // 
            this.btn_half_fee.BackColor = System.Drawing.Color.SeaShell;
            this.btn_half_fee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_half_fee.Location = new System.Drawing.Point(395, 421);
            this.btn_half_fee.Name = "btn_half_fee";
            this.btn_half_fee.Size = new System.Drawing.Size(36, 25);
            this.btn_half_fee.TabIndex = 1000003;
            this.btn_half_fee.Text = "1/2";
            this.btn_half_fee.UseVisualStyleBackColor = false;
            this.btn_half_fee.Click += new System.EventHandler(this.btn_half_fee_Click);
            // 
            // accept_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_half_16);
            this.Controls.Add(this.btn_half_fee);
            this.Controls.Add(this.lb_course_fee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grid_students);
            this.Controls.Add(this.lb_data_debt);
            this.Controls.Add(this.lb_student_debt);
            this.Controls.Add(this.btn_get_full);
            this.Controls.Add(this.btn_get_16);
            this.Controls.Add(this.btn_get_half);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_paid);
            this.Controls.Add(this.lbl_data_course);
            this.Controls.Add(this.lbl_selected);
            this.Controls.Add(this.grid_unpaid);
            this.Controls.Add(this.grid_paid);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_accept_payment);
            this.Controls.Add(this.lb_data_stname);
            this.Controls.Add(this.lb_sname);
            this.Controls.Add(this.lb_data_payment);
            this.Controls.Add(this.lb_payment_status);
            this.Controls.Add(this.lb_choose_student);
            this.Name = "accept_payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accept Payment";
            this.Load += new System.EventHandler(this.accept_payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_paid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_unpaid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_payment_status;
        private System.Windows.Forms.Label lb_choose_student;
        private System.Windows.Forms.Label lb_data_payment;
        private System.Windows.Forms.Label lb_sname;
        private System.Windows.Forms.Label lb_data_stname;
        private System.Windows.Forms.Button btn_accept_payment;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView grid_paid;
        private System.Windows.Forms.DataGridView grid_unpaid;
        private System.Windows.Forms.Label lbl_data_course;
        private System.Windows.Forms.Label lbl_selected;
        private System.Windows.Forms.Label lbl_paid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_get_half;
        private System.Windows.Forms.Button btn_get_16;
        private System.Windows.Forms.Button btn_get_full;
        private System.Windows.Forms.Label lb_data_debt;
        private System.Windows.Forms.Label lb_student_debt;
        private System.Windows.Forms.DataGridView grid_students;
        private System.Windows.Forms.Label lb_course_fee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_half_16;
        private System.Windows.Forms.Button btn_half_fee;
    }
}