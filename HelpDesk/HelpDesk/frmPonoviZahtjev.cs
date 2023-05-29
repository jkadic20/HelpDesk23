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
    public partial class frmPonoviZahtjev : Form {
        PodnositeljZahtjeva podnositelj = null;
        Zahtjev ponavljaniZahtjev = null;
        public frmPonoviZahtjev(PodnositeljZahtjeva prijenosPZ, Zahtjev odabraniZahtjev) {
            InitializeComponent();
            podnositelj = prijenosPZ;
            ponavljaniZahtjev = odabraniZahtjev;
        }

        private void btnOdustani_Click(object sender, EventArgs e) {
            frmLista frmLista = new frmLista(podnositelj);
            Hide();
            frmLista.ShowDialog();
            Close();
        }

        private void frmPonoviZahtjev_Load(object sender, EventArgs e) {
            if (ponavljaniZahtjev.status != "zatvoren") {
                btnPosalji.Enabled = false;
            } else {
                txtStatus.Text = "zaprimljen";
            }
        }

        private void btnPosalji_Click(object sender, EventArgs e) {
            RepozitorijUredivanjePonovnoSlanje uredivanjeBaze = new RepozitorijUredivanjePonovnoSlanje();
            Zahtjev noviZahtjev = podnositelj.ponoviZahtjev(ponavljaniZahtjev, txtOpis.Text);
            uredivanjeBaze.ponoviSlanje(noviZahtjev);
            frmLista frmLista = new frmLista(podnositelj);
            Hide();
            frmLista.ShowDialog();
            Close();
        }
    }
}
