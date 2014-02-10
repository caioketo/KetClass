﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using KetClass.Model;

namespace KetClass.Data
{
    public class KCContext : DbContext
    {
        public KCContext()
            : base("DefaultConnection")
        {
            Database.SetInitializer<KCContext>(new DropCreateDatabaseIfModelChanges<KCContext>());
        }

        public DbSet<AlunoModel> Alunos { get; set; }
    }
}