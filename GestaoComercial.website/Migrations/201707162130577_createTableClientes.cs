namespace GestaoComercial.website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTableClientes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.cliente",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        NomeCompletoRazaoSocial = c.String(nullable: false, maxLength: 255),
                        ApelidoNomeFantasia = c.String(maxLength: 255),
                        CPFCNPJ = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.AspNetUsers", "LockoutEndDateUtc", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LockoutEndDateUtc", c => c.DateTime());
            DropTable("dbo.cliente");
        }
    }
}
