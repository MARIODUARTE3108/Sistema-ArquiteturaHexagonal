using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Domain.Model
{
    public class Servico
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public decimal? Preco { get; set; }
        
        public virtual ICollection<Atendimento>? Atendimentos { get; set; }
        public virtual ICollection<AtendimentoServico>? AtendimentosServicos { get; set; }
    }
}
