namespace Lab_5_AIS
{
    partial class MainView
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
            this.label1 = new System.Windows.Forms.Label();
            this.Student_listbox = new System.Windows.Forms.ListBox();
            this.Add_student = new System.Windows.Forms.Button();
            this.Delete_student = new System.Windows.Forms.Button();
            this.Show_gistagramm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FIO_input = new System.Windows.Forms.TextBox();
            this.Speciality_input = new System.Windows.Forms.TextBox();
            this.Group_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(0, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Decanat Pro Max 2023";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Student_listbox
            // 
            this.Student_listbox.FormattingEnabled = true;
            this.Student_listbox.ItemHeight = 16;
            this.Student_listbox.Location = new System.Drawing.Point(20, 102);
            this.Student_listbox.Name = "Student_listbox";
            this.Student_listbox.Size = new System.Drawing.Size(330, 228);
            this.Student_listbox.TabIndex = 1;
            // 
            // Add_student
            // 
            this.Add_student.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_student.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add_student.Location = new System.Drawing.Point(550, 317);
            this.Add_student.Name = "Add_student";
            this.Add_student.Size = new System.Drawing.Size(155, 32);
            this.Add_student.TabIndex = 2;
            this.Add_student.Text = "Добавить студента";
            this.Add_student.UseVisualStyleBackColor = true;
            this.Add_student.Click += new System.EventHandler(this.Add_student_Click);
            // 
            // Delete_student
            // 
            this.Delete_student.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_student.Location = new System.Drawing.Point(195, 336);
            this.Delete_student.Name = "Delete_student";
            this.Delete_student.Size = new System.Drawing.Size(155, 32);
            this.Delete_student.TabIndex = 3;
            this.Delete_student.Text = "Удалить студента";
            this.Delete_student.UseVisualStyleBackColor = true;
            this.Delete_student.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Show_gistagramm
            // 
            this.Show_gistagramm.BackColor = System.Drawing.Color.LightGray;
            this.Show_gistagramm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Show_gistagramm.Location = new System.Drawing.Point(22, 374);
            this.Show_gistagramm.Name = "Show_gistagramm";
            this.Show_gistagramm.Size = new System.Drawing.Size(328, 38);
            this.Show_gistagramm.TabIndex = 4;
            this.Show_gistagramm.Text = "Вывести гистограмму";
            this.Show_gistagramm.UseVisualStyleBackColor = false;
            this.Show_gistagramm.Click += new System.EventHandler(this.Show_gistagramm_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(422, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите ФИО";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(422, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Введите специальность";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(422, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введиет группу";
            // 
            // FIO_input
            // 
            this.FIO_input.Location = new System.Drawing.Point(422, 102);
            this.FIO_input.Name = "FIO_input";
            this.FIO_input.Size = new System.Drawing.Size(283, 22);
            this.FIO_input.TabIndex = 8;
            // 
            // Speciality_input
            // 
            this.Speciality_input.Location = new System.Drawing.Point(422, 193);
            this.Speciality_input.Name = "Speciality_input";
            this.Speciality_input.Size = new System.Drawing.Size(283, 22);
            this.Speciality_input.TabIndex = 9;
            // 
            // Group_input
            // 
            this.Group_input.Location = new System.Drawing.Point(422, 264);
            this.Group_input.Name = "Group_input";
            this.Group_input.Size = new System.Drawing.Size(283, 22);
            this.Group_input.TabIndex = 10;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(782, 450);
            this.Controls.Add(this.Group_input);
            this.Controls.Add(this.Speciality_input);
            this.Controls.Add(this.FIO_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Show_gistagramm);
            this.Controls.Add(this.Delete_student);
            this.Controls.Add(this.Add_student);
            this.Controls.Add(this.Student_listbox);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainVeiw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FIO_input;
        private System.Windows.Forms.TextBox Speciality_input;
        private System.Windows.Forms.TextBox Group_input;

        private System.Windows.Forms.Button Show_gistagramm;

        private System.Windows.Forms.ListBox Student_listbox;
        private System.Windows.Forms.Button Add_student;
        private System.Windows.Forms.Button Delete_student;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}