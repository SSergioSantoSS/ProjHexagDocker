using ProjHexag.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjHexag.Data.Repositories
{
    public class ClienteRepository : BaseRepository<Cliente, Guid>
    {
        public ClienteRepository(DataContext dataContext)
            : base(dataContext)
        {

        }
    }

}
