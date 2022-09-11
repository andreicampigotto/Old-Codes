namespace Locacao2ponto0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CorVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeCorVeiculo = c.String(),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MarcaCarroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeMarcaCarro = c.String(),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MarcaMotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeMarcaMoto = c.String(),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ModeloCarroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeModeloCarro = c.String(),
                        IdMarca = c.Int(nullable: false),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarcaCarroes", t => t.IdMarca, cascadeDelete: true)
                .Index(t => t.IdMarca);
            
            CreateTable(
                "dbo.ModeloMotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeModeloMoto = c.String(),
                        IdMarca = c.Int(nullable: false),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MarcaMotoes", t => t.IdMarca, cascadeDelete: true)
                .Index(t => t.IdMarca);
            
            CreateTable(
                "dbo.TipoDoVeiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TipoVeiculo = c.String(),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Veiculoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdTipoVeiculo = c.Int(nullable: false),
                        Placa = c.String(),
                        IdModeloCarro = c.Int(nullable: false),
                        IdModeloMoto = c.Int(nullable: false),
                        IdCor = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        DataInicial = c.DateTime(nullable: false),
                        DataFinal = c.DateTime(nullable: false),
                        Cod = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CorVeiculoes", t => t.IdCor, cascadeDelete: true)
                .ForeignKey("dbo.ModeloCarroes", t => t.IdModeloCarro, cascadeDelete: true)
                .ForeignKey("dbo.ModeloMotoes", t => t.IdModeloMoto, cascadeDelete: true)
                .ForeignKey("dbo.TipoDoVeiculoes", t => t.IdTipoVeiculo, cascadeDelete: true)
                .Index(t => t.IdTipoVeiculo)
                .Index(t => t.IdModeloCarro)
                .Index(t => t.IdModeloMoto)
                .Index(t => t.IdCor);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Veiculoes", "IdTipoVeiculo", "dbo.TipoDoVeiculoes");
            DropForeignKey("dbo.Veiculoes", "IdModeloMoto", "dbo.ModeloMotoes");
            DropForeignKey("dbo.Veiculoes", "IdModeloCarro", "dbo.ModeloCarroes");
            DropForeignKey("dbo.Veiculoes", "IdCor", "dbo.CorVeiculoes");
            DropForeignKey("dbo.ModeloMotoes", "IdMarca", "dbo.MarcaMotoes");
            DropForeignKey("dbo.ModeloCarroes", "IdMarca", "dbo.MarcaCarroes");
            DropIndex("dbo.Veiculoes", new[] { "IdCor" });
            DropIndex("dbo.Veiculoes", new[] { "IdModeloMoto" });
            DropIndex("dbo.Veiculoes", new[] { "IdModeloCarro" });
            DropIndex("dbo.Veiculoes", new[] { "IdTipoVeiculo" });
            DropIndex("dbo.ModeloMotoes", new[] { "IdMarca" });
            DropIndex("dbo.ModeloCarroes", new[] { "IdMarca" });
            DropTable("dbo.Veiculoes");
            DropTable("dbo.TipoDoVeiculoes");
            DropTable("dbo.ModeloMotoes");
            DropTable("dbo.ModeloCarroes");
            DropTable("dbo.MarcaMotoes");
            DropTable("dbo.MarcaCarroes");
            DropTable("dbo.CorVeiculoes");
        }
    }
}
