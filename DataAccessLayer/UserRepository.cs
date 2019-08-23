using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UserRepository: BaseRepository<Users>
    {
        public UserRepository():base()
        {
           
        }
        public override void Update(Users entity)
        {
           
            Users defaultUser=db.Users.Where(c => c.Id == entity.Id).FirstOrDefault();
            defaultUser.Password = entity.Password;
            defaultUser.UserName = entity.UserName;
            defaultUser.FullName = entity.FullName;
            defaultUser.Credit = entity.Credit;
            db.SaveChanges();
           
        }

       

        
    }
}
