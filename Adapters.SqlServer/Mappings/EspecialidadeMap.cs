using Clinica.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters.SqlServer.Mappings
{
    public class EspecialidadeMap : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.HasKey(e=>e.Id);
        }
    }
}
