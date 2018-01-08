namespace PetClinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        DoctorName = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        Address = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(),
                        Speciality = c.String(),
                        RoomNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DoctorName = c.String(),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
            DropTable("dbo.Doctors");
            DropTable("dbo.Clients");
            DropTable("dbo.Appointments");
        }
    }
}
