namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tokens", "Uname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tokens", "Uname", c => c.String());
        }
    }
}
