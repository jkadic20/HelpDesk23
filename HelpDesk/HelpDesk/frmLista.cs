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
        public frmLista() {
            InitializeComponent();
        }

        private void frmLista_Load(object sender, EventArgs e) {
            PrikaziZahtjeve();
        }

        private void PrikaziZahtjeve() {
            RepozitorijZahtjevi repoZahtjevi = new RepozitorijZahtjevi();
            var lista = repoZahtjevi.DohvatiZahtjevDjelatnik();
            dgvLista.DataSource = lista;

            dgvLista.Columns["Id"].DisplayIndex = 0;
            dgvLista.Columns["VrijemeKreiranja"].DisplayIndex = 1;
            dgvLista.Columns["ZahtjevPreuzeo"].DisplayIndex = 2;
            dgvLista.Columns["Prioritet"].DisplayIndex = 3;
            dgvLista.Columns["Status"].DisplayIndex = 4;
            dgvLista.Columns["Opis"].DisplayIndex = 5;
            dgvLista.Columns["Komentar"].DisplayIndex = 6;
        }
    }
}
