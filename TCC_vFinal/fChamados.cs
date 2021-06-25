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
    public partial class fChamados : Form
    {
        public fChamados()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///// IR PARA TELA INICIAL DE TODOS OS FUNCIONARIOS
            ///

            this.Hide();
            Form f = new fIndexSO();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
       


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///// LOGOUT
            ///

            this.Hide();
            Form f = new fIndex();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnBusquecod_Click(object sender, EventArgs e)
        {
            ////// IR PARA TELA DE BUSCAR PROTOCOLO/CODIGO
            fVisuChamados OForm = new fVisuChamados();
            OForm.ShowDialog();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ///// LIMPA TODOS CAMPOS
            ///

            txtCodigo.Text = "";
            txtNome.Text = "";
            mTxtBoxTelefone.Text = ""; // telefone
            mtxtboxDataHora.Text = "";
            cbxSetores.SelectedIndex = -1;
            txtTitulo.Text = "";
            richtxtDescricao.Text = "";
            txtEmail.Text = "";
            txtStatus.Text = "";
            rtxtbixObservacoes.Text = "";
            cbxCategoria.SelectedIndex = -1;
            cbxUrgencia.SelectedIndex = -1;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ////// CONSULTAR/ALTERAR INFO DO PROPRIO CHAMADO
            ///

            string connStr = "server=localhost;user=root;database=tcc;port=3306;password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
                // Perform database operations
                string sql = "SELECT nome, categoria, urgencia, telefone, setor, titulo, descricao, email," +
                    "situacao, observacoes, datahora FROM chamado WHERE codigo = " + txtCodigo.Text;

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtNome.Text = rdr[0].ToString();
                    cbxCategoria.Text = rdr[1].ToString();
                    cbxUrgencia.Text = rdr[2].ToString();
                    mTxtBoxTelefone.Text = rdr[3].ToString();
                    cbxSetores.Text = rdr[4].ToString();
                    txtTitulo.Text = rdr[5].ToString();
                    richtxtDescricao.Text = rdr[6].ToString();
                    txtEmail.Text = rdr[7].ToString();
                    txtStatus.Text = rdr[8].ToString();
                    rtxtbixObservacoes.Text = rdr[9].ToString();
                    mtxtboxDataHora.Text = rdr[10].ToString();
                }
                else
                    MessageBox.Show("Código não encontrado...");
                rdr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve digitar um código válido!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //////ALTERAR OS DADOS DO PROPRIO CHAMADO

            DialogResult resp =
           MessageBox.Show("Confirmar alteração", "Arial",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                //método que alterar
                string connStr = "server=localhost;user=root;database=tcc;port=3306;password='';";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {
                    conn.Open();
                    // Perform database operations
                    string sql = "UPDATE chamado set nome ='" + txtNome.Text + "', categoria ='" + cbxCategoria.Text + "'," +
                        " urgencia ='" + cbxUrgencia.Text + "', telefone = '" + mTxtBoxTelefone.Text + "', datahora = '"
                        + mtxtboxDataHora.Text + "', setor = '"
                        + cbxSetores.Text + "', titulo = '" + txtTitulo.Text + "', descricao = '" + richtxtDescricao.Text +
                        "' , email = '" + txtEmail.Text + "'  WHERE codigo = "
                        + txtCodigo.Text;
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    int qtd = cmd.ExecuteNonQuery();
                    if (qtd == 1)
                    {
                        MessageBox.Show(" Dados alterados...");
                    }
                    else
                    {
                        MessageBox.Show("Erro - dados não alterados...");
                    }
                    conn.Close();
                }
                catch (Exception)
                {
                    if (txtCodigo.Text == "")
                    {

                        MessageBox.Show("Você deve digitar um código válido!");
                    }

                }
            }
            txtCodigo.Text = "";
            txtNome.Text = "";
            mTxtBoxTelefone.Text = ""; // telefone
            mtxtboxDataHora.Text = "";
            cbxSetores.SelectedIndex = -1;
            txtTitulo.Text = "";
            richtxtDescricao.Text = "";
            txtEmail.Text = "";
            txtStatus.Text = "";
            rtxtbixObservacoes.Text = "";
            cbxCategoria.SelectedIndex = -1;
            cbxUrgencia.SelectedIndex = -1;

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = Regex.Replace(txtCodigo.Text, "[^0-9]", "");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para alterar alguma informação no chamado é necessário realizar a busca tendo seu protocolo de chamado!");

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

        private void btnAviso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para consultar/ alterar alguma informação no chamado é necessário realizar a busca tendo seu protocolo de chamado!");

        }
    }
}
