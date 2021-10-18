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
    public class ProcedimentoMap : IEntityTypeConfiguration<Procedimento>
    {
        public void Configure(EntityTypeBuilder<Procedimento> builder)
        {
            builder.HasKey(p => p.IdProcedimento);
        }
    }
}
