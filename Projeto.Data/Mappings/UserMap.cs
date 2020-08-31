using Projeto.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Data.Mappings
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Usuario");

            HasKey(u => u.IdUsuario);

            Property(u => u.IdUsuario).HasColumnName("IdUsuario").IsRequired();

            Property(u => u.Nome).HasColumnName("Nome").IsRequired();

            Property(u => u.Email).HasColumnName("Email").IsRequired();

            Property(u => u.Senha).HasColumnName("Senha").IsRequired();

            Property(u => u.SenhaConfirm).HasColumnName("SenhaConfirm").IsRequired();

        }
    }
}
