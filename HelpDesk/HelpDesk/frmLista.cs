using HelpDesk.Models;
using HelpDesk.Repositories;
using System;
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
        public frmLista(PodnositeljZahtjeva prijenosPZ=null, DjelatnikCIP prijenosDCIP=null) {
            InitializeComponent();
            if (prijenosPZ != null) {
                PrijavljenPZ = prijenosPZ;
            } else {
                PrijavljenDCIP = prijenosDCIP;
            }
        }

        private void frmLista_Load(object sender, EventArgs e) {
            PrikaziZahtjeve();
        }

        private void PrikaziZahtjeve() {
            RepozitorijZahtjevi repoZahtjevi = new RepozitorijZahtjevi();
            if (PrijavljenPZ == null) {
                var lista = repoZahtjevi.DohvatiZahtjevDjelatnik();
                dgvLista.DataSource = lista;
                btnUrediPonovnoPosalji.Text = "Uredi";
            }

            else {
                var lista = repoZahtjevi.DohvatiZahtjevPodnositeljZahtjeva(PrijavljenPZ.id);
                dgvLista.DataSource = lista;
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
    }
}
