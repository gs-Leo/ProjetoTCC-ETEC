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
    public partial class fCriarChamados : Form
    {
        public fCriarChamados()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new fIndex();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///// IR PARA TELA INICIAL DE TODOS OS FUNCIONARIOS
            ///

            this.Hide();
            Form f = new fIndexSO();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ConsultarChamadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /////IR CONSULTAR/ALTERAR CHAMADO
            ///

            this.Hide();
            Form f = new fChamados();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnchamado_Click(object sender, EventArgs e)
        {
            ///////ABRIR CHAMADO

            string connStr = "server=localhost;user=root;database=tcc;password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                 if (txtNome.Text == "" || cbxSetores.Text == "")
                {
                   MessageBox.Show("Nome ou setor em branco, preenche - o!");

                }
                else if (txtUsuário.Text.Length < 11)
                {
                    MessageBox.Show ("Digite todo os caracteres do Login!");

                }

                else
                {

                    conn.Open();
                    // Perform database operations
                    string sql = " INSERT INTO chamado (nome, usuario,  telefone, setor, titulo," +
                    " descricao, email,situacao, datahora) VALUES ('" + txtNome.Text + "', '" + txtUsuário.Text + "', '" + mTxtBoxTelefone.Text + "', " + "' " + cbxSetores.Text
                    + "', ' " + txtTitulo.Text + "', ' " + richtxtDescricao.Text + "', ' " + txtEmail.Text + "' , ' " + "Aberto " + "', ' " + mtxtboxDataHora.Text + "' ) ";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chamado Aberto");

                    ////limparcaixas
                    //  txtCodigo.Text = "";
                    txtNome.Text = "";
                    txtUsuário.Text = "";
                    
                    mTxtBoxTelefone.Text = ""; // telefone
                    cbxSetores.Text = "";
                    txtTitulo.Text = "";
                    richtxtDescricao.Text = "";
                    txtEmail.Text = "";
                    txtUsuário.Text = "";
                    //cbxSituacao.Text = "";
                    mtxtboxDataHora.Text = "";
                    /////
                    //////// limpar combos
                    
                    cbxSetores.SelectedIndex = -1;
                    //cbxSituacao.SelectedIndex = -1;
                    ////
                }


            }


            catch (Exception ex)
            {

                MessageBox.Show("" + ex);


            }
        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {
            txtUsuário.Text = Regex.Replace(txtUsuário.Text, "[^0-9]", "");
        }

        private void btnConsulChamado_Click(object sender, EventArgs e)
        {
            /////IR CONSULTAR/ALTERAR CHAMADO
            ///

            this.Hide();
            Form f = new fChamados();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ///// IR PARA TELA INICIAL DE TODOS OS FUNCIONARIOS
            ///

            this.Hide();
            Form f = new fIndexSO();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //// LOGOUT
            ///

            this.Hide();
            Form f = new fIndex();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
    
}
