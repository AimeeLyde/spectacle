namespace AimCecSpect.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewMigration2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Utilisateurs", "historiqueReservations");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Utilisateurs", "historiqueReservations", c => c.String());
        }
    }
}
