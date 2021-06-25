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
    public partial class fIndexHelpDesk : Form
    {
        public fIndexHelpDesk()
        {
            InitializeComponent();
        }

        private void btnTodosChamados_Click(object sender, EventArgs e)
        {
            fHdTodosChamados OForm = new fHdTodosChamados();
            OForm.ShowDialog();
        }

        private void btnEspecifico_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fHpBuscaEspecifica();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

      

       

        private void btnChamadosFechados_Click(object sender, EventArgs e)
        {
            fHdControle OForm = new fHdControle();
            OForm.ShowDialog();
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
