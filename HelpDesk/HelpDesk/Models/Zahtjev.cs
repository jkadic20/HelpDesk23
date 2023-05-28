using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models {

    /// <summary>
    /// Klasa za zahtjeve
    /// </summary>
    public class Zahtjev {
        public int id { get; set; }
        public DateTime vrijemeKreiranja { get; set; }
        public string zahtjevPreuzeo { get; set; }
        public string prioritet { get; set; }
        public string status { get; set; }
        public string opis { get; set; }
        public string komentar { get; set; }
    }
}
