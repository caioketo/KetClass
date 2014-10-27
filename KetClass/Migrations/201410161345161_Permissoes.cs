namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Permissoes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PermissaoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolesPermissoes",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        PermissaoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.PermissaoId })
                .ForeignKey("dbo.RoleModels", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.PermissaoModels", t => t.PermissaoId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.PermissaoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesPermissoes", "PermissaoId", "dbo.PermissaoModels");
            DropForeignKey("dbo.RolesPermissoes", "RoleId", "dbo.RoleModels");
            DropIndex("dbo.RolesPermissoes", new[] { "PermissaoId" });
            DropIndex("dbo.RolesPermissoes", new[] { "RoleId" });
            DropTable("dbo.RolesPermissoes");
            DropTable("dbo.PermissaoModels");
        }
    }
}
