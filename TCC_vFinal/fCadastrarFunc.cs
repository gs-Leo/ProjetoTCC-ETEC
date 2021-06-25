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
    public partial class fCadastrarFunc : Form
    {
        public fCadastrarFunc()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=tcc;port=3306;password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                

                if (txtUsuário.Text == "" || txtNome.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS!");

                }
                else if (txtUsuário.Text.Length < 11)
                {
                    MessageBox.Show("Digite todo os caracteres do Login");

                }

                else
                {
                        conn.Open();
                // Perform database operations
                string sql = "INSERT INTO funcionarios (nome, setor, usuario, senha) VALUES (  '" + txtNome.Text + "' " +
                    " , '" + cbxSetor.Text + "' ,'" + txtUsuário.Text + "' ,  '" + txtSenha.Text + "' ) ";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show (" Cadastrado.");

                txtNome.Clear();
                txtSenha.Clear();
                txtUsuário.Clear();
                cbxSetor.SelectedIndex = -1;

                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Usuário já existente!");
                //MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        private void fCadastrarFunc_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
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

                    if (txtUsuário.Text == "" || txtNome.Text == "" || txtSenha.Text == "")
                    {
                        MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS!");

                    }
                    else if (txtUsuário.Text.Length < 11)
                    {
                        MessageBox.Show("Digite todo os caracteres do Login!");

                    }
                    else
                    {
                        conn.Open();
                        // Perform database operations
                        string sql = ("UPDATE funcionarios set nome ='" + txtNome.Text + "', setor ='" + cbxSetor.Text + "'," +
                            " senha ='" + txtSenha.Text + "' WHERE usuario ='"
                            + txtUsuário.Text + "';");
                        MySqlCommand cmd = new MySqlCommand(sql, conn);

                        int qtd = cmd.ExecuteNonQuery();
                        if (qtd == 1)
                        {
                            MessageBox.Show(" Dados alterados...");
                            txtNome.Clear();
                            txtSenha.Clear();
                            txtUsuário.Clear();
                            cbxSetor.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("Erro - dados não alterados...");
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    if (txtUsuário.Text == "")
                    {

                        MessageBox.Show ("Você deve digitar um código válido!");
                    }
                    
                }
            }
        }
        

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=tcc;port=3306;password='';";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                if (txtUsuário.Text.Length < 11)
                {
                    MessageBox.Show("Digite todo os caracteres do Login!");

                }
                else
                {
                    conn.Open();
                    // Perform database operations
                    string sql = String.Format("SELECT nome, setor, senha FROM funcionarios WHERE usuario = '" + txtUsuário.Text + "';");

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        txtNome.Text = rdr[0].ToString();
                        cbxSetor.Text = rdr[1].ToString();
                        txtSenha.Text = rdr[2].ToString();
                    }
                    else
                        MessageBox.Show("Usuário não encontrado!");
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult resp =
                MessageBox.Show("Confirma exclusão?", "Arial",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                //método que exclui o cliente
                string connStr = "server=localhost;user=root;database=tcc;port=3306;password='';";
                MySqlConnection conn = new MySqlConnection(connStr);
                try
                {

                    if (txtUsuário.Text.Length < 11)
                    {
                        MessageBox.Show("Digite todo os caracteres do Login!");

                    }
                    else
                    {
                        conn.Open();
                        // Perform database operations
                        string sql = String.Format("DELETE FROM funcionarios WHERE usuario = '" + txtUsuário.Text + "';");
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        int qtd = cmd.ExecuteNonQuery();
                        if (qtd == 1)
                        {
                            MessageBox.Show("Usuário excluido...");
                        }
                        else
                        {
                            MessageBox.Show("Erro na exclusão...");
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            txtNome.Clear();
            txtSenha.Clear();
            txtUsuário.Clear();
            cbxSetor.SelectedIndex = -1;
            txtNome.Enabled = true;
            txtNome.Focus();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fIndex OForm = new fIndex();
            OForm.Show();
            this.Visible = false;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRoot OForm = new fRoot();
            OForm.Show();
            this.Visible = false;
        }

        private void txtUsuário_TextChanged(object sender, EventArgs e)
        {
            txtUsuário.Text = Regex.Replace(txtUsuário.Text, "[^0-9]", "");
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            txtSenha.Text = Regex.Replace(txtSenha.Text, "[^0-9]", "");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
           
            fRoot OForm = new fRoot();
            OForm.Show();
            this.Visible = false;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            fIndex OForm = new fIndex();
            OForm.Show();
            this.Visible = false;
        }
    }
}
