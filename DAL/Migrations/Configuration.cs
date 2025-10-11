namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.FTContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.FTContext context)
        {
            /*

            for (int i = 1; i <= 10; i++)
            {
                context.Users.AddOrUpdate(new DAL.Models.User
                {
                    Uname = "user" + i,                           // unique username
                    Name = "User " + i,                           // display name
                    Email = $"user{i}@example.com",               // unique email
                    Password = "password" + i,                    // simple placeholder password
                    Role = "User",                                // role (you can set Admin/Trainer etc. later)
                    CreatedAt = DateTime.Now.AddDays(-i)          // staggered creation dates
                });
            }

            context.SaveChanges();  


            var random = new Random();

            string[] difficultyLevels = { "Beginner", "Intermediate", "Advanced" };
            string[] workoutTitles = {
                    "Full Body Blast",
                     "Morning Yoga",
                        "Cardio Burn",
                        "Leg Day Power",
                      "Upper Body Strength",
                            "HIIT Challenge",
                          "Core Crusher",
                            "Stretch & Flex",
                            "Endurance Run",
                               "Balance & Stability"
};

            for (int i = 0; i < 10; i++)
            {
                context.Workouts.AddOrUpdate(new DAL.Models.Workout
                {
                    Title = workoutTitles[i],
                    Description = $"This is a {difficultyLevels[random.Next(difficultyLevels.Length)]} level workout focusing on {workoutTitles[i].ToLower()}. It helps improve strength, stamina, and overall fitness.",
                    Duration = random.Next(20, 90),                   
                    CaloriesBurned = random.Next(200, 700),   
                    DifficultyLevel = difficultyLevels[random.Next(difficultyLevels.Length)]
                });
            }

            context.SaveChanges();


           
            var userIds = context.Users.Select(u => u.Id).ToList();

            if (userIds.Any())
            {
                for (int i = 1; i <= 10; i++)
                {
                    var randomUserId = userIds[random.Next(userIds.Count)];

                    context.Goals.AddOrUpdate(new DAL.Models.Goal
                    {
                        UserId = randomUserId,
                        GoalType = (i % 3 == 0) ? "Endurance" :
                                   (i % 2 == 0) ? "Muscle Gain" : "Weight Loss",

                        Description = $"Goal {i}: {Guid.NewGuid().ToString().Substring(0, 30)}",

                        Startdate = DateTime.Now.AddDays(-random.Next(1, 60)),   
                        Enddate = DateTime.Now.AddDays(random.Next(15, 90)),    

                        Status = (i % 3 == 0) ? "Completed" :
                                 (i % 2 == 0) ? "In Progress" : "Not Started"
                    });
                }

                context.SaveChanges();
            }

          
            var userId = context.Users.Select(u => u.Id).ToList();
            var workoutIds = context.Workouts.Select(w => w.Id).ToList();

            
            if (userId.Any() && workoutIds.Any())
            {
                for (int i = 1; i <= 20; i++)  
                {
                    var randomUserId = userId[random.Next(userId.Count)];
                    var randomWorkoutId = workoutIds[random.Next(workoutIds.Count)];

                    context.Userworkouts.AddOrUpdate(new DAL.Models.Userworkout
                    {
                        UserId = randomUserId,
                        WorkoutId = randomWorkoutId,
                        BurnedCalories = random.Next(150, 700),             
                        Date = DateTime.Now.AddDays(-random.Next(1, 30))   
                    });
                }

                context.SaveChanges();
            }
            */
        }
    }
}
