using System.ComponentModel;

namespace Lab_5_AIS
{
    partial class AddPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.Fio_input = new System.Windows.Forms.TextBox();
            this.Speciality_input = new System.Windows.Forms.TextBox();
            this.Group_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fio_input
            // 
            this.Fio_input.Location = new System.Drawing.Point(77, 93);
            this.Fio_input.Name = "Fio_input";
            this.Fio_input.Size = new System.Drawing.Size(210, 22);
            this.Fio_input.TabIndex = 0;
            // 
            // Speciality_input
            // 
            this.Speciality_input.Location = new System.Drawing.Point(77, 198);
            this.Speciality_input.Name = "Speciality_input";
            this.Speciality_input.Size = new System.Drawing.Size(210, 22);
            this.Speciality_input.TabIndex = 1;
            // 
            // Group_input
            // 
            this.Group_input.Location = new System.Drawing.Point(77, 311);
            this.Group_input.Name = "Group_input";
            this.Group_input.Size = new System.Drawing.Size(210, 22);
            this.Group_input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(77, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(77, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Специальность";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(78, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Группа";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(115, 375);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(135, 35);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(364, 459);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Group_input);
            this.Controls.Add(this.Speciality_input);
            this.Controls.Add(this.Fio_input);
            this.Name = "AddPage";
            this.Text = "AddPage";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button AddButton;

        private System.Windows.Forms.TextBox Fio_input;
        private System.Windows.Forms.TextBox Speciality_input;
        private System.Windows.Forms.TextBox Group_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        #endregion
    }
}