namespace PetClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "AppointmentID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "AppointmentID");
        }
    }
}
