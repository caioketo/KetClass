namespace KetClass.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlunoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Sexo = c.String(),
                        Cor = c.String(),
                        CN = c.String(),
                        Numero = c.Int(nullable: false),
                        DataMatricula = c.DateTime(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Aluno_Id = c.Int(),
                        Endereo_Id = c.Int(),
                        Mae_Id = c.Int(),
                        Pai_Id = c.Int(),
                        Responsavel_Id = c.Int(),
                        Turma_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PessoaModels", t => t.Aluno_Id)
                .ForeignKey("dbo.EnderecoModels", t => t.Endereo_Id)
                .ForeignKey("dbo.PessoaModels", t => t.Mae_Id)
                .ForeignKey("dbo.PessoaModels", t => t.Pai_Id)
                .ForeignKey("dbo.PessoaModels", t => t.Responsavel_Id)
                .ForeignKey("dbo.TurmaModels", t => t.Turma_Id)
                .Index(t => t.Aluno_Id)
                .Index(t => t.Endereo_Id)
                .Index(t => t.Mae_Id)
                .Index(t => t.Pai_Id)
                .Index(t => t.Responsavel_Id)
                .Index(t => t.Turma_Id);
            
            CreateTable(
                "dbo.PessoaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Telefone = c.String(nullable: false),
                        DataNascimento = c.DateTime(),
                        LocalNascimento = c.String(),
                        RG = c.String(),
                        CPF = c.String(),
                        Nacionalidade = c.String(),
                        Convenio = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EnderecoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        CEP = c.String(),
                        Telefone = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        Cidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CidadeModels", t => t.Cidade_Id)
                .Index(t => t.Cidade_Id);
            
            CreateTable(
                "dbo.CidadeModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                        UF_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UFModels", t => t.UF_Id)
                .Index(t => t.UF_Id);
            
            CreateTable(
                "dbo.UFModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        Descricao = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TurmaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        CursoId = c.Int(nullable: false),
                        Serie = c.Int(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CursoModels", t => t.CursoId, cascadeDelete: true)
                .Index(t => t.CursoId);
            
            CreateTable(
                "dbo.CursoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Ano = c.Int(nullable: false),
                        PeriodoId = c.Int(nullable: false),
                        UnidadeId = c.Int(nullable: false),
                        PrimeiraSerie = c.Int(nullable: false),
                        UltimaSerie = c.Int(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PeriodoModels", t => t.PeriodoId, cascadeDelete: true)
                .ForeignKey("dbo.UnidadeModels", t => t.UnidadeId, cascadeDelete: true)
                .Index(t => t.PeriodoId)
                .Index(t => t.UnidadeId);
            
            CreateTable(
                "dbo.PeriodoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        HoraInicio = c.String(),
                        HoraFim = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnidadeModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Descricao = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DisciplinaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Abreviatura = c.String(),
                        NomeHistorico = c.String(),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LicaoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataLicao = c.DateTime(nullable: false),
                        Conteudo = c.String(),
                        DisciplinaId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                        Sinc = c.Boolean(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisciplinaModels", t => t.DisciplinaId, cascadeDelete: true)
                .ForeignKey("dbo.TurmaModels", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.DisciplinaId)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.NotaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AlunoId = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                        Numero = c.Int(nullable: false),
                        Nota = c.Double(nullable: false),
                        Faltas = c.Int(nullable: false),
                        AulasDadas = c.Int(nullable: false),
                        Recupercao = c.Boolean(nullable: false),
                        Trimestre = c.Int(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AlunoModels", t => t.AlunoId, cascadeDelete: true)
                .ForeignKey("dbo.DisciplinaModels", t => t.DisciplinaId, cascadeDelete: true)
                .ForeignKey("dbo.TurmaModels", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.AlunoId)
                .Index(t => t.DisciplinaId)
                .Index(t => t.TurmaId);
            
            CreateTable(
                "dbo.ProvaModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataProva = c.DateTime(nullable: false),
                        Trimestre = c.Int(nullable: false),
                        TurmaId = c.Int(nullable: false),
                        DisciplinaId = c.Int(nullable: false),
                        Recuperacao = c.Boolean(nullable: false),
                        Descricao = c.String(),
                        Sinc = c.Boolean(nullable: false),
                        DataExclusao = c.DateTime(),
                        DataCriacao = c.DateTime(nullable: false),
                        DataAlteracao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DisciplinaModels", t => t.DisciplinaId, cascadeDelete: true)
                .ForeignKey("dbo.TurmaModels", t => t.TurmaId, cascadeDelete: true)
                .Index(t => t.DisciplinaId)
                .Index(t => t.TurmaId);
            
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
                "dbo.PermissaoModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolesUsers", "UserId", "dbo.UserModels");
            DropForeignKey("dbo.RolesUsers", "RoleId", "dbo.RoleModels");
            DropForeignKey("dbo.RolesPermissoes", "PermissaoId", "dbo.PermissaoModels");
            DropForeignKey("dbo.RolesPermissoes", "RoleId", "dbo.RoleModels");
            DropForeignKey("dbo.ProvaModels", "TurmaId", "dbo.TurmaModels");
            DropForeignKey("dbo.ProvaModels", "DisciplinaId", "dbo.DisciplinaModels");
            DropForeignKey("dbo.NotaModels", "TurmaId", "dbo.TurmaModels");
            DropForeignKey("dbo.NotaModels", "DisciplinaId", "dbo.DisciplinaModels");
            DropForeignKey("dbo.NotaModels", "AlunoId", "dbo.AlunoModels");
            DropForeignKey("dbo.LicaoModels", "TurmaId", "dbo.TurmaModels");
            DropForeignKey("dbo.LicaoModels", "DisciplinaId", "dbo.DisciplinaModels");
            DropForeignKey("dbo.AlunoModels", "Turma_Id", "dbo.TurmaModels");
            DropForeignKey("dbo.CursoModels", "UnidadeId", "dbo.UnidadeModels");
            DropForeignKey("dbo.TurmaModels", "CursoId", "dbo.CursoModels");
            DropForeignKey("dbo.CursoModels", "PeriodoId", "dbo.PeriodoModels");
            DropForeignKey("dbo.AlunoModels", "Responsavel_Id", "dbo.PessoaModels");
            DropForeignKey("dbo.AlunoModels", "Pai_Id", "dbo.PessoaModels");
            DropForeignKey("dbo.AlunoModels", "Mae_Id", "dbo.PessoaModels");
            DropForeignKey("dbo.AlunoModels", "Endereo_Id", "dbo.EnderecoModels");
            DropForeignKey("dbo.EnderecoModels", "Cidade_Id", "dbo.CidadeModels");
            DropForeignKey("dbo.CidadeModels", "UF_Id", "dbo.UFModels");
            DropForeignKey("dbo.AlunoModels", "Aluno_Id", "dbo.PessoaModels");
            DropIndex("dbo.RolesUsers", new[] { "UserId" });
            DropIndex("dbo.RolesUsers", new[] { "RoleId" });
            DropIndex("dbo.RolesPermissoes", new[] { "PermissaoId" });
            DropIndex("dbo.RolesPermissoes", new[] { "RoleId" });
            DropIndex("dbo.ProvaModels", new[] { "TurmaId" });
            DropIndex("dbo.ProvaModels", new[] { "DisciplinaId" });
            DropIndex("dbo.NotaModels", new[] { "TurmaId" });
            DropIndex("dbo.NotaModels", new[] { "DisciplinaId" });
            DropIndex("dbo.NotaModels", new[] { "AlunoId" });
            DropIndex("dbo.LicaoModels", new[] { "TurmaId" });
            DropIndex("dbo.LicaoModels", new[] { "DisciplinaId" });
            DropIndex("dbo.AlunoModels", new[] { "Turma_Id" });
            DropIndex("dbo.CursoModels", new[] { "UnidadeId" });
            DropIndex("dbo.TurmaModels", new[] { "CursoId" });
            DropIndex("dbo.CursoModels", new[] { "PeriodoId" });
            DropIndex("dbo.AlunoModels", new[] { "Responsavel_Id" });
            DropIndex("dbo.AlunoModels", new[] { "Pai_Id" });
            DropIndex("dbo.AlunoModels", new[] { "Mae_Id" });
            DropIndex("dbo.AlunoModels", new[] { "Endereo_Id" });
            DropIndex("dbo.EnderecoModels", new[] { "Cidade_Id" });
            DropIndex("dbo.CidadeModels", new[] { "UF_Id" });
            DropIndex("dbo.AlunoModels", new[] { "Aluno_Id" });
            DropTable("dbo.RolesUsers");
            DropTable("dbo.RolesPermissoes");
            DropTable("dbo.PermissaoModels");
            DropTable("dbo.RoleModels");
            DropTable("dbo.UserModels");
            DropTable("dbo.ProvaModels");
            DropTable("dbo.NotaModels");
            DropTable("dbo.LicaoModels");
            DropTable("dbo.DisciplinaModels");
            DropTable("dbo.UnidadeModels");
            DropTable("dbo.PeriodoModels");
            DropTable("dbo.CursoModels");
            DropTable("dbo.TurmaModels");
            DropTable("dbo.UFModels");
            DropTable("dbo.CidadeModels");
            DropTable("dbo.EnderecoModels");
            DropTable("dbo.PessoaModels");
            DropTable("dbo.AlunoModels");
        }
    }
}
