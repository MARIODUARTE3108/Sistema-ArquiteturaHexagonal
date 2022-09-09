using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto06.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Data.Mappings
{
    public class AtendimentoMap : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            //trlacionamento de 1pN
            builder.HasOne(a => a.Cliente).WithMany(x => x.Atendimentos).HasForeignKey(a => a.ClienteId);

            //relacionamento de NpN
            builder.HasMany(a => a.Servicos).WithMany(x => x.Atendimentos).UsingEntity<AtendimentoServico>(
                map => map.HasOne(pt => pt.Servico).WithMany(x => x.AtendimentosServicos).HasForeignKey(pt=>pt.ServicoId),
                map => map.HasOne(pt => pt.Atendimento).WithMany(p=>p.AtendimentosServicos).HasForeignKey(pt=>pt.AtendimentoId),
                map =>
                {
                    map.HasKey(t => new { t.AtendimentoId, t.ServicoId });
                }
                );
        }
    }
}
