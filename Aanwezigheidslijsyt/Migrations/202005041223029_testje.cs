namespace Aanwezigheidslijsyt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testje : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deelnemers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Geboortedatum = c.DateTime(nullable: false),
                        Woonplaats = c.String(),
                        BadgeNummer = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tijdsregistraties",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Deelnemer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Deelnemers", t => t.Deelnemer_Id)
                .Index(t => t.Deelnemer_Id);
            
            CreateTable(
                "dbo.Docents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naam = c.String(),
                        Bedrijf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tijdsregistraties", "Deelnemer_Id", "dbo.Deelnemers");
            DropIndex("dbo.Tijdsregistraties", new[] { "Deelnemer_Id" });
            DropTable("dbo.Docents");
            DropTable("dbo.Tijdsregistraties");
            DropTable("dbo.Deelnemers");
        }
    }
}
