using ProjHexag.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHexag.Data.Repositories
{
    public class ServicoRepository : BaseRepository<Servico, Guid>
    {
        public ServicoRepository(DataContext dataContext)
            : base(dataContext)
        {

        }
    }

}
