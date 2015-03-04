namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20154 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PessoaModels", "Nome", c => c.String());
            AlterColumn("dbo.PessoaModels", "Telefone", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PessoaModels", "Telefone", c => c.String(nullable: false));
            AlterColumn("dbo.PessoaModels", "Nome", c => c.String(nullable: false));
        }
    }
}
