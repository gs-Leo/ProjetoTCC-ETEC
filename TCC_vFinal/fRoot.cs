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
    public partial class fRoot : Form
    {
        public fRoot()
        {
            InitializeComponent();
        }

       

        private void btnCadGeral_Click(object sender, EventArgs e)
        {
            fCadastrarFunc OForm = new fCadastrarFunc();
            OForm.Show();
            this.Visible = false;
        }

        private void btnCadHp_Click(object sender, EventArgs e)
        {
            fTodosFuncionarios OForm = new fTodosFuncionarios();
            OForm.Show();
            
        }

        private void btnIndexGeral_Click(object sender, EventArgs e)
        {
            fIndexSO OForm = new fIndexSO();
            OForm.ShowDialog();
        }

        private void btnIndexHp_Click(object sender, EventArgs e)
        {
            fIndexHelpDesk OForm = new fIndexHelpDesk();
            OForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fIndex();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
