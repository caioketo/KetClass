namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20155 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MatriculaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlunoId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                        Numero = c.Int(nullable: false),
                        DataMatricula = c.DateTime(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AlunoModels", t => t.AlunoId, cascadeDelete: true)
                .ForeignKey("dbo.TurmaModels", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.AlunoId)
                .Index(t => t.TurmaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MatriculaModels", "TurmaId", "dbo.TurmaModels");
            DropForeignKey("dbo.MatriculaModels", "AlunoId", "dbo.AlunoModels");
            DropIndex("dbo.MatriculaModels", new[] { "TurmaId" });
            DropIndex("dbo.MatriculaModels", new[] { "AlunoId" });
            DropTable("dbo.MatriculaModels");
        }
    }
}
