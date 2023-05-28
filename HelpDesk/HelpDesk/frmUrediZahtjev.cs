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
    public partial class frmUrediZahtjev : Form {
        DjelatnikCIP urednik = null;
        Zahtjev uredivaniZahtjev = null;
        public frmUrediZahtjev(DjelatnikCIP prijenosDCIP, Zahtjev odabraniZahtjev) {
            InitializeComponent();
            urednik = prijenosDCIP;
            uredivaniZahtjev= odabraniZahtjev;
        }

        private void frmUrediZahtjev_Load(object sender, EventArgs e) {
            lblIdZahtjeva.Text = uredivaniZahtjev.id.ToString();
            lblVrijemeKreiranja.Text = uredivaniZahtjev.vrijemeKreiranja.ToString();
            lblPreuzeo.Text = uredivaniZahtjev.zahtjevPreuzeo;
            txtOpis.Text = uredivaniZahtjev.opis;
            txtPrioritet.Text = uredivaniZahtjev.prioritet;
            txtStatus.Text = uredivaniZahtjev.status;
            txtKomentar.Text = uredivaniZahtjev.komentar;
        }

        private void btnSpremi_Click(object sender, EventArgs e) {
            RepozitorijUredivanjePonovnoSlanje uredivanjeBaze = new RepozitorijUredivanjePonovnoSlanje();
            urednik.urediZahtjev(uredivaniZahtjev, txtPrioritet.Text, txtStatus.Text, txtKomentar.Text);
            uredivanjeBaze.urediBazu(uredivaniZahtjev);
            frmLista frmLista = new frmLista(null, urednik);
            Hide();
            frmLista.ShowDialog();
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            frmLista frmLista = new frmLista(null, urednik);
            Hide();
            frmLista.ShowDialog();
            Close();
        }
    }
}
