using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataModel.Models
{
    public class Message
    {
        /// <summary>
        /// Taxi Driver Licence number 
        /// </summary>
        string From { get; set; }

        /// <summary>
        /// Date of the message
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Content of the message
        /// </summary>
        string Content { get; set; }
    }
}
