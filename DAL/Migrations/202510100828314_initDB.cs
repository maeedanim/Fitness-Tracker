namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        GoalType = c.String(),
                        Description = c.String(nullable: false, maxLength: 350),
                        Startdate = c.DateTime(nullable: false),
                        Enddate = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Uname = c.String(nullable: false, maxLength: 20),
                        Name = c.String(nullable: false, maxLength: 50),
                        Email = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 20),
                        Role = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Userworkouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        WorkoutId = c.Int(nullable: false),
                        BurnedCalories = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Workouts", t => t.WorkoutId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.WorkoutId);
            
            CreateTable(
                "dbo.Workouts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(nullable: false, maxLength: 350),
                        Duration = c.Int(nullable: false),
                        CaloriesBurned = c.Int(nullable: false),
                        DifficultyLevel = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goals", "UserId", "dbo.Users");
            DropForeignKey("dbo.Userworkouts", "WorkoutId", "dbo.Workouts");
            DropForeignKey("dbo.Userworkouts", "UserId", "dbo.Users");
            DropIndex("dbo.Userworkouts", new[] { "WorkoutId" });
            DropIndex("dbo.Userworkouts", new[] { "UserId" });
            DropIndex("dbo.Goals", new[] { "UserId" });
            DropTable("dbo.Workouts");
            DropTable("dbo.Userworkouts");
            DropTable("dbo.Users");
            DropTable("dbo.Goals");
        }
    }
}
