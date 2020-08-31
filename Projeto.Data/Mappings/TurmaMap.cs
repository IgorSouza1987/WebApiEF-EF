using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Data.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Projeto.Data.Mappings
{
   public class TurmaMap : EntityTypeConfiguration<Turma>
    {
        public TurmaMap()
        {
            ToTable("Turma");

            HasKey(t => t.IdTurma);

            Property(t => t.IdTurma).HasColumnName("IdTurma").IsRequired(); 

            Property(t => t.Codigo).HasColumnName("Codigo").IsRequired();
            
            




        }
    }
}
