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
    public partial class fVisuChamados : Form
    {
        public fVisuChamados()
        {
            InitializeComponent();
        }
        public void gridView()
        {
            //// GRID VIEW DE BUSCAR PROTOCOLO
            ///

            string config = "server=localhost;user=root;database=tcc;port=3306;password='';";

            try
            {

                if (txtCpf.Text.Length < 11)
                {
                    MessageBox.Show("Seu login deve conter os 11 caracteres!");

                }
                else
                {
                    string query = String.Format("SELECT codigo, nome,situacao FROM chamado WHERE upper(usuario) like '%" + txtCpf.Text.ToUpper() + "%' ;");// erro a partir do WHERE


                    MySqlConnection conexao = new MySqlConnection(config);
                    conexao.Open();
                    MySqlCommand command = new MySqlCommand(query, conexao);


                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    conexao.Close();
                    adapter.Dispose();

                    dtgvBuscaChamado.DataSource = dt;
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Erro");
            }

        }
       

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {
            txtCpf.Text = Regex.Replace(txtCpf.Text, "[^0-9]", "");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ////// CHAMA GRIDVIEW DE BUSCAR PROTOCOLO

            gridView();
        }
    }
}
