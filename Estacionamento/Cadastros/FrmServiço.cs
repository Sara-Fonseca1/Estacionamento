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
    public partial class FrmServiço : Form
    {
        public FrmServiço()
        {
            InitializeComponent();
        }
        int acao = 0;
        //acao=1 insert
        // acao =2   Update
        int id;

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Inicio
        private void statusInicio()
        {
            gbdados.Enabled = false;
            gbconsulta.Enabled = true;
            btnAltera.Enabled = false;
            btnSalva.Enabled = false;

            btnNovo.Enabled = true;
            btnSair.Enabled = true;
        }
        //alterando
        private void statusAlterando()
        {


            gbdados.Enabled = true;
            gbconsulta.Enabled = true;
            btnAltera.Enabled = true;
            btnSalva.Enabled = true;

            btnNovo.Enabled = false;
            btnSair.Enabled = true;

            txtdescricao.Focus();


        }

        private void FrmServiço_Load(object sender, EventArgs e)
        {
            statusInicio();
            carregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            acao = 1;

            statusAlterando();
            txtdescricao.Focus();

        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                if (acao == 1)

                {
                    novoservico();
                }

                if (acao == 2)

                {
                    atualizaservico();
                }

                //campos obrigatorios
                if (txtdescricao.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo Descriçao");
                    txtdescricao.Focus();
                    return;

                }

                if (txtvalor.Text.Trim() == "")
                {

                    MessageBox.Show("Preencha o campo com  valor");
                    txtdescricao.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            limpaCampos();
            statusInicio();
        }


        // INSERT
        private void novoservico()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "INSERT INTO  Servico(" +
                                    " Descricao," +
                                    " valor" +
                                    " )" +
                                    " VALUES" +
                                    " (" +
                                    " @descricao," +
                                    " @valor" +
                                    " )";
                
                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                // PARAMETROS

                Conexao.comando.Parameters.AddWithValue("@descricao", txtdescricao.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@valor", Convert.ToDouble (txtvalor.Text));


                Conexao.comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso.");

                carregaGrid();
                statusInicio();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //update
        private void atualizaservico()
        {
            if (MessageBox.Show("Deseja realmente alterar?", "Mensagem do sistema",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                try
                {
                    if (id <= 0)
                    {
                        MessageBox.Show("Servico nao  encontrado");
                        return;
                    }




                    Conexao.fechaConexao();
                    string sql = "UPDATE Servico SET " + "Descricao = @descricao," +
                                                            "Valor=@valor" +
                                                         " WHERE id_servico = @id ";


                    Conexao.abreConexao();
                    Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                    Conexao.comando.Parameters.AddWithValue("@id", id);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@descricao", txtdescricao.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@valor", Convert.ToDouble(txtvalor.Text));


                    Conexao.comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente  alterado ");



                    txtdescricao.Focus();


                    carregaGrid();
                    statusInicio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //trow(Informe a exceçao)
                }


            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.fechaConexao();
                string sql = "DELETE FROM Servico WHERE id_servico = @id";
                Conexao.abreConexao();

                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                // PARAMETROS
                Conexao.comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtcodigo.Text));

                Conexao.comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluido.");
                carregaGrid();

                txtdescricao.Text = "";
                txtvalor.Text = "";

                txtdescricao.Focus();
                limpaCampos();
                statusInicio();//volta ao inicio
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao exlcuir este registro.");
            }

        }

        private void grdConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pega tudo da tabela e joga para meu grid,e converte pois aqui muda

            // captura o id do Servico
            id = Convert.ToInt32(grdConsulta.CurrentRow.Cells[0].Value.ToString());
            txtcodigo.Text = grdConsulta.CurrentRow.Cells[0].Value.ToString();//passa para o campo
            txtdescricao.Text = grdConsulta.CurrentRow.Cells[1].Value.ToString();
            txtvalor.Text = grdConsulta.CurrentRow.Cells[2].Value.ToString();
            

            btnAltera.Enabled = true;
        }
        //metodo para carregar o grid
        private void carregaGrid()//meu metodo
        {
            Conexao.fechaConexao();
            string sql = "SELECT * FROM Servico ORDER BY id_servico";

            Conexao.abreConexao();
            Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

            Conexao.leitor = Conexao.comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("valor", typeof(string));



            while (Conexao.leitor.Read())
            {
                DataRow dr = dt.NewRow();

                dr["Codigo"] = Conexao.leitor["id_servico"].ToString();
                dr["Descricao"] = Conexao.leitor["descricao"].ToString();
                dr["Valor"] = Conexao.leitor["valor"].ToString();


                dt.Rows.Add(dr);

            }

            grdConsulta.DataSource = dt;
            grdConsulta.Update();

        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            acao = 2;
            statusAlterando();
            txtdescricao.Focus();
            //atualiza cliente();

        }

       

        private void btnconsulta_Click(object sender, EventArgs e)
        {

            try
            {
                Conexao.fechaConexao();
                string sql = "SELECT * FROM Servico WHERE  0=0 AND descricao=@descricao ";//ISOLAR O WHERE

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.comando.Parameters.AddWithValue("@descricao", txtConsulta.Text.Trim());//parametro
                

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
                grdConsulta.DataSource = dt;
                grdConsulta.Update();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //trow(Informe a exceçao)
            }
        }

        private void limpaCampos()
        {

            txtdescricao.Text = string.Empty;
            txtvalor.Text = string.Empty;
          
        }

        private void grdConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbdados_Enter(object sender, EventArgs e)
        {

        }

        private void gbconsulta_Enter(object sender, EventArgs e)
        {

        }

        private void gbbotoes_Enter(object sender, EventArgs e)
        {

        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }




