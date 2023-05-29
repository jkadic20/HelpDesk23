using HelpDesk.Repositories;
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
            RepozitorijZahtjevi repozitorijZahtjevi = new RepozitorijZahtjevi();
            DateTime vrijemeSlanja = DateTime.Now;
            Zahtjev ponovniZahtjev = new Zahtjev {
                opis = opis,
                status = "zaprimljen",
                id = repozitorijZahtjevi.dohvatiZadnjiZahtjevPoId(),
                vrijemeKreiranja = vrijemeSlanja,
                korisnikIdKorisnika = ponovljeniZahtjev.korisnikIdKorisnika,
                komentar = "nema komentara",
                prioritet = "",
                zahtjevIdDjelatnika = 0
            };
            return ponovniZahtjev;
        }
    }
}
