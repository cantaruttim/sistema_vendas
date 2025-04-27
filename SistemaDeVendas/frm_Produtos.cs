using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaDeVendas
{
    public partial class frm_Produtos : Form
    {

        MySqlConnection conn;
        public string data_source = "datasource=localhost;" +
                                     "username=root;" +
                                     "password=12102021;" +
                                     "database=sistema_vendas";
        public frm_Produtos()
        {
            InitializeComponent();
            carregar_categorias_em_produtos();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Descrição_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            #region - INSERT Banco
            //try
            //{
            //    carregar_produtos();

            //    conn = new MySqlConnection(data_source);
            //    conn.Open();
            //    MySqlCommand cmd = new MySqlCommand();
            //    cmd.Connection = conn;

            //    cmd.CommandText =
            //            "INSERT INTO tb_produtos" +
            //            "(nome_produto, valor_produto)" +
            //            "VALUES (@produto, @valor)";

            //    cmd.Parameters.AddWithValue("@nome_produto", txtDescricao.Text);
            //    cmd.Parameters.AddWithValue("@valor", txtValor.Text);
            //    cmd.ExecuteNonQuery();

            //    MessageBox.Show("Produto inserido com Sucesso",
            //             "Sucesso",
            //             MessageBoxButtons.OK,
            //             MessageBoxIcon.Information);

            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("Error " + "has occured: " + ex.Message,
            //       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Has occured: " + ex.Message,
            //       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            //finally
            //{
            //    conn.Close();
            //}
            #endregion
        }


        public void carregar_categorias_em_produtos()
        {
            try
            {
                conn = new MySqlConnection(data_source);
                conn.Open();

                string sql = 
                    "SELECT " +
                        "p.nome_produto AS 'Produto', p.valor_produto AS 'Valor', " +
                        "c.id_categoria, c.descricao_categoria AS 'Categoria' " +
                    "FROM tb_categorias c " + 
                    "LEFT JOIN tb_produtos p " +
                        "ON c.id_categoria = p.id_categoria";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridProd.DataSource = dt;
                cbCategoria.DataSource = dt;
                cbCategoria.DisplayMember = "Categoria";
                cbCategoria.ValueMember = "id_categoria";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        #region
        //public void carregar_produtos()
        //{
        //    try
        //    {
        //        conn = new MySqlConnection(data_source);
        //        conn.Open();

        //        string sql = "SELECT p.*, c.descricao_categoria " + 
        //                     "FROM tb_produtos p " + 
        //                        "LEFT JOIN tb_categorias c " + 
        //                            "ON p.id_categoria = c.id_categoria";

        //        MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
        //        DataTable dt = new DataTable();
        //        adapter.Fill(dt);

        //        dataGridProd.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao carregar os produtos: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        #endregion
    }
}
