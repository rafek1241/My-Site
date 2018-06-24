using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySite.Server.Repositories
{
    public abstract class Repository
    {
        protected readonly MySiteContext db;

        public Repository(MySiteContext context)
        {
            db = context;
        }
    }
}
