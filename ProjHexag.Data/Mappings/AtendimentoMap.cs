using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjHexag.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHexag.Data.Mappings
{
    public class AtendimentoMap : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            #region Relacionamento 1pN

            builder.HasOne(a => a.Cliente)//Atendimento tem 1 cliente
                .WithMany(c => c.Atendimentos) //Cliente tem Muitos atendimentos
                .HasForeignKey(a => a.ClienteId); //Chave estrangeira é ClienteId

            #endregion

            #region Relacionamento NpN
            builder.HasMany(a => a.Servicos)//Atendimentos tem Muitos Serviços
                .WithMany(s => s.Atendimentos) //Serviços tem Muitos Atendimentos     //(.UsingEntity)Nome da Entidade usada para mapear o relacionamento
                .UsingEntity<AtendimentoServico>(           
                    map => map
                        .HasOne(map => map.Servico)
                        .WithMany(s => s.AtendimentosServicos)
                        .HasForeignKey(map => map.ServicoId),
                    map => map
                        .HasOne(map => map.Atendimento)
                        .WithMany(a => a.AtendimentosServicos)
                        .HasForeignKey(map => map.AtendimentoId),
                     map =>
                     {      
                         map.HasKey 
                         (ats => new { ats.AtendimentoId, ats.ServicoId });
                     });



            #endregion
        }
    }

}
