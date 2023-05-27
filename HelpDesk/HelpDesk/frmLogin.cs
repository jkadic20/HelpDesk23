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

namespace HelpDesk
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e) {
           
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if(txtUsername.Text.Trim() == "") {
                MessageBox.Show("Unesite korisničko ime!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txtPassword.Text.Trim() == "") {
                MessageBox.Show("Unesite lozinku!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                RepozitorijKorisnik Korisnik = new RepozitorijKorisnik();
                string korIme = txtUsername.Text.Trim().ToString();
                string loznika = txtPassword.Text.Trim().ToString();
                //bool provjeraLozinke = bool.Parse(Korisnik.DohvatiKorisnika(korIme, loznika));
                if (Korisnik.DohvatiKorisnika(korIme, loznika) == null) {
                    MessageBox.Show("Netocni podaci!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    MessageBox.Show("Uspjesna prijava!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
