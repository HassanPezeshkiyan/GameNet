using GameNet.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNet.DataLayer.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly GameNetEntities db;
        public UserRepository(GameNetEntities context) {
            db = context;
        }
        public User GetUserByUserName(string userName) {
            return db.Users.Where(n => n.UserName == userName).FirstOrDefault();

        }
    }
}
