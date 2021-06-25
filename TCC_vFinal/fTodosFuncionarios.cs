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
    public partial class fTodosFuncionarios : Form
    {
        public fTodosFuncionarios()
        {
            InitializeComponent();
        }






        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string config = "server=localhost;user=root;database=tcc;port=3306;password='';";

            try
            {
                string query = String.Format("SELECT nome,setor,usuario, senha FROM funcionarios");

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
    }
}
    

