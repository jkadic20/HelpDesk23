using HelpDesk.Models;
using HelpDesk.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk {
    public partial class frmLista : Form {
        PodnositeljZahtjeva PrijavljenPZ = null;
        DjelatnikCIP PrijavljenDCIP = null;
        List<Zahtjev> filtriranaLista = null;
        /// <summary>
        /// Konstruktor prenosi jednu grupu korisnika
        /// </summary>
        /// <param name="prijenosPZ">Korisnik grupe podnositelj zahtjeva</param>
        /// <param name="prijenosDCIP">Korisnik grupe djelatnik CIP-a</param>
        /// <param name="filter">Prijenos filtrirane liste</param>
        public frmLista(PodnositeljZahtjeva prijenosPZ=null, DjelatnikCIP prijenosDCIP=null, List<Zahtjev> filter=null) {
            InitializeComponent();
            if (prijenosPZ != null) {
                PrijavljenPZ = prijenosPZ;
            } else {
                PrijavljenDCIP = prijenosDCIP;
            }
            filtriranaLista = filter;
        }

        private void frmLista_Load(object sender, EventArgs e) {
            PrikaziZahtjeve();
        }

        /// <summary>
        /// Funkcija koja prikaže sve zahtjeve za koje korisnik ima prava
        /// </summary>
        private void PrikaziZahtjeve() {
            RepozitorijZahtjevi repoZahtjevi = new RepozitorijZahtjevi();
            if (filtriranaLista != null) {
                dgvLista.DataSource = filtriranaLista;
            }

            if (PrijavljenPZ == null) {
                if (filtriranaLista == null) {
                    var lista = repoZahtjevi.DohvatiZahtjevDjelatnik();
                    dgvLista.DataSource = lista;
                }
                btnUrediPonovnoPosalji.Text = "Uredi";
            }

            else {
                if (filtriranaLista == null) {
                    var lista = repoZahtjevi.DohvatiZahtjevPodnositeljZahtjeva(PrijavljenPZ.id);
                    dgvLista.DataSource = lista;
                }
                btnUrediPonovnoPosalji.Text = "Ponovno pošalji";
            }

            dgvLista.Columns["Id"].DisplayIndex = 0;
            dgvLista.Columns["VrijemeKreiranja"].DisplayIndex = 1;
            dgvLista.Columns["ZahtjevPreuzeo"].DisplayIndex = 2;
            dgvLista.Columns["Prioritet"].DisplayIndex = 3;
            dgvLista.Columns["Status"].DisplayIndex = 4;
            dgvLista.Columns["Opis"].DisplayIndex = 5;
            dgvLista.Columns["Komentar"].DisplayIndex = 6;
        }

        private void btnPovratak_Click(object sender, EventArgs e) {
            if (PrijavljenPZ == null) {
                frmHomeDjelatnik frmPocetniIzbornik = new frmHomeDjelatnik(PrijavljenDCIP);
                Hide();
                frmPocetniIzbornik.ShowDialog();
                Close();
            } else {
                frmHomeKorisnik frmPocetniIzbornik = new frmHomeKorisnik(PrijavljenPZ);
                Hide();
                frmPocetniIzbornik.ShowDialog();
                Close();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e) {
            frmFilter frmFilter = new frmFilter(PrijavljenPZ, PrijavljenDCIP);
            Hide();
            frmFilter.ShowDialog();
            Close();
        }

        private void btnUrediPonovnoPosalji_Click(object sender, EventArgs e) {
            if (PrijavljenPZ == null) {
                Zahtjev odabraniZahtjev = dgvLista.CurrentRow.DataBoundItem as Zahtjev;
                frmUrediZahtjev frmUrediZahtjev = new frmUrediZahtjev(PrijavljenDCIP, odabraniZahtjev);
                Hide();
                frmUrediZahtjev.ShowDialog();
                Close();
            }
            else {
                Zahtjev odabraniZahtjev = dgvLista.CurrentRow.DataBoundItem as Zahtjev;
                frmPonoviZahtjev frmPonoviZahtjev = new frmPonoviZahtjev(PrijavljenPZ, odabraniZahtjev);
                Hide();
                frmPonoviZahtjev.ShowDialog();
                Close();
            }
        }
    }
}
