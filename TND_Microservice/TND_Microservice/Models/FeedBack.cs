using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TND_Microservice.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public string FeedbackDate { get; set; }
        public string EmployeeName { get; set; }
    }
}
