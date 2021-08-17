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
    public partial class frmClienteveiculo : Form
    {
        public frmClienteveiculo()
        {
            InitializeComponent();
            Classegeral g = new Classegeral();
        }
       


        //variavel que armazena o idcliente
        int ultimoIDcliente = 0;

        private void frmClienteveiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        // INSERT
        private void gravarcliente()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "INSERT INTO  Cliente(" +
                                   
                                    "nome," +
                                    "telefoneresidencial," +
                                    "celular" +
                                    ")" +
                                    "VALUES" +
                                    "(" +
                                    "@nome," +
                                    "@telefoneresidencial," +
                                    "@celular" +
                                    ")";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                // PARAMETROS

                Conexao.comando.Parameters.AddWithValue("@nome", txtNome.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@telefoneresidencial", txttelresidencial.Text);
                Conexao.comando.Parameters.AddWithValue("@celular", txtCelular.Text);



                Conexao.comando.ExecuteNonQuery();
                MessageBox.Show("cliente gravado com sucesso.");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void retornaIdCliente()
        {
            try
            {               

                    Conexao.fechaConexao();
                    //sql que sera executado
                    string sql = "SELECT max(id_cliente) As Cliente FROM  Cliente";
                    //chama o metodo abre conexao
                    Conexao.abreConexao();

                    Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);
                    Conexao.leitor = Conexao.comando.ExecuteReader();

                if (Conexao.leitor.Read())
                {
                    ultimoIDcliente = Convert.ToInt32(Conexao.leitor["Cliente"].ToString());
                }
                    

           

                }
                catch (Exception ex)
                {
                MessageBox.Show(ex.Message);

            }

            }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            gravarcliente();
            retornaIdCliente();
            gravarVeiculo();
        }

        private void gravarVeiculo()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "INSERT INTO  Veiculo(" +
                                    "descricao," +
                                    "placa," +
                                    "id_cliente" +
                                    " )" +
                                    "VALUES" +
                                    " (" +
                                    "@descricao," +
                                    "@placa," +
                                    "@id_cliente" +
                                    " )";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                // PARAMETROS
                Conexao.comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@placa", txtPlaca.Text);
                Conexao.comando.Parameters.AddWithValue("@id_cliente", ultimoIDcliente);

                Conexao.comando.ExecuteNonQuery();

                MessageBox.Show("veiculo gravado com sucesso.");

               
            }
            catch (Exception ex)
            {

          
                MessageBox.Show(ex.Message);
                //trow(Informe a exceçao)
          
           }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             //FrmDiaria diaria = new FrmDiaria();
            //diaria.ShowDialog();
        }
        public void recebeplaca(string placa)
        {
            txtPlaca.Text = placa;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            txtNome.Text = Classegeral.removerAcentos(txtNome.Text);
        }

        private void gbdados_Enter(object sender, EventArgs e)
        {

        }
    }


 }
    

