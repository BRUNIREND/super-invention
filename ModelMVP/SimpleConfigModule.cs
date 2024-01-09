using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using ModelStud;
using Ninject.Modules;

namespace ModelMVP
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            // Bind<IRepository<Student>>().To<EntityFrameWork<Student>>().InSingletonScope(); // будет создан и использован только один экземпляр EntityRepository (Dapper) при каждом запросе к Students
            Bind<IRepository<Student>>().To<DapperFrameWork<Student>>().InSingletonScope();
        }
    }
}