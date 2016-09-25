namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init_tbl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblRezervationRoom",
                c => new
                    {
                        RezervationRoomId = c.Int(nullable: false, identity: true),
                        Rezervation_RezervationId = c.Int(),
                        Room_RoomId = c.Int(),
                    })
                .PrimaryKey(t => t.RezervationRoomId)
                .ForeignKey("dbo.tblRezervation", t => t.Rezervation_RezervationId)
                .ForeignKey("dbo.tblRoom", t => t.Room_RoomId)
                .Index(t => t.Rezervation_RezervationId)
                .Index(t => t.Room_RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblRezervationRoom", "Room_RoomId", "dbo.tblRoom");
            DropForeignKey("dbo.tblRezervationRoom", "Rezervation_RezervationId", "dbo.tblRezervation");
            DropIndex("dbo.tblRezervationRoom", new[] { "Room_RoomId" });
            DropIndex("dbo.tblRezervationRoom", new[] { "Rezervation_RezervationId" });
            DropTable("dbo.tblRezervationRoom");
        }
    }
}
