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
    public partial class frmCliente : Form
    {
        public frmCliente()
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

            txtNome.Focus();


        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            statusInicio();
            carregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            acao = 1;

            statusAlterando();
            txtNome.Focus();

            rbAtivo.Checked = true;
            rbInativo.Checked = false;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                if (acao == 1)

                {
                    novocliente();
                }

                if (acao == 2)

                {
                    atualizacliente();
                }

                //campos obrigatorios
                if (txtNome.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo nome");
                    txtNome.Focus();
                    return;

                }

                if (txtCelular.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo Telefone");
                    txtCelular.Focus();
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



        //metodo para carregar o grid
        private void carregaGrid()//meu metodo
        {
            Conexao.fechaConexao();
            string sql = "SELECT * FROM Cliente ORDER BY id_cliente";

            Conexao.abreConexao();
            Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

            Conexao.leitor = Conexao.comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Celular", typeof(string));
            dt.Columns.Add("Telefoneresidencial", typeof(string));
            dt.Columns.Add("Rua", typeof(string));
            dt.Columns.Add("Numero", typeof(string));
            dt.Columns.Add("Bairro", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            dt.Columns.Add("Cep", typeof(string));
            dt.Columns.Add("Uf", typeof(string));



            while (Conexao.leitor.Read())
            {
                DataRow dr = dt.NewRow();

                dr["Codigo"] = Conexao.leitor["id_cliente"].ToString();
                dr["Nome"] = Conexao.leitor["nome"].ToString();
                dr["Celular"] = Conexao.leitor["Celular"].ToString();
                dr["Telefoneresidencial"] = Conexao.leitor["Telefoneresidencial"].ToString();
                dr["Rua"] = Conexao.leitor["Rua"].ToString();
                dr["Numero"] = Conexao.leitor["Numero"].ToString();
                dr["Bairro"] = Conexao.leitor["Bairro"].ToString();
                dr["Cidade"] = Conexao.leitor["Cidade"].ToString();
                dr["Cep"] = Conexao.leitor["Cep"].ToString();
                dr["Uf"] = Conexao.leitor["Uf"].ToString();


                dt.Rows.Add(dr);

            }

            grdConsulta.DataSource = dt;
            grdConsulta.Update();

        }
        // INSERT
        private void novocliente()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "INSERT INTO  Cliente(" +
                                    " Nome," +
                                    " Celular,"+
                                    " Telefoneresidencial,"+
                                    " Rua," +
                                    " Numero," +
                                    " Bairro," +
                                    " Cidade," +
                                    " Cep," +
                                    " Uf" +
                                    " )" +
                                    " VALUES" +
                                    " (" +
                                    " @nome," +
                                    " @Celular,"+
                                    " @Telefoneresidencial,"+
                                    " @Rua," +
                                    " @Numero," +
                                    " @Bairro," +
                                    " @Cidade," +
                                    " @Cep," +
                                    " @Uf" +
                                    " )";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                // PARAMETROS
              
                Conexao.comando.Parameters.AddWithValue("@nome", txtNome.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@Celular", txtCelular.Text);
                Conexao.comando.Parameters.AddWithValue("@Telefoneresidencial",txttelresidencial.Text);
                Conexao.comando.Parameters.AddWithValue("@Rua", txtRua.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@Numero", txtnumero.Text);
                Conexao.comando.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                Conexao.comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@Cep", txtcep.Text);
                Conexao.comando.Parameters.AddWithValue("@Uf", cmbUf.Text);

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
        private void atualizacliente()
        {
            if (MessageBox.Show("Deseja realmente alterar?", "Mensagem do sistema",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                try
                {
                    if (id <= 0)
                    {
                        MessageBox.Show("Cliente nao  encontrado");
                        return;
                    }




                    Conexao.fechaConexao();
                    string sql = "UPDATE Cliente SET " + "nome = @nome," +
                                                            "Celular=@Celular," +
                                                            "Telefoneresidencial=@Telefoneresidencial," +
                                                            "rua=@rua," +
                                                            "Numero=@numero," +
                                                            "Bairro=@bairro," +
                                                            "Cidade=@cidade," +
                                                            "Cep=@Cep," +
                                                            "Uf=@Uf" +
                                                           " WHERE id_cliente = @id ";


                    Conexao.abreConexao();
                    Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                    Conexao.comando.Parameters.AddWithValue("@id", id);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@nome", txtNome.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@Celular", txtCelular.Text);
                    Conexao.comando.Parameters.AddWithValue("@Telefoneresidencial", txttelresidencial.Text);
                    Conexao.comando.Parameters.AddWithValue("@Rua", txtRua.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@Numero", txtnumero.Text);
                    Conexao.comando.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                    Conexao.comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@Cep", txtcep.Text);
                    Conexao.comando.Parameters.AddWithValue("@Uf", cmbUf.Text);

                    Conexao.comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente  alterado ");



                    txtNome.Focus();


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
                string sql = "DELETE FROM Cliente WHERE id_cliente = @id";
                Conexao.abreConexao();

                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                // PARAMETROS
                Conexao.comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtcodigo.Text));

                Conexao.comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluido.");
                carregaGrid();

                txtNome.Text = "";
                txtCelular.Text = "";
                txttelresidencial.Text = "";
                txtRua.Text = "";
                txtnumero.Text = "";
                txtBairro.Text = "";
                txtCidade.Text = "";
                txtcep.Text = "";
                cmbUf.Text = "";


                limpaCampos();
                txtNome.Focus();

                statusInicio();//volta ao inicio
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao exlcuir este registro.");
            }

           

        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.fechaConexao();
                string sql = "SELECT * FROM Cliente WHERE  0=0 AND nome =@nome OR telefone = @telefone";//ISOLAR O WHERE

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.comando.Parameters.AddWithValue("@nome", txtConsulta.Text.Trim());//parametro
                Conexao.comando.Parameters.AddWithValue("@telefone", txtConsulta.Text.Trim());//parametro

                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                //cabeçalho de minha tabela
                dt.Columns.Add("Cod", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Celular", typeof(string));
                dt.Columns.Add("Telefoneresidencial", typeof(string));
                dt.Columns.Add("Rua", typeof(string));
                dt.Columns.Add("Numero", typeof(string));
                dt.Columns.Add("Cidade", typeof(string));
                dt.Columns.Add("Cep", typeof(string));
                dt.Columns.Add("UF", typeof(string));

                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();

                    //cabeçalho de minha tabela
                    dr["Cod"] = Conexao.leitor["id_cliente"].ToString();
                    dr["Nome"] = Conexao.leitor["nome"].ToString();
                    dr["Celular"] = Conexao.leitor["Celular"].ToString();
                    dr["TelefoneResidencial"] = Conexao.leitor["Telefoneresidencial"].ToString();
                    dr["Rua"] = Conexao.leitor["rua"].ToString();
                    dr["Numero"] = Conexao.leitor["numero"].ToString();
                    dr["Bairro"] = Conexao.leitor["bairro"].ToString();
                    dr["Cidade"] = Conexao.leitor["cidade"].ToString();
                    dr["Cep"] = Conexao.leitor["cep"].ToString();
                    dr["Uf"] = Conexao.leitor["uf"].ToString();
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

        private void grdConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pega tudo da tabela e joga para meu grid,e converte pois aqui muda

            // captura o id do Cliente
            id = Convert.ToInt32(grdConsulta.CurrentRow.Cells[0].Value.ToString());
           // txtcodigo.Text = grdConsulta.CurrentRow.Cells[0].Value.ToString();//passa para o campo
            txtNome.Text = grdConsulta.CurrentRow.Cells[1].Value.ToString(); 
            txtCelular.Text = grdConsulta.CurrentRow.Cells[2].Value.ToString();
            txttelresidencial.Text = grdConsulta.CurrentRow.Cells[3].Value.ToString();
            txtRua.Text = grdConsulta.CurrentRow.Cells[4].Value.ToString();
            txtnumero.Text = grdConsulta.CurrentRow.Cells[5].Value.ToString();
            txtBairro.Text = grdConsulta.CurrentRow.Cells[6].Value.ToString();
            txtCidade.Text = grdConsulta.CurrentRow.Cells[7].Value.ToString();
            txtcep.Text = grdConsulta.CurrentRow.Cells[8].Value.ToString();
            cmbUf.Text = grdConsulta.CurrentRow.Cells[9].Value.ToString();


            btnAltera.Enabled = true;
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            acao = 2;
            statusAlterando();
            txtNome.Focus();
            //atualiza cliente();

            rbAtivo.Checked = true;
            rbInativo.Checked = false;
        }

        private void limpaCampos()
        {
            txtcodigo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txttelresidencial.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtnumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtcep.Text = string.Empty;
            cmbUf.Text = string.Empty;

        }

        
    }
    }

