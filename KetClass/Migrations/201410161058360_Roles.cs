namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Nome = c.String(),
                        Cargo = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolesUsers",
                c => new
                    {
                        RoleId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.RoleModels", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.UserModels", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
            DropTable("dbo.LoginModels");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LoginModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        Nome = c.String(),
                        Permissoes = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.RolesUsers", "UserId", "dbo.UserModels");
            DropForeignKey("dbo.RolesUsers", "RoleId", "dbo.RoleModels");
            DropIndex("dbo.RolesUsers", new[] { "UserId" });
            DropIndex("dbo.RolesUsers", new[] { "RoleId" });
            DropTable("dbo.RolesUsers");
            DropTable("dbo.RoleModels");
            DropTable("dbo.UserModels");
        }
    }
}
