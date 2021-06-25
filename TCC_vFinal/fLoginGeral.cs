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
using System.Text.RegularExpressions;

namespace TCC_vFinal
{
    public partial class fLoginGeral : Form
    {
        MySqlConnection con = new MySqlConnection("server = localhost; user=root;database=tcc;port=3306;password='';");
        int i;
        public fLoginGeral()
        {
            InitializeComponent();
        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAcessar_Click_1(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server = localhost; user=root;database=tcc;port=3306;password='';");
                string sql = String.Format("Select * from funcionarios where usuario = '" + txtUsuario.Text + "' and senha = '" + txtSenha.Text + "' ");
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    string usuario = rdr[0].ToString();
                    string nome = rdr[1].ToString();
                    string setor = rdr[2].ToString();
                    string senha = rdr[3].ToString();


                    if (setor != "TI - Suporte")
                    {
                        fIndexSO OForm = new fIndexSO();
                        OForm.Show();
                        this.Visible = false;
                    }

                    else
                    {
                        fIndexHelpDesk OForm = new fIndexHelpDesk();
                        OForm.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario nao localizado no banco de dados");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            finally
            {
                con.Close();
            }
        }

            private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.Text = Regex.Replace(txtSenha.Text, "[^0-9]", "");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            txtUsuario.Text = Regex.Replace(txtUsuario.Text, "[^0-9]", "");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /////btnCancelar
            ////// Cancela logine  volta pro index
            fIndex OForm = new fIndex();
            OForm.Show();
            this.Visible = false;
        }
    }
}
