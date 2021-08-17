using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Estacionamento
{
    public partial class FrmRecebimento : Form
    {
        public FrmRecebimento()
        {
            InitializeComponent();
        }
        //  int id;
        int acao = 0;
        //acao=1 insert
        // acao =2   Update
        public static String forma;
        public static Double valor=0;//valor original
        public int id_servico;
        public static int quantidade;
        public static Double valorTotal=0;
        string data;
        public static double desconto=0;

        //private object lblTotal;

        private void statusInicio()
        {
            gbdados.Enabled = false;
            gbtotal.Enabled = true;
            gbitens.Enabled = true;
            btnreceber.Enabled = false;
            btnlimpar.Enabled = false;

            btndiaria.Enabled = true;
            btnservico.Enabled = true;
            btnsair.Enabled = true;
        }
        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnservico_Click(object sender, EventArgs e)
        {
            FrmConsultaServico Servico = new FrmConsultaServico(this);
            Servico.ShowDialog();

        }
        //quando o form carrega txt total.label vai receber falso e o txt vai recer falso
        private void FrmRecebimento_Load(object sender, EventArgs e)
        {
            txttroco.Enabled = false;
            txttotal.Enabled = false;
            lblservico.Text = "";
            lblvalor.Text = "";

            Meusitens.View = View.Details;
            Meusitens.Columns.Add("Codigo");
            Meusitens.Columns.Add("Descriçao");
            Meusitens.Columns.Add("Valor");
            Meusitens.Columns.Add("Qtde");
            Meusitens.Columns.Add("Sub Total");

           
      

            txtquantidade.Focus();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.fechaConexao();
                string sql = "DELETE FROM Recebimento WHERE id_recebimento = @id";
                Conexao.abreConexao();

                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                // PARAMETROS
                Conexao.comando.Parameters.AddWithValue("@id_sevico", Convert.ToDouble(txtservico.Text));
                Conexao.comando.Parameters.AddWithValue("@quantidade", Convert.ToDouble(txtquantidade.Text));

                Conexao.comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluido.");


                cmbcliente.Text = "";
                txttotal.Text = "";
                txtdesconto.Text = "";
                txttroco.Text = "";
                txtvalorrecebido.Text = "";
                txtservico.Text = "";
                txtquantidade.Text = "";


                limpaCampos();
                txtquantidade.Focus();

                statusInicio();//volta ao inicio
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao exlcuir este registro.");
            }
        }

        private void limpaCampos()
        {


            cmbcliente.Text = "";
            txttotal.Text = "";
            txtdesconto.Text = "";
            txttroco.Text = "";
            txtvalorrecebido.Text = "";
            txtservico.Text = "";
            txtquantidade.Text = "";

            Meusitens.Items.Clear();

            valor = 0;
            valorTotal = 0;



        }

        private void btndiaria_Click(object sender, EventArgs e)
        {
            FrmDiaria diaria = new FrmDiaria();
            diaria.ShowDialog();
        }

        // INSERT
        private void novoservico()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "INSERT INTO  Recebimento(" +
                                    "id_cliente," +
                                    "id_sevico," +
                                    "id_Recebimento," +
                                    "quantidade," +
                                    "total," +
                                    "Desconto," +
                                    "valor_recebido," +
                                    "troco" +
                                    " )" +
                                    " VALUES" +
                                    " (" +
                                    "@id_cliente," +
                                    "@id_sevico," +
                                    "@id_Recebimento," +
                                    "@quantidade," +
                                    "@total," +
                                    "@Desconto," +
                                    "@valor_recebido," +
                                    "@troco" +
                                    " )";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                // PARAMETROS//armazenando dados

                Conexao.comando.Parameters.AddWithValue("@id_cliente", Convert.ToDouble(cmbcliente.Text));
                Conexao.comando.Parameters.AddWithValue("@id_sevico", Convert.ToDouble(txtservico.Text));
                Conexao.comando.Parameters.AddWithValue("@quantidade", Convert.ToDouble(txtquantidade.Text));
                Conexao.comando.Parameters.AddWithValue("@total", Convert.ToDouble(txttotal.Text));
                Conexao.comando.Parameters.AddWithValue("@Desconto", Convert.ToDouble(txtdesconto.Text));
                Conexao.comando.Parameters.AddWithValue("@valor_recebido", Convert.ToDouble(txtvalorrecebido.Text));
                Conexao.comando.Parameters.AddWithValue("@troco", Convert.ToDouble(txttroco.Text));


                Conexao.comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso.");

                txtquantidade.Focus();
                statusInicio();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //fazendo o calculo para gerar o troco
        private void txtvalorrecebido_KeyDown(object sender, KeyEventArgs e)
        {

            double soma = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (txtvalorrecebido.Text != "")
                {
                    
                   soma = Convert.ToDouble(txtvalorrecebido.Text) - Convert.ToDouble(txtvalorliquido.Text);
                   txttroco.Text = Convert.ToString(soma);

                }
               
            }
        }
  

      

        private void btnlimparlista_Click(object sender, EventArgs e)
        {
            Meusitens.Items.Clear();//limpar o texto
        }

        private void txtservico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ConsultaServico(Convert.ToInt32(txtservico.Text));

            }

        }
        public void ConsultaServico(int id)
        {
            int contador = 0;
            try
            {
                Conexao.fechaConexao();
                //sql que sera executado
                string sql = "SELECT * FROM  Servico WHERE id_servico =@id_servico";
                //chama o metodo abre conexao
                Conexao.abreConexao();

                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);
                Conexao.comando.Parameters.AddWithValue("@id_servico", id);
                Conexao.leitor = Conexao.comando.ExecuteReader();

                while (Conexao.leitor.Read())
                {
                 
                   //os campos que quero exibir
                    lblservico.Text = Conexao.leitor["descricao"].ToString();
                    lblvalor.Text = string.Format("{0:N}", Conexao.leitor["valor"].ToString());
                    valor = Convert.ToDouble(lblvalor.Text);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtquantidade_KeyDown(object sender, KeyEventArgs e)
        {
          
           /* if (e.KeyCode == Keys.Enter)
            {
                    somaItem();
                    Addlista();     
          }  */

            if (e.KeyCode == Keys.Enter)
            {
                valor = valor * Convert.ToDouble(txtquantidade.Text);
                ListViewItem item = new ListViewItem(txtservico.Text);//adicionando os itens na lista
                item.SubItems.Add(lblservico.Text);
                item.SubItems.Add(Convert.ToString(lblvalor.Text));
                item.SubItems.Add(txtquantidade.Text);
                item.SubItems.Add(valor.ToString(""));
                Meusitens.Items.Add(item);
                somaItem();



                txtquantidade.Text = "";
                txtservico.Text = "";

                txtservico.Focus();

            }

        }

       
        
        
        //add os dados no listview
      /*  private void Addlista()
        {
            double subtotal = 0;
            subtotal = (valor *quantidade);

            ListViewItem lt = new ListViewItem(txtservico.Text);

            lt.SubItems.Add(txtservico.Text);
            lt.SubItems.Add(txtquantidade.Text);
            lt.SubItems.Add(Convert.ToString(string.Format("{0:n}", subtotal)));
            this.Meusitens.Items.Add(lt);


        }*/

        private void somaItem()
        {
            try
            {
                valorTotal = valorTotal + valor; //* Convert.ToDouble(txtquantidade.Text);
                txttotal.Text = Convert.ToString(string.Format("R${0:n}", valorTotal));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreceber_Click(object sender, EventArgs e)
        {
            {
                

              Lancanocaixa();
            }
        }


        //metodo usado para fazer o lançamento no caixa
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


                Conexao.comando.Parameters.AddWithValue("@data_lancamento",Convert.ToDateTime(data));
                Conexao.comando.Parameters.AddWithValue("@descricao","VENDA");
                Conexao.comando.Parameters.AddWithValue("@valor", Convert.ToDouble(txtvalorliquido.Text));
                Conexao.comando.Parameters.AddWithValue("@tipo","E");


                Conexao.comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso.");

                txtquantidade.Focus();
                statusInicio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void txtdesconto_KeyDown(object sender, KeyEventArgs e)
        {
             double valor_liquido = 0;

            if (e.KeyCode == Keys.Enter)
            {
                if (txtdesconto.Text != "")
                {
                    valor_liquido = valorTotal - Convert.ToDouble(txtdesconto.Text);
                    txtvalorliquido.Text = Convert.ToString(valor_liquido);
                }
            }
        }

        private void gbtotal_Enter(object sender, EventArgs e)
        {

        }
    }
}


