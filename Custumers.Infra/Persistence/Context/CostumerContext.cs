using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custumers.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Custumers.Infra.Persistence.Context
{
    public class CostumerContext: DbContext
    {
        public CostumerContext(DbContextOptions<CostumerContext> opts): base(opts) { }

        public DbSet<CostumerEntity> Costumers { get; set; }
    }
}
