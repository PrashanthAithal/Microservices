using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TND_Microservice.Models;

namespace TND_Microservice.DBContexts
{
    public class TrainingFeedbackContext : DbContext
    {
        public TrainingFeedbackContext(DbContextOptions<TrainingFeedbackContext> options) : base(options) { }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>().HasData(
                new Feedback
                {
                    ID = 1001,
                    Description = "Microservice Training was very informative.",
                    EmployeeName = "employee_1",
                    FeedbackDate = DateTime.Now.Date.ToLongDateString()
                },
                new Feedback
                {
                    ID = 1002,
                    Description = "Microservice Training was very informative.",
                    EmployeeName = "employee_1",
                    FeedbackDate = DateTime.Now.Date.ToLongDateString()
                },
                new Feedback
                {
                    ID = 1003,
                    Description = "Microservice Training was very informative.",
                    EmployeeName = "employee_1",
                    FeedbackDate = DateTime.Now.Date.ToLongDateString()
                }
                );
        }
    }
}