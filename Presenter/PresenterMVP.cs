using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelMVP;
using ModelStud;
using SHARED;
using Ninject;

namespace Presenter
{
    public class PresenterMVP
    {
       private IView hist;
        private IView view;
        private IModel model;
        IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
        Model ninjectmodel;
        
        /// <summary>
        /// Создание экземпляра модели и подписка на событие
        /// </summary>
        /// <param name="studentView"></param>
        public PresenterMVP(IView studentView)
        {
            ninjectmodel = ninjectKernel.Get<Model>();
            model = ninjectmodel;
            view = studentView;
            
            view.EventStudentAddView += view_StudentAdd;
            view.EventStudentRemoveView += view_StudentRemove;
            view.EventStudentLoadView += view_LoadStudents;
            view.EventGetSpecialietesView += view_GetSpecialities;
            model.EventStudentGetSpecialieties += model_GetSpecialities;
            model.EventStudentRemoveModel += model_StudentRemove;
            model.EventStudentAddModel += model_StudentAdd;
            model.EventStudentLoadModel += model_LoadStudents;
        }


        /// <summary>
        /// Обработчик события. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void model_StudentAdd(object sender, StudentArgs e)
        {
            List<string> student = new List<string>() {Convert.ToString(e.student.ID), e.student.Name, e.student.Speciality, e.student.Group };
            view.AddStudent(student);
        }
        public void view_StudentAdd(object sender, List<string> e)
        {
            Student s = new Student(e[0], e[1], e[2]);
            model.AddStudent(s);
        }
        public void view_StudentRemove(object sender, int e)
        {
            model.RemoveStudent(e);
        }
        public void model_StudentRemove(object sender,  StudentArgs e)
        {
            
            view.RemoveStudent(e.student.ID);
        }
        public void view_LoadStudents(object sender, List<List<string>> students)
        {
            model.LoadStudents();
        }
        public void model_LoadStudents(object sender, List<List<string>> students)
        {

            view.LoadStudents(students);
        }
        public void model_GetSpecialities(object sender, List<string> specs)
        {
            view.ShowHist(specs);
        }
        public void view_GetSpecialities(object sender, EventArgs e)
        {
            model.GetSpecialieties();
        }
    }
}