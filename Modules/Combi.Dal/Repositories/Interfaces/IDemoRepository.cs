using Combi.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi.Dal.Repositories.Interfaces
{
    public interface IDemoRepository
    {
        IEnumerable<Demo> GetAll();
    }
}
