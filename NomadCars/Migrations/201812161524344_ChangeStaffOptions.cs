namespace NomadCars.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeStaffOptions : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Staffs", "Department", c => c.Int(nullable: false));
            AlterColumn("dbo.Staffs", "JobPosition", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staffs", "JobPosition", c => c.String());
            AlterColumn("dbo.Staffs", "Department", c => c.String());
        }
    }
}
