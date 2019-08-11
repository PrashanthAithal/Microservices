using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TND_Microservice.Models
{
    public class Training
    {
        public int ID { get; set; }
        public string TrainingName { get; set; }
        public string TrainingDate { get; set; }
        public string TrainerName { get; set; }
        public int FeedbackID { get; set; }
    }
}
