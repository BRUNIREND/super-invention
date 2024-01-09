using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelStud;
namespace SHARED
{
    public interface IView
    {
        /// <summary>
        /// Метод добавления студента
        /// </summary>
        /// <param name="studentsINFO"></param>
        void AddStudent(List<string> studentsINFO);
        /// <summary>
        /// Метод удаления студента
        /// </summary>
        /// <param name="id">ID по которому будет искаться и удаляться студент</param>
        void RemoveStudent(int id);
        /// <summary>
        /// Метод для загрузки студента в форму
        /// </summary>
        /// <param name="students">Список студентов</param>
        void LoadStudents(List<List<string>> students);
        /// <summary>
        /// Метод формирования гистаграммы
        /// </summary>
        /// <param name="specs">Список специальностей</param>
        void ShowHist(List<string> specs);
        
        event EventHandler<List<string>> EventStudentAddView;
        event EventHandler<int> EventStudentRemoveView;
        event EventHandler<List<List<string>>> EventStudentLoadView;
        event EventHandler EventGetSpecialietesView;
    }
}