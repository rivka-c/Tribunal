using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Shred.Models
{
    public partial class TribunalContext : DbContext
    {
        public virtual DbSet<CaseEntity> Cases { get; set; }
    }
}
