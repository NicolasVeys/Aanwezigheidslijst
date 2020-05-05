using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aanwezigheidslijst
{
    public class Deelnemer
    {
        [Key]
        public int Id { get; set; }
        public string Naam { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Woonplaats { get; set; }
        public int BadgeNummer { get; set; }
        public virtual List<Tijdsregistratie> Tijdsregistraties { get; set; }

    }
}
