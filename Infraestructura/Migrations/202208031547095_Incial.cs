namespace Infraestructura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Incial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulo",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RubroId = c.Long(nullable: false),
                        Codigo = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        Abreviatura = c.String(maxLength: 10),
                        Stock = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rubro", t => t.RubroId, cascadeDelete: true)
                .Index(t => t.RubroId);
            
            CreateTable(
                "dbo.DetalleComprobante",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ComprobanteId = c.Long(nullable: false),
                        ArticuloId = c.Long(nullable: false),
                        Codigo = c.String(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articulo", t => t.ArticuloId, cascadeDelete: true)
                .ForeignKey("dbo.Comprobante", t => t.ComprobanteId, cascadeDelete: true)
                .Index(t => t.ComprobanteId)
                .Index(t => t.ArticuloId);
            
            CreateTable(
                "dbo.Comprobante",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        Numero = c.Int(nullable: false),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Descuento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rubro",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 250),
                        EstaEliminado = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comprobante_Factura",
                c => new
                    {
                        Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comprobante", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comprobante_Factura", "Id", "dbo.Comprobante");
            DropForeignKey("dbo.Articulo", "RubroId", "dbo.Rubro");
            DropForeignKey("dbo.DetalleComprobante", "ComprobanteId", "dbo.Comprobante");
            DropForeignKey("dbo.DetalleComprobante", "ArticuloId", "dbo.Articulo");
            DropIndex("dbo.Comprobante_Factura", new[] { "Id" });
            DropIndex("dbo.DetalleComprobante", new[] { "ArticuloId" });
            DropIndex("dbo.DetalleComprobante", new[] { "ComprobanteId" });
            DropIndex("dbo.Articulo", new[] { "RubroId" });
            DropTable("dbo.Comprobante_Factura");
            DropTable("dbo.Rubro");
            DropTable("dbo.Comprobante");
            DropTable("dbo.DetalleComprobante");
            DropTable("dbo.Articulo");
        }
    }
}
