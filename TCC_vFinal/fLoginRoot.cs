using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace TCC_vFinal
{
    public partial class fLoginRoot : Form
    {

        MySqlConnection con = new MySqlConnection("server = localhost; user=root;database=tcc;port=3306;password='';");
        int i;
        public fLoginRoot()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from root where usuario = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)
            {
                lblAviso.Text = ("Usuário ou Login inválidos!");
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }

            else
            {
                fRoot OForm = new fRoot();
                OForm.Show();
                this.Visible = false;
            }

            con.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            fIndex OForm = new fIndex();
            OForm.Show();
            this.Visible = false;
        }
    }
}
