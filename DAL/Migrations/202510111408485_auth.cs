namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class auth : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Workouts", "DifficultyLevel", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Workouts", "DifficultyLevel", c => c.String());
        }
    }
}
