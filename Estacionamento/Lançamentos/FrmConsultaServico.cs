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
    public partial class FrmConsultaServico : Form
    {
        private FrmRecebimento recebimento;

        public FrmConsultaServico(FrmRecebimento recebimento)
        {
            InitializeComponent();
            this.recebimento = recebimento;//instaciando minha classe
        }

        //int id;
       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaServico_Load(object sender, EventArgs e)
        {
           

            carregaGrid();

          
        }
        //carrega Grid

        private void carregaGrid()
        {
            try
            {
                Conexao.fechaConexao();
                string sql = "SELECT * FROM Servico order by id_servico";
           
                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("Descricao", typeof(string));
                dt.Columns.Add("Valor", typeof(string));

                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();
                    dr["Codigo"] = Conexao.leitor["id_servico"].ToString();
                    dr["Descricao"] = Conexao.leitor["Descricao"].ToString();
                    dr["Valor"] = Conexao.leitor["Valor"].ToString();

                    dt.Rows.Add(dr);
                }
                grdservico.DataSource = dt;
                grdservico.Columns["Codigo"].Width = 50;
                grdservico.Columns["Descricao"].Width = 150;
                grdservico.Columns["Valor"].Width = 70;
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
        //dois cliques
        private void grdservico_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            recebimento.ConsultaServico(Convert.ToInt32(grdservico.CurrentRow.Cells[0].Value.ToString()));       
          
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Conexao.fechaConexao();
                string sql = "SELECT * FROM Servico WHERE  0=0 AND descricao=@descricao ";//ISOLAR O WHERE

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.comando.Parameters.AddWithValue("@descricao", txtconsulta.Text.Trim());//parametro


                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                //cabeçalho de minha tabela
                dt.Columns.Add("Cod", typeof(string));
                dt.Columns.Add("Descricao", typeof(string));
                dt.Columns.Add("Valor", typeof(string));


                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();

                    //cabeçalho de minha tabela
                    dr["Cod"] = Conexao.leitor["id_servico"].ToString();
                    dr["Descricao"] = Conexao.leitor["descricao"].ToString();
                    dr["Valor"] = Conexao.leitor["valor"].ToString();

                    dt.Rows.Add(dr);

                }
                grdservico.DataSource = dt;
                grdservico.Update();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //trow(Informe a exceçao)
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





        
    

