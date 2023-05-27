using HelpDesk.Models;
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
    public partial class frmHomeKorisnik : Form {
        PodnositeljZahtjeva Prijavljen = null;
        public frmHomeKorisnik(PodnositeljZahtjeva prijenos) {
            InitializeComponent();
            Prijavljen = prijenos;
        }

        private void frmHomeKorisnik_Load(object sender, EventArgs e) {
            PromjenaTeksta();
        }

        private void PromjenaTeksta() {
            txtUsername.Text = Prijavljen.korisnickoIme;
        }

        private void btnOdjava_Click(object sender, EventArgs e) {
            frmLogin frmPrijava = new frmLogin();
            Hide();
            frmPrijava.ShowDialog();
            Close();
        }

        private void btnNoviZahtjev_Click(object sender, EventArgs e) {
            MessageBox.Show("Funkcija nije planirana u ovoj verziji!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnMojiZahtjevi_Click(object sender, EventArgs e) {
            frmLista frmZahtjevi = new frmLista(Prijavljen);
            Hide();
            frmZahtjevi.ShowDialog();
            Close();
        }
    }
}
