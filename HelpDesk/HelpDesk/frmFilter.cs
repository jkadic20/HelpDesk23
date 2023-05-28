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
    public partial class frmFilter : Form {
        PodnositeljZahtjeva PrijavljenPZ = null;
        DjelatnikCIP PrijavljenDCIP = null;

        /// <summary>
        /// Konstruktor prenosi jednu grupu korisnika
        /// </summary>
        /// <param name="prijenosPZ">Korisnik grupe podnositelj zahtjeva</param>
        /// <param name="prijenosDCIP">Korisnik grupe djelatnik CIP-a</param>
        public frmFilter(PodnositeljZahtjeva prijenosPZ = null, DjelatnikCIP prijenosDCIP = null) {
            InitializeComponent();
            if (prijenosPZ != null) {
                PrijavljenPZ = prijenosPZ;
            } else {
                PrijavljenDCIP = prijenosDCIP;
            }
        }

        private void btnPotvrdiFIlter_Click(object sender, EventArgs e) {
            var FilterZP = txtZahtjevPreuzeo.Text;
            var FilterP = txtPrioritet.Text;
            var FilterS = txtStatus.Text;

            List<Zahtjev> lista = null;

            RepozitorijZahtjevi Zahtjevi = new RepozitorijZahtjevi();

            if (PrijavljenPZ == null) {
                lista = Zahtjevi.DohvatiFiltriranuListuDjelatnik(FilterZP, FilterP, FilterS);
            }
            else {
                lista = Zahtjevi.DohvatiFiltriranuListuPodnositeljZahtjeva(PrijavljenPZ.id, FilterZP, FilterP, FilterS);
            }

            frmLista frmLista = new frmLista(PrijavljenPZ, PrijavljenDCIP, lista);
            Hide();
            frmLista.ShowDialog();
            Close();

        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            frmLista frmLista = new frmLista(PrijavljenPZ, PrijavljenDCIP);
            Hide();
            frmLista.ShowDialog();
            Close();
        }
    }
}
