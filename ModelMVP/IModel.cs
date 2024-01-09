using ModelStud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ModelMVP
{
    public interface IModel
    {
        /// <summary>
        /// Метод добавления объекта студента
        /// </summary>
        /// <param name="student">Объект студента</param>
        void AddStudent(Student student);
        /// <summary>
        /// Событие добавление студента в модель
        /// </summary>
        event EventHandler<StudentArgs> EventStudentAddModel;
        
        /// <summary>
        /// Удаление студента
        /// </summary>
        /// <param name="id">Id по которому ищется и удаляется студент</param>
        void RemoveStudent(int id);
        /// <summary>
        /// Событие удаления студента из модели
        /// </summary>
        event EventHandler<StudentArgs> EventStudentRemoveModel;
        /// <summary>
        /// Загрузка студента
        /// </summary>
        void LoadStudents();
        /// <summary>
        /// Событие загрузки студента из модели
        /// </summary>
        event EventHandler<List<List<string>>> EventStudentLoadModel;
        /// <summary>
        /// Получение списка студентов
        /// </summary>
        void GetSpecialieties();
        /// <summary>
        /// Событие передачи списка студентов
        /// </summary>
        event EventHandler<List<string>> EventStudentGetSpecialieties;  
    }
}