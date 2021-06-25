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
    public partial class fIndex : Form
    {
        
        public fIndex()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginGeral_Click(object sender, EventArgs e)
        {
            
                fLoginGeral OForm = new fLoginGeral();
                OForm.Show();
                this.Visible = false;
        }

        private void btnHelpDesk_Click(object sender, EventArgs e)
        {
            fLoginRoot OForm = new fLoginRoot();
            OForm.Show();
            this.Visible = false;
        }

        private void pbRoot_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
    

