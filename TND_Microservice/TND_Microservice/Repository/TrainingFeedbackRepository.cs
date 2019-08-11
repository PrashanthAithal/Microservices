using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TND_Microservice.Models;
using Microsoft.EntityFrameworkCore;
using TND_Microservice.DBContexts;

namespace TND_Microservice.Repository
{
    public class TrainingFeedbackRepository : ITrainingFeedbackRepository
    {
        private readonly TrainingFeedbackContext _dBContext;

        public TrainingFeedbackRepository(TrainingFeedbackContext dbContext)
        {
            _dBContext = dbContext;
        }
        public void DeleteTraining(int TrainingID)
        {
            var trainingObject = _dBContext.Trainings.Find(TrainingID);
            _dBContext.Trainings.Remove(trainingObject);
            SaveChanges();
        }

        public Training GetTrainingByID(int TrainingID)
        {
            return _dBContext.Trainings.Find(TrainingID);
        }

        public IEnumerable<Training> GetTrainings()
        {
            return _dBContext.Trainings.ToList();
        }

        public void InsertTraining(Training training)
        {
            _dBContext.Add(training);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _dBContext.SaveChanges();
        }

        public void UpdateTraining(Training training)
        {
            _dBContext.Entry(training).State = EntityState.Modified;
            SaveChanges();
        }
    }
}
