using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models {

    /// <summary>
    /// Klasa grupe korisnika podnositelji zahtjeva
    /// </summary>
    public class PodnositeljZahtjeva : korisnik {

        /// <summary>
        /// Funkcija koja iskoristi postojeći zatvoren zahtjev i napravi novi s novim opisom
        /// </summary>
        /// <param name="ponovljeniZahtjev">Zahtjev koji se ponavlja</param>
        /// <param name="opis">Novi opis zahtjeva</param>
        /// <returns></returns>
        public Zahtjev ponoviZahtjev (Zahtjev ponovljeniZahtjev, string opis) {
            Zahtjev ponovniZahtjev = new Zahtjev {
                opis = opis,
                id = ponovljeniZahtjev.id,
                vrijemeKreiranja = ponovljeniZahtjev.vrijemeKreiranja               
            };
            return ponovniZahtjev;
        }
    }
}
