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
            if (uredivaniZahtjev.status == "zaprimljen") {
                btnSpremi.Text = "Preuzmi zahtjev";
            }
            lblIdZahtjeva.Text = uredivaniZahtjev.id.ToString();
            lblVrijemeKreiranja.Text = uredivaniZahtjev.vrijemeKreiranja.ToString();
            lblPreuzeo.Text = uredivaniZahtjev.zahtjevPreuzeo;
            txtOpis.Text = uredivaniZahtjev.opis;
            txtPrioritet.Text = uredivaniZahtjev.prioritet;
            txtStatus.Text = uredivaniZahtjev.status;
            txtKomentar.Text = uredivaniZahtjev.komentar;
        }

        private void btnSpremi_Click(object sender, EventArgs e) {
            if (!provjeriUnosPrioriteta(txtPrioritet.Text.Trim())) {
                MessageBox.Show("Nedozvoljena vrijednost polja prioritet!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (!provjeriUnosStatusa(txtStatus.Text.Trim())) {
                MessageBox.Show("Nedozvoljena vrijednost polja status!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                RepozitorijUredivanjePonovnoSlanje uredivanjeBaze = new RepozitorijUredivanjePonovnoSlanje();
                urednik.urediZahtjev(urednik, uredivaniZahtjev, txtPrioritet.Text, txtStatus.Text, txtKomentar.Text);
                uredivanjeBaze.urediBazu(uredivaniZahtjev);
                frmLista frmLista = new frmLista(null, urednik);
                Hide();
                frmLista.ShowDialog();
                Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            frmLista frmLista = new frmLista(null, urednik);
            Hide();
            frmLista.ShowDialog();
            Close();
        }

        private void btnObrisi_Click(object sender, EventArgs e) {
            RepozitorijUredivanjePonovnoSlanje uredivanjeBaze = new RepozitorijUredivanjePonovnoSlanje();
            uredivanjeBaze.obrisiBazu(uredivaniZahtjev);
            frmLista frmLista = new frmLista(null, urednik);
            Hide();
            frmLista.ShowDialog();
            Close();
        }


        /// <summary>
        /// Funkcija koja provjerava ispravnost unesenog prioriteta
        /// </summary>
        /// <param name="prioritet">Unos koji se provjerava</param>
        /// <returns></returns>
        private bool provjeriUnosPrioriteta(string prioritet) {
            bool provjera = false;

            switch (prioritet) {
                case "visok":
                    provjera = true;
                    break;
                case "srednji":
                    provjera = true;
                    break;
                case "niski":
                    provjera = true;
                    break;
                case "Visok":
                    provjera = true;
                    break;
                case "Srednji":
                    provjera = true;
                    break;
                case "Niski":
                    provjera = true;
                    break;
            }

            return provjera;
        }


        /// <summary>
        /// Funkcija koja provjerava ispravnost unesenog statusa
        /// </summary>
        /// <param name="status">Unos koji se provjerava</param>
        /// <returns></returns>
        private bool provjeriUnosStatusa(string status) {
            bool provjera = false;

            switch (status) {
                case "zatvoren":
                    provjera = true;
                    break;
                case "u postupku":
                    provjera = true;
                    break;
                case "odbijen":
                    provjera = true;
                    break;
                case "zaprimljen":
                    provjera = true;
                    break;
                case "Zatvoren":
                    provjera = true;
                    break;
                case "U postupku":
                    provjera = true;
                    break;
                case "Odbijen":
                    provjera = true;
                    break;
                case "Zaprimljen":
                    provjera = true;
                    break;
            }

            return provjera;
        }
    }
}
