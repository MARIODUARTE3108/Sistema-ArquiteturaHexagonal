using Projeto06.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Domain.Ports.Repositories
{
    public interface IAtendimentoRepository : IBaseRepository<Atendimento, Guid>
    {
    }
}
