using Projeto06.Data.Contexts;
using Projeto06.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.Data.Repositories
{
    public class ServicoRepository : BaseRepository<Servico, Guid>
    {
        public ServicoRepository(DataContext dataContext) : base(dataContext)
        {

        }
    }
}
