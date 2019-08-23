using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CategoryRepository: BaseRepository<Categories>
    {

        public CategoryRepository():base()
        {
           
        }
        public override void Update(Categories entity)
        {
           
            var updateEdilecek = db.Set<Categories>().Where(c => c.Id == entity.Id).FirstOrDefault();

            updateEdilecek.Name = entity.Name;
            updateEdilecek.Description = entity.Description;
            updateEdilecek.CatOrder = entity.CatOrder;
           

            db.SaveChanges();
        }

      
    }
}
