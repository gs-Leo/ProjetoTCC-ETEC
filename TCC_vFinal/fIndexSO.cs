using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCC_vFinal
{
    public partial class fIndexSO : Form
    {
        public fIndexSO()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fCriarChamados();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fChamados();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fIndex();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
