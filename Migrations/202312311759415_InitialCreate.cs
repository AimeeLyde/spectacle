namespace AimCecSpect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        idUser = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                        motDePasse = c.String(),
                    })
                .PrimaryKey(t => t.idUser);
            
            CreateTable(
                "dbo.Billets",
                c => new
                    {
                        idBillet = c.Int(nullable: false, identity: true),
                        idSpectacle = c.Int(nullable: false),
                        idUtilisateur = c.Int(nullable: false),
                        statutReservation = c.String(),
                        Utilisateur_idUser = c.Int(),
                    })
                .PrimaryKey(t => t.idBillet)
                .ForeignKey("dbo.Utilisateurs", t => t.Utilisateur_idUser)
                .Index(t => t.Utilisateur_idUser);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Billets", "Utilisateur_idUser", "dbo.Utilisateurs");
            DropIndex("dbo.Billets", new[] { "Utilisateur_idUser" });
            DropTable("dbo.Billets");
            DropTable("dbo.Utilisateurs");
        }
    }
}
