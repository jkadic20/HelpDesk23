using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Models {

    /// <summary>
    /// Klasa grupe korisnika djelatnici CIP-a
    /// </summary>
    public class DjelatnikCIP : korisnik {

        /// <summary>
        /// Funkcija koja izmijeni podatke zahtjeva s unesenim, ako je status zaprimljen će preuzeti zahtjev
        /// </summary>
        /// <param name="promjenjeniZahtjev">Zahtjev koji će se promijeniti</param>
        /// <param name="prioritet">Novi prioritet zahtjeva</param>
        /// <param name="status">Novi status zahtjeva</param>
        /// <param name="komentar">Novi komentar zahtjeva</param>
        public void urediZahtjev(DjelatnikCIP urednik, Zahtjev promjenjeniZahtjev, string prioritet = null, string status = null, string komentar = null) {
            if (promjenjeniZahtjev.status == "zaprimljen" && status != "zaprimljen") {
                promjenjeniZahtjev.zahtjevIdDjelatnika = urednik.id;
                promjenjeniZahtjev.zahtjevPreuzeo = urednik.ime + " " + urednik.prezime;
            }
            promjenjeniZahtjev.prioritet = prioritet;
            promjenjeniZahtjev.status = status;
            promjenjeniZahtjev.komentar = komentar;
            
        }
    }
}
