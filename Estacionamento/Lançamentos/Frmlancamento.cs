using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    public partial class Frmlancamento : Form
    {
        public Frmlancamento()
        {
            InitializeComponent();
        }
        string data;

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }
        //chama o form lançamento(instancia)
        private void btnlancar_Click(object sender, EventArgs e)
        {
            
            Lancanocaixa();
            try
            {
                //campos obrigatorios
                if (txtvalor.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo nome");
                    txtvalor.Focus();
                    return;

                }
                if (txtdescricao.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo nome");
                    txtdescricao.Focus();
                    return;

                }

              
            }
            catch (Exception)
            {
                throw;
            }
        }
       
       
        private void Lancanocaixa()
        {
            try
            {

                data = DateTime.Now.ToShortDateString();
                Conexao.fechaConexao();

                string sql = "INSERT INTO caixa(" +
                                    "data_lancamento," +
                                    "descricao," +
                                    "valor," +
                                    "tipo " +
                                    " )" +
                                    " VALUES" +
                                    " (" +
                                    "@data_lancamento," +
                                    "@descricao," +
                                    "@valor," +
                                    "@tipo" +
                                    ")";


                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);



                // PARAMETROS//armazenando dados


                Conexao.comando.Parameters.AddWithValue("@data_lancamento", Convert.ToDateTime(data));
                Conexao.comando.Parameters.AddWithValue("@descricao", "VENDA");
                Conexao.comando.Parameters.AddWithValue("@valor", Convert.ToDouble(txtvalor.Text));
                Conexao.comando.Parameters.AddWithValue("@tipo", "E");


                Conexao.comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frmlancamento_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void gbdados_Enter(object sender, EventArgs e)
        {

        }

        private void gbbotoes_Enter(object sender, EventArgs e)
        {

        }
    }
    
    }
   
       
