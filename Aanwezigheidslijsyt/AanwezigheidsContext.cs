using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Aanwezigheidslijst
{
    class AanwezigheidsContext : DbContext
    {
        public DbSet<Deelnemer> Deelnemers { get; set; }
        public DbSet<Docent> Docenten { get; set; }
        public DbSet<Tijdsregistratie> Tijdsregistraties { get; set; }
    }
}
