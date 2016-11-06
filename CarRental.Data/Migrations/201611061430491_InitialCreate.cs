namespace CarRental.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        Brand = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        RegistrationNumber = c.String(nullable: false),
                        Fuel = c.String(),
                        Transmission = c.String(),
                        NumberOfSeats = c.Int(nullable: false),
                        NumberOfDoors = c.Int(nullable: false),
                        PricePerDay = c.Double(nullable: false),
                        Yearbook = c.Int(nullable: false),
                        EngineCapacity = c.Single(nullable: false),
                        FuelConsumption = c.Single(nullable: false),
                        Power = c.Int(nullable: false),
                        AdditionalFeatures = c.String(),
                        Deposit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        LicenseId = c.String(nullable: false),
                        City = c.String(),
                        Address = c.String(),
                        ZipCode = c.String(),
                        Country = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Phone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rentals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ReceptionPlace = c.String(),
                        ReturnPlace = c.String(),
                        CarId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CarId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Rentals", "CarId", "dbo.Cars");
            DropIndex("dbo.Rentals", new[] { "CustomerId" });
            DropIndex("dbo.Rentals", new[] { "CarId" });
            DropTable("dbo.Rentals");
            DropTable("dbo.Customers");
            DropTable("dbo.Cars");
        }
    }
}
