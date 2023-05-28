using DBLayer;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Repositories {

    /// <summary>
    /// Klasa za opcije uređivanja i ponovnog slanja zahtjeva
    /// </summary>
    public class RepozitorijUredivanjePonovnoSlanje {

        /// <summary>
        /// Funkcija koja uređuje bazu s proslijeđenim podatcima
        /// </summary>
        /// <param name="uredeniZahtjev">Objekt zahtjeva čiji se podatci preslikavaju u bazu</param>
        public void urediBazu(Zahtjev uredeniZahtjev) {
            var sql = $"UPDATE Zahtjev SET Prioritet = '{uredeniZahtjev.prioritet}', Status = '{uredeniZahtjev.status}', Komentar = '{uredeniZahtjev.komentar}' WHERE BrojZahtjeva = '{uredeniZahtjev.id.ToString()}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
