namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMaritalStatus : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "MaritalStatus", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "MaritalStatus", c => c.String(maxLength: 20));
        }
    }
}
