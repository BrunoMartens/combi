using Combi.Dal.Entities;
using Combi.Dal.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combi.Dal.Repositories
{
    public class DemoRepository: IDemoRepository
    {
        private readonly CombiDbContext context;

        public DemoRepository(CombiDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Demo> GetAll()
        {
            return context.Demos;
        }
    }
}
