using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ModelStud;
namespace ModelMVP
{
    public class Model : IModel
    {

        public IRepository<Student> repository { get; set; }
        public Model(IRepository<Student> repository)
        {
            
            this.repository = repository;
        }

        public event EventHandler<StudentArgs> EventStudentAddModel = delegate { };
        public event EventHandler<StudentArgs> EventStudentRemoveModel = delegate{ };
        public event EventHandler<List<List<string>>> EventStudentLoadModel = delegate { };
        public event EventHandler<List<string>> EventStudentGetSpecialieties = delegate { };

        public void AddStudent(Student student)
        {
            //Students.Add(student);
            repository.Create(student);
            EventStudentAddModel(this, new StudentArgs(student));
        }

        public void RemoveStudent(int id)
        {
            Student student = repository.GetItem(id);
            repository.delete(id);

            EventStudentRemoveModel(this, new StudentArgs(student));
        }

        public void LoadStudents()
        {
            List<List<string>> students = new List<List<string>>();
            foreach(var i in repository.GetAll())
            {
                students.Add(new List<string>() { Convert.ToString(i.ID), i.Name , i.Speciality,i.Group });
            }
            EventStudentLoadModel(this, students);
        }

        public void GetSpecialieties()
        {
            
            List<string> specs = (from i in repository.GetAll() select i.Speciality).ToList() ;
            EventStudentGetSpecialieties(this, specs);
        }
    }
}