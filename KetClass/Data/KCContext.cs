using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using KetClass.Model;
using System.Data.Entity.Infrastructure;

namespace KetClass.Data
{
    public class KCContext : DbContext
    {
        public static string CreateConnectionString()
        {
            return "Server=.\\SQLEXPRESS;Database=ketclass;User Id=sa;Password=vd7887;";
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
            Database.SetInitializer<KCContext>(new DropCreateDatabaseAlways<KCContext>());
            Database.DefaultConnectionFactory = new SqlConnectionFactory("System.Data.SqlServer");
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
    }
}
