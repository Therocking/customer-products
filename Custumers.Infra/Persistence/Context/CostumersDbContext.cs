using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Custumers.Infra.Persistence.Context
{
    public interface ICostumersDbContext: IDbContext { }
    public class CostumersDbContext: DbContext
    {
        public CostumersDbContext(DbContextOptions<CostumersDbContext> options) : base(options) { }

    }
}
