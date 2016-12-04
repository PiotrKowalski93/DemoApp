using DemoDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebAPI.Services
{
    public interface IUserService
    {
        bool CheckIfUserIsAuthorized(UserToAuthorize user);
    }
}
