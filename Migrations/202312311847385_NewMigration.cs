namespace AimCecSpect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Spectacles",
                c => new
                    {
                        idSpectacle = c.Int(nullable: false, identity: true),
                        titre = c.String(),
                        date = c.DateTime(),
                        lieu = c.String(),
                        nbPlacesDispo = c.Int(),
                    })
                .PrimaryKey(t => t.idSpectacle);
            
            AddColumn("dbo.Utilisateurs", "historiqueReservations", c => c.String());
            AlterColumn("dbo.Billets", "idSpectacle", c => c.Int());
            AlterColumn("dbo.Billets", "idUtilisateur", c => c.Int());
            CreateIndex("dbo.Billets", "idSpectacle");
            AddForeignKey("dbo.Billets", "idSpectacle", "dbo.Spectacles", "idSpectacle");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Billets", "idSpectacle", "dbo.Spectacles");
            DropIndex("dbo.Billets", new[] { "idSpectacle" });
            AlterColumn("dbo.Billets", "idUtilisateur", c => c.Int(nullable: false));
            AlterColumn("dbo.Billets", "idSpectacle", c => c.Int(nullable: false));
            DropColumn("dbo.Utilisateurs", "historiqueReservations");
            DropTable("dbo.Spectacles");
        }
    }
}
