namespace film_ertekeles.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.filmeks",
                c => new
                    {
                        film = c.String(nullable: false, maxLength: 128),
                        ertekeles = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.film);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.filmeks");
        }
    }
}
