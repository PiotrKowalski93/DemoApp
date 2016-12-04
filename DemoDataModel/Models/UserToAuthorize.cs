using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataModel.Models
{
    public class UserToAuthorize
    {
        /// <summary>
        /// User's Login
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// User's encrypted password
        /// </summary>
        public string Password { get; set; }
    }
}
