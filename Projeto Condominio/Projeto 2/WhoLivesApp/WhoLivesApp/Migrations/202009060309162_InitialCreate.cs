namespace WhoLivesApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apartaments",
                c => new
                    {
                        AP_ID = c.Int(nullable: false, identity: true),
                        AP_NUMERO = c.Int(nullable: false),
                        AP_ATENCAO = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AP_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Apartaments");
        }
    }
}
