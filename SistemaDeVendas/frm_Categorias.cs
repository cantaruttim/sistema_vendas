using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaDeVendas
{
    public partial class frm_Categorias : Form
    {
        MySqlConnection conn;
        public string data_source = "datasource=localhost;" +
                                     "username=root;" +
                                     "password=12102021;" +
                                     "database=sistema_vendas";

        public frm_Categorias()
        {
            InitializeComponent();
            carregar_categorias();
        }

        #region Conexão
        //public void carregar_conn(string data_source)
        //{

        //}
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                cmd.CommandText =
                        "INSERT INTO tb_categorias" +
                        "(descricao_categoria)" +
                        "VALUES (@categoria)";

                cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Categoria inserida com Sucesso", 
                         "Sucesso",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information);

            } catch (MySqlException ex)
            {
                MessageBox.Show("Error " + "has occured: " + ex.Message,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (Exception ex)
            {
                MessageBox.Show("Has occured: " + ex.Message,
                   "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally
            {
                conn.Close();
            }

            carregar_categorias();

        }

        #region Carrega os dados - SELECT
        public void carregar_categorias()
        {

            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();

                string sql = "SELECT id_categoria AS 'Id', descricao_categoria AS 'Categoria' FROM tb_categorias";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dtGridCat.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            } finally
            {
                conn.Close();
            }
        }
        #endregion

        private void frm_Categorias_Load(object sender, EventArgs e)
        {
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
