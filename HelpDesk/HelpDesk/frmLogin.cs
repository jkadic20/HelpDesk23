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

namespace HelpDesk
{
    public partial class frmLogin : Form
    {
        public DjelatnikCIP PrijavaDjelatnika = new DjelatnikCIP();
        public PodnositeljZahtjeva PrijavaPodnositeljaZahtjeva = new PodnositeljZahtjeva();

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
                korisnik pomKorisnik = new korisnik();
                pomKorisnik = Korisnik.DohvatiKorisnikaLozinka(korIme, loznika);
                if (pomKorisnik == null) {
                    MessageBox.Show("Netocni podaci, ponovite unos!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (pomKorisnik.prava) {
                        PrijavaDjelatnika = (DjelatnikCIP)pomKorisnik;
                        frmHomeDjelatnik frmDjelatnik = new frmHomeDjelatnik(PrijavaDjelatnika);
                        Hide();
                        frmDjelatnik.ShowDialog();
                        Close();
                    } else {
                        PrijavaPodnositeljaZahtjeva = (PodnositeljZahtjeva)pomKorisnik;
                        frmHomeKorisnik frmKorisnik = new frmHomeKorisnik(PrijavaPodnositeljaZahtjeva);
                        Hide();
                        frmKorisnik.ShowDialog();
                        Close();
                    }
                }
            }
        }
    }
}
