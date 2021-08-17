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
    public partial class FrmCaixa : Form
    {
        public FrmCaixa()
        {
            InitializeComponent();
        }
        public double Entrada;
        public double Saida;
        public double Saldo;

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlancar_Click(object sender, EventArgs e)
        {
            Frmlancamento lancamento = new Frmlancamento();
            lancamento.ShowDialog();
            carregaGrid();
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            carregaGrid();
        }

       
              //carregaGrid
        private void carregaGrid()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "SELECT * FROM caixa";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("Descrição", typeof(string));
                dt.Columns.Add("Valor", typeof(string));
                dt.Columns.Add("Tipo", typeof(string));

                Saida = 0;
                Entrada = 0;

                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Codigo"] = Conexao.leitor["id_caixa"].ToString();
                    dr["Descrição"] = Conexao.leitor["descricao"].ToString();
                    dr["Valor"] = Conexao.leitor["valor"].ToString();
                    dr["Tipo"] = Conexao.leitor["tipo"].ToString();

                    //soma entrada
                    if ((Conexao.leitor["tipo"].ToString() == "E"))
                    {
                        Entrada = Entrada + double.Parse(Conexao.leitor["valor"].ToString());
                    }

                    //soma das Saidas
                    if ((Conexao.leitor["tipo"].ToString() == "S"))
                    {
                        Saida = Saida + double.Parse(Conexao.leitor["valor"].ToString());
                    }

                    dt.Rows.Add(dr);
                }


                txtentrada.Text = Convert.ToString(string.Format("R${0:n}", Entrada));
                txtSaida.Text = Convert.ToString(string.Format("R${0:n}", Saida));

                txtSaldo.Text = Convert.ToString(string.Format("R${0:n}", (Entrada - Saida)));

                grddados.DataSource = dt;
                grddados.Columns["Codigo"].Width = 100;
                grddados.Columns["Descrição"].Width = 300;
                grddados.Columns["Valor"].Width = 100;
                grddados.Columns["Tipo"].Width = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {

        }
    }
}

