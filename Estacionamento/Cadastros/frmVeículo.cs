using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Estacionamento
{
    public partial class frmVeículo : Form
    {
        public frmVeículo()
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

            txtDescricao.Focus();


        }

        private void frmVeículo_Load(object sender, EventArgs e)
        {
            statusInicio();
            carregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
           carregatodosClientes();
            acao = 1;

            statusAlterando();


        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            try
            {

                if (acao == 1)

                {
                    novoveiculo();
                }

                if (acao == 2)

                {
                    atualizaveiculo();
                }

                //campos obrigatorios
                if (txtDescricao.Text.Trim() == "")
                {
                    MessageBox.Show("Preencha o campo nome");
                    txtDescricao.Focus();
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
        private void novoveiculo()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "INSERT INTO  Veiculo(" +
                                    " Descricao," +                                   
                                    " Placa," +
                                    " id_cliente" +
                                    " )" +
                                    " VALUES" +
                                    " (" +
                                    " @descricao," +                                   
                                    " @placa," +
                                    " @id_cliente" +
                                    " )";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                // PARAMETROS

                Conexao.comando.Parameters.AddWithValue("@descricao", txtDescricao.Text);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@id_cliente", cmbProprietario_cliente.SelectedValue);//PASSANDO MEUS DADOS
                Conexao.comando.Parameters.AddWithValue("@placa", txtPlaca.Text);
                
                Conexao.comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso.");

                //carregaGrid();
                statusInicio();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //update
        private void atualizaveiculo()
        {
            if (MessageBox.Show("Deseja realmente alterar?", "Mensagem do sistema",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {



                try
                {
                    if (id <= 0)
                    {
                        MessageBox.Show("Veiculo nao  encontrado");
                        return;
                    }




                    Conexao.fechaConexao();
                    string sql = "UPDATE Veiculo SET " + "Descricao = @descricao," +
                                                            "id_cliente=@id_cliente," +
                                                            "Placa=@placa" +
                                                            " WHERE id_veiculo = @id ";


                    Conexao.abreConexao();
                    Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                    Conexao.comando.Parameters.AddWithValue("@id", id);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@descricao",txtDescricao.Text);//armazenando dados
                    Conexao.comando.Parameters.AddWithValue("@id_cliente",cmbProprietario_cliente.ValueMember);//PASSANDO MEUS DADOS
                    Conexao.comando.Parameters.AddWithValue("@placa",txtPlaca.Text);
                    

                    Conexao.comando.ExecuteNonQuery();
                    MessageBox.Show("Veiculo  alterado ");



                    txtDescricao.Focus();


                    //carregaGrid();
                    statusInicio();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //trow(Informe a exceçao)
                }


            }
        }

        private void btnconsulta_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                Conexao.fechaConexao();
                string sql = "SELECT * FROM Veiculo WHERE  0=0 AND placa=@placa ";//ISOLAR O WHERE

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.comando.Parameters.AddWithValue("@placa",txtConsulta.Text.Trim());//parametro
           

                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                //cabeçalho de minha tabela
                dt.Columns.Add("Cod", typeof(string));
                dt.Columns.Add("descricao", typeof(string));
                dt.Columns.Add("id_cliente", typeof(string));
                dt.Columns.Add("placa", typeof(string));
           

                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();

                    //cabeçalho de minha tabela
                    dr["Cod"] = Conexao.leitor["id_veiculo"].ToString();
                    dr["Descricao"] = Conexao.leitor["Descricao"].ToString();
                    dr["id_cliente"] = Conexao.leitor["id_cliente"].ToString();
                    dr["Placa"] = Conexao.leitor["placa"].ToString();
                    
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
        { //pega tudo da tabela e joga para meu grid,e converte pois aqui muda

            // captura o id do veiculo
            //id = Convert.ToInt32(grdConsulta.CurrentRow.Cells[0].Value.ToString());
            txtcodigo.Text = grdConsulta.CurrentRow.Cells[0].Value.ToString();//passa para o campo
            txtDescricao.Text = grdConsulta.CurrentRow.Cells[1].Value.ToString();
            cmbProprietario_cliente.Text = grdConsulta.CurrentRow.Cells[2].Value.ToString();
            txtPlaca.Text = grdConsulta.CurrentRow.Cells[3].Value.ToString();
          

            btnAltera.Enabled = true;
        }

        //metodo para carregar o grid
        private void carregaGrid()//meu metodo
        {
            Conexao.fechaConexao();
            string sql = "SELECT * FROM veiculo ORDER BY id_veiculo";

            Conexao.abreConexao();
            Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

            Conexao.leitor = Conexao.comando.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("id_cliente", typeof(string));
            dt.Columns.Add("placa", typeof(string));




            while (Conexao.leitor.Read())
            {
                DataRow dr = dt.NewRow();

                dr["Codigo"] = Conexao.leitor["id_veiculo"].ToString();
                dr["Descricao"] = Conexao.leitor["Descricao"].ToString();
                dr["id_cliente"] = Conexao.leitor["id_cliente"].ToString();
                dr["Placa"] = Conexao.leitor["placa"].ToString();




                dt.Rows.Add(dr);

            }

            grdConsulta.DataSource = dt;
            grdConsulta.Update();

        }
         
        
        private void carregatodosClientes()
        { 
            
            try
            {
                Conexao.fechaConexao();
                //Sql que ser executado
                string sql = "SELECT * FROM Cliente ORDER BY nome";

                Conexao.abreConexao();
                
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                SqlDataReader leitor = Conexao.comando.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(leitor);

                DataRow Linha = tabela.NewRow();

                Linha["nome"] = "";
                tabela.Rows.InsertAt(Linha,0);

                cmbProprietario_cliente.DataSource = tabela;
                cmbProprietario_cliente.ValueMember ="id_cliente";
                cmbProprietario_cliente.DisplayMember ="nome";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
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
                Conexao.comando.Parameters.AddWithValue("@id",Convert.ToInt32(txtcodigo.Text));

                Conexao.comando.ExecuteNonQuery();

                MessageBox.Show("Registro excluido.");
                carregaGrid();


                txtDescricao.Text = "";
                txtPlaca.Text = "";
                cmbProprietario_cliente.Text = "";


                limpaCampos();
                txtDescricao.Focus();

                statusInicio();//volta ao inicio
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao exlcuir este registro.");
            }


        }
        private void limpaCampos()
        {
            txtcodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            cmbProprietario_cliente.Text = string.Empty;


        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {

        }

        private void cmbProprietario_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
   
  
  
