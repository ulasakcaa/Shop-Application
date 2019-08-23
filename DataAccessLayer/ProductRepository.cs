using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository : BaseRepository<Products>
    {
        public ProductRepository():base()
        {
           
        }
        public override void Update(Products entity)
        {
           
            var updateEdilecek = db.Set<Products>().Where(c => c.Id == entity.Id).FirstOrDefault();

            updateEdilecek.Name = entity.Name;
            updateEdilecek.Price = entity.Price;
            updateEdilecek.productCode = entity.productCode;
            updateEdilecek.stocks = entity.stocks;
            updateEdilecek.categoryId = entity.categoryId;

            db.SaveChanges();
        }

       
    }
}
