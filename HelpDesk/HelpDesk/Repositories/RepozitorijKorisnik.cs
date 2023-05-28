using DBLayer;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDesk.Repositories {

    /// <summary>
    /// Klasa za provjere korisnika u bazi
    /// </summary>
    public class RepozitorijKorisnik {

        /// <summary>
        /// Funkcija koja vraća korisnika iz baze
        /// </summary>
        /// <param name="korIme">Korisničko ime</param>
        /// <param name="lozinka">Lozinka</param>
        /// <returns>Vraća korisnika ako je točna lozinka, a ako je netočna vraća null</returns>
        public korisnik DohvatiKorisnikaLozinka(string korIme, string lozinka) {
            korisnik dohvaceniKorisnik = null;
            string sql = $"SELECT * FROM Korisnik WHERE KorisnickoIme = '{korIme}' AND Lozinka = '{lozinka}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if(reader.HasRows) {
                reader.Read();
                dohvaceniKorisnik = KreirajObjektKorisnik(reader);
                reader.Close();
            }

            else {
                reader.Close();
                sql = $"SELECT * FROM DjelatnikCIPa WHERE KorisnickoIme = '{korIme}' AND Lozinka = '{lozinka}'";
                DB.OpenConnection();
                reader = DB.GetDataReader(sql);
                if (reader.HasRows) {
                    reader.Read();
                    dohvaceniKorisnik = KreirajObjektDjelatnik(reader);
                    reader.Close();
                }
                else {
                    dohvaceniKorisnik=null;
                    reader.Close();
                    return dohvaceniKorisnik;
                }
            }

            return dohvaceniKorisnik;
        }


        /// <summary>
        /// Funkcija koja vraća korisnika iz baze
        /// </summary>
        /// <param name="korIme">Korisnicko ime</param>
        /// <returns>Ako postoji korisnik u bazi vraća korisnika, ako ne vraća null</returns>
        public korisnik DohvatiKorisnika(string korIme) {
            korisnik dohvaceniKorisnik = null;
            string sql = $"SELECT * FROM Korisnik WHERE KorisnickoIme = '{korIme}'";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows) {
                reader.Read();
                dohvaceniKorisnik = KreirajObjektKorisnik(reader);
                reader.Close();
            } else {
                reader.Close();
                sql = $"SELECT * FROM DjelatnikCIPa WHERE KorisnickoIme = '{korIme}'";
                DB.OpenConnection();
                reader = DB.GetDataReader(sql);
                if (reader.HasRows) {
                    reader.Read();
                    dohvaceniKorisnik = KreirajObjektDjelatnik(reader);
                    reader.Close();
                } else {
                    dohvaceniKorisnik = null;
                    reader.Close();
                    return dohvaceniKorisnik;
                }
            }

            return dohvaceniKorisnik;
        }

        /// <summary>
        /// Funkcija koja kreira objekt grupe PodnositeljZahtjeva
        /// </summary>
        /// <param name="reader">sql reader za bazu</param>
        /// <returns>Vraća korisnika PodnositeljZahtjeva</returns>
        private korisnik KreirajObjektKorisnik (SqlDataReader reader){
            int Id = int.Parse(reader["IdKorisnika"].ToString());
            string korIme = reader["KorisnickoIme"].ToString();
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string Lozinka = reader["Lozinka"].ToString();
            bool Prava = bool.Parse(reader["Prava"].ToString());

            var Korisnik = new PodnositeljZahtjeva {
                id = Id,
                ime = Ime,
                prezime = Prezime,
                korisnickoIme = korIme,
                lozinka = Lozinka,
                prava = Prava
            };

            return Korisnik;
        }

        /// <summary>
        /// Funkcija koja kreira objekt grupe DjelatnikCIP
        /// </summary>
        /// <param name="reader">sql reader za bazu</param>
        /// <returns>Vraća korisnika DjelatnikCIP</returns>
        private korisnik KreirajObjektDjelatnik(SqlDataReader reader) {
            int Id = int.Parse(reader["IdDjelatnika"].ToString());
            string korIme = reader["KorisnickoIme"].ToString();
            string Ime = reader["Ime"].ToString();
            string Prezime = reader["Prezime"].ToString();
            string Lozinka = reader["Lozinka"].ToString();
            bool Prava = bool.Parse(reader["Prava"].ToString());

            var Djelatnik = new DjelatnikCIP {
                id = Id,
                ime = Ime,
                prezime = Prezime,
                korisnickoIme = korIme,
                lozinka = Lozinka,
                prava = Prava
            };

            return Djelatnik;
        }

    }
}
