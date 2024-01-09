using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public interface IRepository <T> where T : class
    {
        /// <summary>
        /// Получение всех студентов в виде списка из БД
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
        T GetItem(int id);
        /// <summary>
        /// добавление студента в БД
        /// </summary>
        /// <param name="item"></param>
        void Create(T item);
        /// <summary>
        /// Обновление данных о студенте в БД
        /// </summary>
        /// <param name="item"></param>
        void Update(T item);
        /// <summary>
        /// Удаление студента из БД
        /// </summary>
        /// <param name="id"></param>
        void delete(int id);

    }
}