﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TND_Microservice.DBContexts;

namespace TND_Microservice.Migrations
{
    [DbContext(typeof(TrainingFeedbackContext))]
    partial class TrainingFeedbackContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TND_Microservice.Models.Feedback", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("EmployeeName");

                    b.Property<string>("FeedbackDate");

                    b.HasKey("ID");

                    b.ToTable("Feedbacks");

                    b.HasData(
                        new { ID = 1001, Description = "Microservice Training was very informative.", EmployeeName = "employee_1", FeedbackDate = "27 July 2019" },
                        new { ID = 1002, Description = "Microservice Training was very informative.", EmployeeName = "employee_1", FeedbackDate = "27 July 2019" },
                        new { ID = 1003, Description = "Microservice Training was very informative.", EmployeeName = "employee_1", FeedbackDate = "27 July 2019" }
                    );
                });

            modelBuilder.Entity("TND_Microservice.Models.Training", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeedbackID");

                    b.Property<string>("TrainerName");

                    b.Property<string>("TrainingDate");

                    b.Property<string>("TrainingName");

                    b.HasKey("ID");

                    b.ToTable("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}