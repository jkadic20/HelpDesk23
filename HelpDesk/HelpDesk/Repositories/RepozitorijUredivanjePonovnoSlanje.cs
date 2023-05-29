using DBLayer;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Repositories {

    /// <summary>
    /// Klasa za opcije uređivanja i ponovnog slanja zahtjeva koja radi s bazom
    /// </summary>
    public class RepozitorijUredivanjePonovnoSlanje {

        /// <summary>
        /// Funkcija koja uređuje bazu s proslijeđenim podatcima
        /// </summary>
        /// <param name="uredeniZahtjev">Objekt zahtjeva čiji se podatci preslikavaju u bazu</param>
        public void urediBazu(Zahtjev uredeniZahtjev) {
            var sql = $"UPDATE Zahtjev SET Prioritet = '{uredeniZahtjev.prioritet}', Status = '{uredeniZahtjev.status}', Komentar = '{uredeniZahtjev.komentar}', ZahtjevPreuzeo = '{uredeniZahtjev.zahtjevPreuzeo}', ZahtjevIdDjelatnika = '{uredeniZahtjev.zahtjevIdDjelatnika}' WHERE BrojZahtjeva = '{uredeniZahtjev.id.ToString()}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /// <summary>
        /// Funkcija koja briše zahtjev u bazi
        /// </summary>
        /// <param name="uredeniZahtjev">Zahtjev koji brišemo</param>
        public void obrisiBazu(Zahtjev uredeniZahtjev) {
            var sql = $"DELETE FROM Zahtjev WHERE BrojZahtjeva = '{uredeniZahtjev.id}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        /// <summary>
        /// FUnkcija koja dodaje u bazu ponovno poslani zahtjev
        /// </summary>
        /// <param name="noviZahtjev">Novo poslani zahtjev</param>
        public void ponoviSlanje(Zahtjev noviZahtjev) {
            var sql = $"INSERT INTO Zahtjev VALUES ('{noviZahtjev.id}', '{noviZahtjev.vrijemeKreiranja.ToString()}', '{noviZahtjev.zahtjevPreuzeo}', '{noviZahtjev.prioritet}', '{noviZahtjev.status}', '{noviZahtjev.opis}', '{noviZahtjev.komentar}', '{noviZahtjev.korisnikIdKorisnika}', '{noviZahtjev.zahtjevIdDjelatnika}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
