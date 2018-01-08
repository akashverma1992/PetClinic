namespace PetClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoomNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "RoomNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "RoomNumber");
        }
    }
}
