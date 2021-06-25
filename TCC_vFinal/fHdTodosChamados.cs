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
    public partial class fHdTodosChamados : Form
    {
        public fHdTodosChamados()
        {
            InitializeComponent();
        }
        public void gridView()
        {

            string config = "server=localhost;user=root;database=tcc;port=3306;password='';";

            try
            {
                string query = String.Format("SELECT codigo, nome,categoria,urgencia,telefone,setor,titulo,descricao,email," +
                                "situacao,datahora, observacoes FROM chamado WHERE situacao = ' Aberto'");

                MySqlConnection conexao = new MySqlConnection(config);
                conexao.Open();

                MySqlCommand command = new MySqlCommand(query, conexao);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);

                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView1.DataSource = data;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gridView();
        }
    }
}
