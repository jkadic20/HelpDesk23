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
    public class RepozitorijZahtjevi {
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
