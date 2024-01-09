using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelMVP;
using Ninject;

using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelMVP;
using ModelStud;
using Ninject;
using Presenter;
using SHARED;

namespace Lab_5_AIS
{
    public partial class MainView : Form, IView
    {
        public Histagramm page2;
      
        private PresenterMVP presenter { get; set; }
        

        public MainView()
        {
            InitializeComponent();
            presenter = new PresenterMVP(this);

        }
        
        public event EventHandler<List<string>> EventStudentAddView = delegate { };
        public event EventHandler<int> EventStudentRemoveView = delegate { };
        public event EventHandler<List<List<string>>> EventStudentLoadView = delegate { };
        public event EventHandler EventGetSpecialietesView = delegate { };


        public void AddStudent(List<string> student)
        {
            Student_listbox.Items.Add(student[0] + " " + student[1] + " " + student[2] + " " + student[3]);

        }
        public void RemoveStudent(int student)
        {

            Student_listbox.Items.Remove(Student_listbox.SelectedItem);

            
        }
        private void Add_student_Click(object sender, EventArgs e)
        {
            if (FIO_input.Text != "" && Speciality_input.Text != "" && Group_input.Text != "" && FIO_input.Text.Split(' ').Length >= 3)
            {
                
                
                List<string> student = new List<string>() { FIO_input.Text, Speciality_input.Text, Group_input.Text };
        
                EventStudentAddView(this, student);
            
            }
            else
            {
                MessageBox.Show("Incorrect data, please try againg.");
            }
        }
        public void LoadStudents(List<List<string>> students)
        {
            Console.WriteLine(students.Count);

            foreach(var student in students) { 
                Student_listbox.Items.Add(student[0] + " " + student[1] + " " + student[2] + " " + student[3]);
        
            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (Student_listbox.SelectedItem != null)
            {
                int id = int.Parse(Student_listbox.SelectedItem.ToString().Split(' ')[0]);
                EventStudentRemoveView(this, id);

            }
            else
            {
                MessageBox.Show("Please choose your person");
            }

        }

        private void MainVeiw_Load(object sender, EventArgs e)
        {
            EventStudentLoadView(this, new List<List<string>>());
        }

       

        public void ShowHist(List<string> specs)
        {

            page2 = new Histagramm(specs);
            page2.Show();
        }

        private void Show_gistagramm_Click(object sender, EventArgs e)
        {
            EventGetSpecialietesView(this, null);

        }

        private void Add_student_BIGBTN_Click(object sender, EventArgs e)
        {
            var form = new AddPage();
            form.Show();
            this.Hide();
        }
    }
}








// public delegate void StringHandler(object sender, StringArg ar); 
// public class StringArg : EventArgs //аргумент события 
// { 
//     public string str; 
//     public StringArg(string s) 
//     { 
//         str = s; 
//     } 
// } 
// public class StringEvent //класс события 
// { 
//     public event StringHandler evt; 
//     public void OnStringEvt(string s) 
//     { 
//         if (evt != null) 
//             evt(this, new StringArg(s)); 
//     } 
// } 