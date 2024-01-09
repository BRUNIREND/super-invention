using ModelStud;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace DataAccessLayer
{
     public class DapperFrameWork<T> : IRepository<T> where T : Student, IDomainObject, new()
    {
        static string conectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MVPDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
        IDbConnection db = new SqlConnection(conectionString);
        /// <summary>
        /// добавление студента в БД
        /// </summary>
        /// <param name="item"></param>
        public void Create(T item)
        {
            var sqlQuery = "INSERT INTO Students (Name, Speciality, [Group]) VALUES (@Name, @Speciality, @Group);" +
                "SELECT CAST(SCOPE_IDENTITY() as int)";
            int studentId = db.Query<int>(sqlQuery, item).FirstOrDefault();
            item.ID = studentId;
        }
        /// <summary>
        /// Удаление студента из БД
        /// </summary>
        /// <param name="id"></param>
        public void delete(int id)
        {
            var sqlquery = "DELETE FROM Students WHERE ID = @ID";
            db.Execute(sqlquery, new { id });
        }

        /// <summary>
        /// Получение всех студентов в виде списка из БД
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return db.Query<T>("SELECT * FROM Students").ToList();
        }
        /// <summary>
        /// Получение одного студента по его ID из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetItem(int id)
        {
            return db.Query<T>("SELECT * FROM Students WHERE ID = @ID", new { id }).FirstOrDefault();
        }
        /// <summary>
        /// Обновление данных о студенте в БД
        /// </summary>
        /// <param name="item"></param>
        public void Update(T item)
        {
            var sqlquery = "UPDATE Students SET Name = @Name, Speciality = @Speciality, [Group] = @Group WHERE ID = @ID";
            db.Execute(sqlquery, item);
        }
    }
}