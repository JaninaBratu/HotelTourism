namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCity",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        County_CountyId = c.Int(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.tblCounty", t => t.County_CountyId)
                .Index(t => t.County_CountyId);
            
            CreateTable(
                "dbo.tblCounty",
                c => new
                    {
                        CountyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CountyId);
            
            CreateTable(
                "dbo.tblFacility",
                c => new
                    {
                        FacilityId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FacilityRoom_FacilityRoomId = c.Int(),
                    })
                .PrimaryKey(t => t.FacilityId)
                .ForeignKey("dbo.tblFacilityRoom", t => t.FacilityRoom_FacilityRoomId)
                .Index(t => t.FacilityRoom_FacilityRoomId);
            
            CreateTable(
                "dbo.tblFacilityRoom",
                c => new
                    {
                        FacilityRoomId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.FacilityRoomId);
            
            CreateTable(
                "dbo.tblRoom",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        Hotel_HotelId = c.Int(),
                        FacilityRoom_FacilityRoomId = c.Int(),
                    })
                .PrimaryKey(t => t.RoomId)
                .ForeignKey("dbo.tblHotel", t => t.Hotel_HotelId)
                .ForeignKey("dbo.tblFacilityRoom", t => t.FacilityRoom_FacilityRoomId)
                .Index(t => t.Hotel_HotelId)
                .Index(t => t.FacilityRoom_FacilityRoomId);
            
            CreateTable(
                "dbo.tblHotel",
                c => new
                    {
                        HotelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City_CityId = c.Int(),
                    })
                .PrimaryKey(t => t.HotelId)
                .ForeignKey("dbo.tblCity", t => t.City_CityId)
                .Index(t => t.City_CityId);
            
            CreateTable(
                "dbo.tblRoomType",
                c => new
                    {
                        RoomTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Room_RoomId = c.Int(),
                    })
                .PrimaryKey(t => t.RoomTypeId)
                .ForeignKey("dbo.tblRoom", t => t.Room_RoomId)
                .Index(t => t.Room_RoomId);
            
            CreateTable(
                "dbo.tblRezervation",
                c => new
                    {
                        RezervationId = c.Int(nullable: false, identity: true),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        Room_RoomId = c.Int(),
                    })
                .PrimaryKey(t => t.RezervationId)
                .ForeignKey("dbo.tblRoom", t => t.Room_RoomId)
                .Index(t => t.Room_RoomId);
            
            CreateTable(
                "dbo.tblUser",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        Rezervation_RezervationId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.tblRezervation", t => t.Rezervation_RezervationId)
                .Index(t => t.Rezervation_RezervationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblUser", "Rezervation_RezervationId", "dbo.tblRezervation");
            DropForeignKey("dbo.tblRezervation", "Room_RoomId", "dbo.tblRoom");
            DropForeignKey("dbo.tblRoom", "FacilityRoom_FacilityRoomId", "dbo.tblFacilityRoom");
            DropForeignKey("dbo.tblRoomType", "Room_RoomId", "dbo.tblRoom");
            DropForeignKey("dbo.tblRoom", "Hotel_HotelId", "dbo.tblHotel");
            DropForeignKey("dbo.tblHotel", "City_CityId", "dbo.tblCity");
            DropForeignKey("dbo.tblFacility", "FacilityRoom_FacilityRoomId", "dbo.tblFacilityRoom");
            DropForeignKey("dbo.tblCity", "County_CountyId", "dbo.tblCounty");
            DropIndex("dbo.tblUser", new[] { "Rezervation_RezervationId" });
            DropIndex("dbo.tblRezervation", new[] { "Room_RoomId" });
            DropIndex("dbo.tblRoomType", new[] { "Room_RoomId" });
            DropIndex("dbo.tblHotel", new[] { "City_CityId" });
            DropIndex("dbo.tblRoom", new[] { "FacilityRoom_FacilityRoomId" });
            DropIndex("dbo.tblRoom", new[] { "Hotel_HotelId" });
            DropIndex("dbo.tblFacility", new[] { "FacilityRoom_FacilityRoomId" });
            DropIndex("dbo.tblCity", new[] { "County_CountyId" });
            DropTable("dbo.tblUser");
            DropTable("dbo.tblRezervation");
            DropTable("dbo.tblRoomType");
            DropTable("dbo.tblHotel");
            DropTable("dbo.tblRoom");
            DropTable("dbo.tblFacilityRoom");
            DropTable("dbo.tblFacility");
            DropTable("dbo.tblCounty");
            DropTable("dbo.tblCity");
        }
    }
}
