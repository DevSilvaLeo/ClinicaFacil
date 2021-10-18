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
    public class MedicoMap : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(m => m.Id);
        }
    }
}
