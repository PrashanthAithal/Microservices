using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TND_Microservice.Models;
using TND_Microservice.Repository;
using System.Transactions;

namespace TND_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingFeedbackController : ControllerBase
    {
        private readonly ITrainingFeedbackRepository _trainingFeedbackRepository;
        public TrainingFeedbackController(ITrainingFeedbackRepository trainingFeedbackRepository)
        {
            _trainingFeedbackRepository = trainingFeedbackRepository;
        }
        // GET: api/TrainingFeedback
        [HttpGet]
        public IActionResult Get()
        {
            var trainings = _trainingFeedbackRepository.GetTrainings();
            return new OkObjectResult(trainings);
        }

        // GET: api/TrainingFeedback/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            var product = _trainingFeedbackRepository.GetTrainingByID(id);
            return new OkObjectResult(product);
        }

        // POST: api/TrainingFeedback
        [HttpPost]
        public IActionResult Post([FromBody] Training training)
        {
            using (var scope = new TransactionScope())
            {
                _trainingFeedbackRepository.InsertTraining(training);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = training.ID }, training);
            }
        }

        // PUT: api/TrainingFeedback/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Training training)
        {
            if (training != null)
            {
                using (var scope =new TransactionScope())
                {
                    _trainingFeedbackRepository.UpdateTraining(training);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _trainingFeedbackRepository.DeleteTraining(id);
            return new OkResult();
        }
    }
}
