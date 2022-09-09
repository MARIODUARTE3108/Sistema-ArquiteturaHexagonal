using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Domain.Model
{
    public class AtendimentoServico
    {
        public Guid AtendimentoId { get; set; }
        public Guid ServicoId { get; set; }

        public Atendimento? Atendimento { get; set; }
        public Servico? Servico { get; set; }
    }
}
