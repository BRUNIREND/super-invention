using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;
using System.Windows.Forms;
using ModelMVP;

namespace Lab_5_AIS
{
    public partial class AddPage : Form, IView
    {
        public MainView form; 
        public AddPage()
        {
            InitializeComponent();
        }
        public event EventHandler<List<string>> EventStudentAddView = delegate { };
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Fio_input.Text != "" && Speciality_input.Text != "" && Group_input.Text != "" && Fio_input.Text.Split(' ').Length >= 3)
            {
                
                
                List<string> student = new List<string>() { Fio_input.Text, Speciality_input.Text, Group_input.Text };
        
                EventStudentAddView(this, student);
                form = new MainView();
                form.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Incorrect data, please try againg.");
            }
        }
        // public void AddStudent(List<string> student)
        // {
        //     Student_listbox.Items.Add(student[0] + " " + student[1] + " " + student[2] + " " + student[3]);
        //
        // }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}