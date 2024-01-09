using ModelStud;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public Context() : base("MVPDataBase") { }
    }
    public class EntityFrameWork<T> : IRepository<T> where T : class, IDomainObject, new()
    {
       
    
        private Context Context;
        private DbSet<T> dbSet;
        public EntityFrameWork()
        {
            Context = new Context();

            dbSet = Context.Set<T>();


        }
        /// <summary>
        /// добавление студента в БД
        /// </summary>
        /// <param name="item"></param>
        public void Create(T item)
        {
            dbSet.Add(item);

            Context.SaveChanges();
        }
        /// <summary>
        /// Удаление студента из БД
        /// </summary>
        /// <param name="id"></param>
        public void delete(int id)
        {
            T todel = dbSet.Find(id);

            dbSet.Remove(todel);
            Context.SaveChanges();
        }
        private bool _disposed = false;
        /// <summary>
        /// Получение всех студентов в виде списка из БД
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        /// <summary>
        /// Получение одного студента по его ID из БД
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetItem(int id)
        {
            return dbSet.Find(id);
        }
        /// <summary>
        /// Обновление данных о студенте в БД
        /// </summary>
        /// <param name="item"></param>
        public void Update(T item)
        {
            Context.Entry(item).State = EntityState.Modified;
            Context.SaveChanges();
        }
    }
}