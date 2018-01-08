namespace PetClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointmentNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "AppointmentNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clients", "AppointmentNumber");
        }
    }
}
