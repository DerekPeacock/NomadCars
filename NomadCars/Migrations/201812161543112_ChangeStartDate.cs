namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStartDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staffs", "StartDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staffs", "StartDate", c => c.Int(nullable: false));
        }
    }
}
