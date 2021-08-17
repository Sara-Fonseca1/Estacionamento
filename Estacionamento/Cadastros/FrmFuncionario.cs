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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
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

        private void FrmFuncionario_Load(object sender, EventArgs e)
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
        //campos obrigatorio
        private void btnSalva_Click(object sender, EventArgs e)
        {

            try
            {
                if (acao == 1)
                {
                    novofuncionario();
                }

                if (acao == 2)
                {
                    atualizafuncionario();
                }


                //campos obrigatorios
                if (txtNome.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo Nome");
                    txtNome.Focus();
                    return;

                }
                if (txtTelefone.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo Telefone");
                    txtTelefone.Focus();
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
            string sql = "SELECT * FROM Funcionario ORDER BY id_funcionario";

            Conexao.abreConexao();
            Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

            Conexao.leitor = Conexao.comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Funcao", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));
            dt.Columns.Add("Rua", typeof(string));
            dt.Columns.Add("Numero", typeof(string));
            dt.Columns.Add("Bairro", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            dt.Columns.Add("Cep", typeof(string));
            dt.Columns.Add("Uf", typeof(string));



            while (Conexao.leitor.Read())
            {
                DataRow dr = dt.NewRow();

                dr["Codigo"] = Conexao.leitor["id_funcionario"].ToString();
                dr["Nome"] = Conexao.leitor["nome"].ToString();
                dr["Funcao"] = Conexao.leitor["Funcao"].ToString();
                dr["Telefone"] = Conexao.leitor["Telefone"].ToString();
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
        private void novofuncionario()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "INSERT INTO  funcionario(" +
                                    " Nome," +
                                    " Funcao," +
                                    " Telefone," +
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
                                    " @Funcao," +
                                    " @Telefone," +
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
                Conexao.comando.Parameters.AddWithValue("@id",txtcodigo.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@nome", txtNome.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@Funcao", cmbfuncao.Text);
                Conexao.comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
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

        //update
        private void atualizafuncionario()
        {
            if (MessageBox.Show("Deseja realmente alterar?", "Mensagem do sistema",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                try
                {
                    if (id <= 0)
                    {
                        MessageBox.Show("Funcionario nao  encontrado");
                        return;
                    }

                    


                    Conexao.fechaConexao();
                    string sql = "UPDATE funcionario SET " + "nome = @nome," + 
                                                           "funcao=@funcao," +
                                                            "telefone= @telefone," +
                                                            "rua=@rua," +
                                                            "Numero=@numero," +
                                                            "Bairro=@bairro," +
                                                            "Cidade=@cidade," +
                                                            "Cep=@Cep," +
                                                            "Uf=@Uf" +
                                                            " WHERE id_funcionario = @id ";
                        

                    Conexao.abreConexao();
                    Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                    Conexao.comando.Parameters.AddWithValue("@id", id);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@nome", txtNome.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@Funcao", cmbfuncao.Text);
                    Conexao.comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    Conexao.comando.Parameters.AddWithValue("@Rua", txtRua.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@Numero", txtnumero.Text);
                    Conexao.comando.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                    Conexao.comando.Parameters.AddWithValue("@Cidade", txtCidade.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@Cep", txtcep.Text);
                    Conexao.comando.Parameters.AddWithValue("@Uf", cmbUf.Text);



                    Conexao.comando.ExecuteNonQuery();
                    MessageBox.Show("funcionario alterado com sucesso");


                  
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
         
        
        
        // DOIS CLIQUES
        private void grdConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pega tudo da tabela e joga para meu grid,e converte pois aqui muda

            // captura o id do funcionario
            id = Convert.ToInt32( grdConsulta.CurrentRow.Cells[0].Value.ToString());

            txtcodigo.Text = grdConsulta.CurrentRow.Cells[0].Value.ToString();//passa para o campo
            txtNome.Text = grdConsulta.CurrentRow.Cells[1].Value.ToString();
            cmbfuncao.Text = grdConsulta.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = grdConsulta.CurrentRow.Cells[3].Value.ToString();
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
            //atualizafuncionario();

            rbAtivo.Checked = true;
            rbInativo.Checked = false;
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {

            try
            {
                Conexao.fechaConexao();
                string sql = "DELETE FROM funcionario WHERE id_funcionario = @id";
                Conexao.abreConexao();

                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                // PARAMETROS
                Conexao.comando.Parameters.AddWithValue("@id", Convert.ToInt32(txtcodigo.Text));

                Conexao.comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluido.");
                carregaGrid();

                 txtNome.Text = "";
                 cmbfuncao.Text = "";
                 txtTelefone.Text = "";
                 txtRua.Text = "";
                 txtnumero.Text = "";
                 txtBairro.Text = "";
                 txtCidade.Text = "";
                 txtcep.Text = "";
                 cmbUf.Text = "";


                txtNome.Focus();
                limpaCampos();
                statusInicio();//volta ao inicio
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao exlcuir registro.");
            }

        }

       private void btnconsulta_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.fechaConexao();
                string sql = "SELECT * FROM Funcionario WHERE  0=0 AND nome =@nome OR telefone = @telefone";//ISOLAR O WHERE

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.comando.Parameters.AddWithValue("@nome", txtConsulta.Text.Trim());//parametro
                Conexao.comando.Parameters.AddWithValue("@telefone", txtConsulta.Text.Trim());//parametro

                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                //cabeçalho de minha tabela
                dt.Columns.Add("Cod", typeof(string));
                dt.Columns.Add("Nome", typeof(string));
                dt.Columns.Add("Funcao", typeof(string));
                dt.Columns.Add("Telefone", typeof(string));
                dt.Columns.Add("Rua", typeof(string));
                dt.Columns.Add("Numero", typeof(string));
                dt.Columns.Add("Bairro", typeof(string));
                dt.Columns.Add("Cidade", typeof(string));
                dt.Columns.Add("Cep", typeof(string));
                dt.Columns.Add("UF", typeof(string));

                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();

                    //cabeçalho de minha tabela
                    dr["Cod"] = Conexao.leitor["id_funcionario"].ToString();
                    dr["Nome"] = Conexao.leitor["nome"].ToString();
                    dr["Funcao"] = Conexao.leitor["funcao"].ToString();
                    dr["Telefone"] = Conexao.leitor["telefone"].ToString();
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

        private void limpaCampos()
        {
           
            txtNome.Text = string.Empty;
            cmbfuncao.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtRua.Text = string.Empty;
            txtnumero.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtCidade.Text = string.Empty;
            txtcep.Text = string.Empty;
            cmbUf.Text = string.Empty;


        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
       


    




