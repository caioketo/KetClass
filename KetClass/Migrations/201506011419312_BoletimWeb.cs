namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoletimWeb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BoletimWebModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WebId = c.Int(nullable: false),
                        AlunoId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BoletimWebModels");
        }
    }
}
