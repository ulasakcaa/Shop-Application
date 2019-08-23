
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class BaseRepository<T> where T: class,IEntityBase
    {
        protected myShopEntities db;

        public BaseRepository()
        {
            db= new myShopEntities();
        }

        public virtual List<T> List()
        {
            List<T> result = db.Set<T>().ToList();


            return result;
        }

        public virtual void Add(T entity)
        {
          
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }

        public virtual void Update(T entity)
        {
           
        }

        public virtual void Delete(int id)
        {
            
            var entity = db.Set<T>().Where(c => c.Id == id).FirstOrDefault();
            db.Set<T>().Remove(entity);
            db.SaveChanges();

        }

    }
}
