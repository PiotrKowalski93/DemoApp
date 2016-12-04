using DemoDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebAPI.Repositories
{
    public interface IUserRepository
    {
        bool CheckIfUserIsAuthorized(UserToAuthorize user);
    }
}
