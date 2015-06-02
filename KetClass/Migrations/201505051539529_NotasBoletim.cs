namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NotasBoletim : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NotasBoletimModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlunoId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                        Nota = c.Double(nullable: false),
                        Rec = c.Double(nullable: false),
                        Media = c.Double(nullable: false),
                        Faltas = c.Int(nullable: false),
                        Trimestre = c.Int(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AlunoModels", t => t.AlunoId, cascadeDelete: true)
                .ForeignKey("dbo.DisciplinaModels", t => t.DisciplinaId, cascadeDelete: true)
                .Index(t => t.AlunoId)
                .Index(t => t.DisciplinaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotasBoletimModels", "DisciplinaId", "dbo.DisciplinaModels");
            DropForeignKey("dbo.NotasBoletimModels", "AlunoId", "dbo.AlunoModels");
            DropIndex("dbo.NotasBoletimModels", new[] { "DisciplinaId" });
            DropIndex("dbo.NotasBoletimModels", new[] { "AlunoId" });
            DropTable("dbo.NotasBoletimModels");
        }
    }
}
