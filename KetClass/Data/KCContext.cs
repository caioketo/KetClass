using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using KetClass.Model;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using KetClass.Migrations;
//using KetClass.Migrations;

namespace KetClass.Data
{
    public class KCContext : DbContext
    {
        private static KCContext instance;
        public static KCContext getInstance()
        {
            if (instance == null)
            {
                instance = new KCContext();
                instance.splash();
            }

            return instance;
        }

        public static string CreateConnectionString()
        {
            return "DefaultConnection";
        }
        private string connectionString;
        public KCContext() : base(CreateConnectionString()) 
        {
            connectionString = CreateConnectionString();
        }
        public KCContext(string nameOrConnectionString)
            : base(nameOrConnectionString) 
        {
            connectionString = nameOrConnectionString;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<KCContext>(new MigrateDatabaseToLatestVersion<KCContext, Configuration>());
            //Database.SetInitializer<KCContext>(new <KCContext>());
            modelBuilder.Entity<RoleModel>().
            HasMany(c => c.Users).
            WithMany(p => p.Roles).
            Map(
                m =>
                {
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("UserId");
                    m.ToTable("RolesUsers");
                });
            modelBuilder.Entity<RoleModel>().
            HasMany(c => c.Permissoes).
            WithMany(p => p.Roles).
            Map(
                m =>
                {
                    m.MapLeftKey("RoleId");
                    m.MapRightKey("PermissaoId");
                    m.ToTable("RolesPermissoes");
                });
            base.OnModelCreating(modelBuilder);
        }

        public int GetSequence(string sequence)
        {
            try
            {
                return Database.SqlQuery<int>("select Next value for " + sequence).FirstOrDefault();
            }
            catch
            {
                Database.ExecuteSqlCommand("CREATE SEQUENCE " + sequence + " AS [int] START WITH 1 INCREMENT BY 1 MINVALUE 1");
                return Database.SqlQuery<int>("select Next value for " + sequence).FirstOrDefault();
            }
        }

        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<UnidadeModel> Unidades { get; set; }
        public DbSet<TurmaModel> Turmas { get; set; }
        public DbSet<DisciplinaModel> Disciplinas { get; set; }
        public DbSet<LicaoModel> Licoes { get; set; }
        public DbSet<ProvaModel> Provas { get; set; }
        public DbSet<CursoModel> Cursos { get; set; }
        public DbSet<PeriodoModel> Periodos { get; set; }
        public DbSet<NotaModel> Notas { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<PermissaoModel> Permissoes { get; set; }
        public DbSet<MatriculaModel> Matriculas { get; set; }

        public void splash()
        {
            Pessoas.Load();
            Alunos.Load();
            Unidades.Load();
            Turmas.Load();
            Disciplinas.Load();
            Licoes.Load();
            Provas.Load();
            Cursos.Load();
            Periodos.Load();
            Notas.Load();
            Users.Load();
            Matriculas.Load();
            Permissoes.Load();
        }

        internal static IEnumerable<System.Windows.Forms.DataGridViewColumn> Columns(string Tabela)
        {
            List<System.Windows.Forms.DataGridViewColumn> columns = new List<System.Windows.Forms.DataGridViewColumn>();

            if (Tabela.Equals("Licao"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Data",
                    DataPropertyName = "DataFormatada",
                    Name = "DataC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Disciplina",
                    DataPropertyName = "DisciplinaDesc",
                    Name = "DisciplinaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Turma",
                    DataPropertyName = "TurmaDesc",
                    Name = "TurmaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Conteudo",
                    DataPropertyName = "Conteudo",
                    Name = "ConteudoC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Prova"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Data",
                    DataPropertyName = "DataFormatada",
                    Name = "DataC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Disciplina",
                    DataPropertyName = "DisciplinaDesc",
                    Name = "DisciplinaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Turma",
                    DataPropertyName = "TurmaDesc",
                    Name = "TurmaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Descricao",
                    DataPropertyName = "Descricao",
                    Name = "DescricaoC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Aluno"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Código",
                    DataPropertyName = "Codigo",
                    Name = "IdC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Aluno",
                    DataPropertyName = "AlunoNome",
                    Name = "AlunoC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Pai",
                    DataPropertyName = "PaiNome",
                    Name = "PaiC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Mãe",
                    DataPropertyName = "MaeNome",
                    Name = "MaeC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Cadastrado Em",
                    DataPropertyName = "DataCriacao",
                    Name = "DataCriacaoC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Alterado Em",
                    DataPropertyName = "DataAlteracao",
                    Name = "DataAlteracaoC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Unidade"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Descrição",
                    DataPropertyName = "Descricao",
                    Name = "Descricao",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Número",
                    DataPropertyName = "Numero",
                    Name = "Numero",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Curso"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Descrição",
                    DataPropertyName = "Descricao",
                    Name = "Descricao",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Periodo"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Descrição",
                    DataPropertyName = "Descricao",
                    Name = "Descricao",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Início",
                    DataPropertyName = "HoraInicio",
                    Name = "HoraInicioC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Fim",
                    DataPropertyName = "HoraFim",
                    Name = "HoraFimC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Disciplina"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Descrição",
                    DataPropertyName = "Descricao",
                    Name = "Descricao",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Abreviatura",
                    DataPropertyName = "Abreviatura",
                    Name = "AbreviaturaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Nome Histórico",
                    DataPropertyName = "NomeHistorico",
                    Name = "NomeHistoricoC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Turma"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Turma",
                    DataPropertyName = "Display",
                    Name = "DisplayC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Curso",
                    DataPropertyName = "CursoDescricao",
                    Name = "CursoDescricaoC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Matrícula"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Aluno",
                    DataPropertyName = "AlunoNome",
                    Name = "AlunoNomeC",
                    DefaultCellStyle = new DataGridViewCellStyle(),
                    Width = 400
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Turma",
                    DataPropertyName = "TurmaDisplay",
                    Name = "DisplayC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Data da Matrícula",
                    DataPropertyName = "DataMatricula",
                    Name = "DataMatriculaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }
            else if (Tabela.Equals("Notas"))
            {
                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Turma",
                    DataPropertyName = "TurmaDescricao",
                    Name = "TurmaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Disciplina",
                    DataPropertyName = "DisciplinaDesc",
                    Name = "DisciplinaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Número",
                    DataPropertyName = "Numero",
                    Name = "NumeroC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });

                columns.Add(new System.Windows.Forms.DataGridViewColumn(new DataGridViewTextBoxCell())
                {
                    HeaderText = "Nota",
                    DataPropertyName = "Nota",
                    Name = "NotaC",
                    DefaultCellStyle = new DataGridViewCellStyle()
                });
            }



            return columns;
        }
    }
}
