namespace Locacao2ponto0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tste1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TermosLocacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ativo = c.Boolean(nullable: false),
                        Dataalteracao = c.DateTime(nullable: false),
                        CaminhoTermo = c.String(),
                        PersisteTermo = c.String(),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Usuarios", "Email", c => c.String());
            AlterColumn("dbo.Locacaos", "Termo", c => c.Boolean(nullable: false));
            DropColumn("dbo.Locacaos", "DataInicio");
            DropColumn("dbo.Locacaos", "DataFim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locacaos", "DataFim", c => c.DateTime(nullable: false));
            AddColumn("dbo.Locacaos", "DataInicio", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locacaos", "Termo", c => c.String());
            DropColumn("dbo.Usuarios", "Email");
            DropTable("dbo.TermosLocacaos");
        }
    }
}
