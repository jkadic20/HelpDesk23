using DBLayer;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Repositories {

    /// <summary>
    /// Klasa za dohvaćanje zahtjeva iz baze
    /// </summary>
    public class RepozitorijZahtjevi {

        /// <summary>
        /// Funkcija za listu filtriranih zahtjeva grupe korisnika djelatnik CIP-a
        /// </summary>
        /// <param name="imePr">Preuzimatelj zahtjeva</param>
        /// <param name="prioritet">Prioritet zahtjeva</param>
        /// <param name="status">Status zahtjeva</param>
        /// <returns>Listu zahtjeva</returns>
        public List<Zahtjev> DohvatiFiltriranuListuDjelatnik(string imePr="", string prioritet="", string status="") {
            var lista = new List<Zahtjev>();
            string sql;

            if (imePr == "" && prioritet == "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE Status = '{status}'";
            } else if (imePr == "" && prioritet != "" && status == "") {
                sql = $"SELECT * FROM Zahtjev WHERE Prioritet = '{prioritet}'";
            } else if (imePr != "" && prioritet == "" && status == "") {
                sql = $"SELECT * FROM Zahtjev WHERE ZahtjevPreuzeo = '{imePr}'";
            } else if (imePr != "" && prioritet != "" && status == "") {
                sql = $"SELECT * FROM Zahtjev WHERE ZahtjevPreuzeo = '{imePr}' AND Prioritet = '{prioritet}'";
            } else if (imePr != "" && prioritet == "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE ZahtjevPreuzeo = '{imePr}' AND Status = '{status}'";
            } else if (imePr == "" && prioritet != "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE Prioritet = '{prioritet}' AND Status = '{status}'";
            } else if (imePr != "" && prioritet != "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE Prioritet = '{prioritet}' AND Status = '{status}' AND ZahtjevPreuzeo = '{imePr}'";
            } else {
                sql = $"SELECT * FROM Zahtjev";
            }

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev zahtjev = KreirajObjektZahtjeva(reader);
                lista.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;
        }

        /// <summary>
        /// Funkcija za listu filtriranih zahtjeva grupe korisnika podnositelji zahtjeva
        /// </summary>
        /// <param name="imePr">Preuzimatelj zahtjeva</param>
        /// <param name="prioritet">Prioritet zahtjeva</param>
        /// <param name="status">Status zahtjeva</param>
        /// <param name="id">Id korisnika koji je filtrirao</param>
        /// <returns>Listu zahtjeva</returns>
        public List<Zahtjev> DohvatiFiltriranuListuPodnositeljZahtjeva(int id, string imePr="", string prioritet="", string status="") {
            var lista = new List<Zahtjev>();
            string sql;

            if (imePr == "" && prioritet == "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE Status = '{status}' AND KorisnikIdKorisnika = '{id}'";
            } else if (imePr == "" && prioritet != "" && status == "") {
                sql = $"SELECT * FROM Zahtjev WHERE Prioritet = '{prioritet}' AND KorisnikIdKorisnika = '{id}'";
            } else if (imePr != "" && prioritet == "" && status == "") {
                sql = $"SELECT * FROM Zahtjev WHERE ZahtjevPreuzeo = '{imePr}' AND KorisnikIdKorisnika = '{id}'";
            } else if (imePr != "" && prioritet != "" && status == "") {
                sql = $"SELECT * FROM Zahtjev WHERE ZahtjevPreuzeo = '{imePr}' AND Prioritet = '{prioritet}' AND KorisnikIdKorisnika = '{id}'";
            } else if (imePr != "" && prioritet == "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE ZahtjevPreuzeo = '{imePr}' AND Status = '{status}' AND KorisnikIdKorisnika = '{id}'";
            } else if (imePr == "" && prioritet != "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE Prioritet = '{prioritet}' AND Status = '{status}' AND KorisnikIdKorisnika = '{id}'";
            } else if (imePr != "" && prioritet != "" && status != "") {
                sql = $"SELECT * FROM Zahtjev WHERE Prioritet = '{prioritet}' AND Status = '{status}' AND ZahtjevPreuzeo = '{imePr}' AND KorisnikIdKorisnika = '{id}'";
            } else {
                sql = $"SELECT * FROM Zahtjev WHERE KorisnikIdKorisnika = '{id}'";
            }

            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev zahtjev = KreirajObjektZahtjeva(reader);
                lista.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;


        }

        /// <summary>
        /// Funkcija za listu svih zahtjeva za djelatnike
        /// </summary>
        /// <returns>Listu zahtjeva</returns>
        public List<Zahtjev> DohvatiZahtjevDjelatnik() {
            var lista = new List<Zahtjev>();

            string sql = $"SELECT * FROM Zahtjev";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while(reader.Read()) {
                Zahtjev zahtjev = KreirajObjektZahtjeva(reader);
                lista.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;

        }

        /// <summary>
        /// Funkcija za listu zahtjeva jednog podnositelja zahtjeva
        /// </summary>
        /// <param name="id">Id podnositelja zahtjeva</param>
        /// <returns>Listu zahtjeva</returns>
        public List<Zahtjev> DohvatiZahtjevPodnositeljZahtjeva(int id) {
            var lista = new List<Zahtjev>();

            string sql = $"SELECT * FROM Zahtjev WHERE KorisnikIdKorisnika = '{id}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read()) {
                Zahtjev zahtjev = KreirajObjektZahtjeva(reader);
                lista.Add(zahtjev);
            }

            reader.Close();
            DB.CloseConnection();

            return lista;
        }

        /// <summary>
        /// Funkcija koja kreira jedan objekt zahtjeva
        /// </summary>
        /// <param name="reader">Čitač sql naredbi</param>
        /// <returns>Instancu zahtjeva</returns>
        private Zahtjev KreirajObjektZahtjeva(SqlDataReader reader) {
            int Id = int.Parse(reader["BrojZahtjeva"].ToString());
            DateTime VrijemeKreiranja = DateTime.Parse(reader["VrijemeKreiranja"].ToString());
            string ZahtjevPreuzeo = reader["ZahtjevPreuzeo"].ToString();
            string Prioritet = reader["Prioritet"].ToString();
            string Status = reader["Status"].ToString();
            string Opis = reader["Opis"].ToString();
            string Komentar = reader["Komentar"].ToString();

            var zahtjev = new Zahtjev {
                id = Id,
                vrijemeKreiranja = VrijemeKreiranja,
                zahtjevPreuzeo = ZahtjevPreuzeo,
                prioritet = Prioritet,
                status = Status,
                opis = Opis,
                komentar = Komentar
            };

            return zahtjev;

        }
    }
}
