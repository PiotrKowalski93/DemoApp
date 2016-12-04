using DemoWebAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoDataModel.Models;

namespace DemoWebAPI.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CheckIfUserIsAuthorized(UserToAuthorize user)
        {
           return _userRepository.CheckIfUserIsAuthorized(user);
        }
    }
}