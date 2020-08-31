using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; 
using System.Data.Entity; 
using Projeto.Data.Entities;
using Projeto.Data.Mappings;


namespace Projeto.Data.Context
{
           
        public class DataContext : DbContext
        {
            public DataContext() : base(ConfigurationManager.ConnectionStrings["projeto"].ConnectionString)
            {
            }
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                
                modelBuilder.Configurations.Add(new AlunoMap());
                modelBuilder.Configurations.Add(new TurmaMap());
            
            modelBuilder.Configurations.Add(new UserMap());
            }
            
            public DbSet<Aluno> Aluno { get; set; } 
            public DbSet<Turma> Turma { get; set; }
            public DbSet<User> User { get; set; }

        }
}
