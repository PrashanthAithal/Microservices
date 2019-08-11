using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TND_Microservice.Models;

namespace TND_Microservice.Repository
{
    public interface ITrainingFeedbackRepository
    {
        IEnumerable<Training> GetTrainings();
        Training GetTrainingByID(int TrainingID);
        void InsertTraining(Training training);
        void UpdateTraining(Training training);
        void DeleteTraining(int TrainingID);
        void SaveChanges();
    }

}
