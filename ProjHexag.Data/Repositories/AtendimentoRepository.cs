using ProjHexag.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHexag.Data.Repositories
{
    public class AtendimentoRepository : BaseRepository<Atendimento, Guid>
    {
        public AtendimentoRepository(DataContext dataContext)
            : base(dataContext)
        {

        }
    }

}
