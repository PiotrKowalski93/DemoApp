using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataModel.Models
{
    public class Order
    {
        /// <summary>
        /// Client's Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Client's Localizaiton
        /// </summary>
        string Localization { get; set; }

        /// <summary>
        /// Client's phone number
        /// </summary>
        string PhoneNumber { get; set; }
    }
}
