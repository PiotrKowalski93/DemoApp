using DemoDataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoDataModel.Models;

namespace DemoWebAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private GiveMeARideDemoEntities _context;

        public UserRepository(GiveMeARideDemoEntities context)
        {
            _context = context;
        }

        public bool CheckIfUserIsAuthorized(UserToAuthorize user)
        {
            var obj = _context.Users.Where(u => u.Login == user.Login).SingleOrDefault();
            if(obj.Password == user.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}