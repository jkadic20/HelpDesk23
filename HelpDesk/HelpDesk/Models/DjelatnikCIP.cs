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
        /// Funkcija koja izmijeni podatke zahtjeva s unesenim
        /// </summary>
        /// <param name="promjenjeniZahtjev">Zahtjev koji će se promijeniti</param>
        /// <param name="prioritet">Novi prioritet zahtjeva</param>
        /// <param name="status">Novi status zahtjeva</param>
        /// <param name="komentar">Novi komentar zahtjeva</param>
        public void urediZahtjev(Zahtjev promjenjeniZahtjev, string prioritet = null, string status = null, string komentar = null) {
            promjenjeniZahtjev.prioritet = prioritet;
            promjenjeniZahtjev.status = status;
            promjenjeniZahtjev.komentar = komentar;
            
        }
    }
}
