using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Data.Entities;
using System.Data.Entity.ModelConfiguration;


namespace Projeto.Data.Mappings
{
   public class AlunoMap : EntityTypeConfiguration<Aluno>
    {
        public AlunoMap()
        {
            ToTable("Aluno");

            HasKey(a => a.IdAluno);

            Property(a => a.IdAluno).HasColumnName("IdAluno").IsRequired(); 

            Property(a => a.Nome).HasColumnName("Nome").HasMaxLength(150).IsRequired();

            Property(a => a.Matricula).HasColumnName("Matricula").IsRequired();

            Property(a => a.Email).HasColumnName("Email").HasMaxLength(150).IsRequired();

            Property(a => a.IdTurma).HasColumnName("IdTurma").IsRequired();


            HasRequired(a => a.Turma).WithMany(a => a.Alunos).HasForeignKey(a => a.IdTurma);


        }

    }
}
