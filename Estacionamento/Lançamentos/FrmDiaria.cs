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
    public partial class FrmDiaria : Form
    {
        public FrmDiaria()
        {
            InitializeComponent();
        }
         int id_funcionario;
         int id_veiculo;
         string hora_inicio;
         string data;

        //Inicio
        private void statusInicio()
        {
            GBlista.Enabled = true;
        
           
        }
        private void btnentrada_Click(object sender, EventArgs e)
        {
            if (verificaPlaca() == true)
            {

                lancadiaria();
                carregaGrid();

            }
            else
            {

                frmClienteveiculo veiculo = new frmClienteveiculo();
                veiculo.recebeplaca(txtplaca.Text);//crie um metodo para receber este parametro em outra tabela
                veiculo.ShowDialog();
                carregaGrid();
               
            }
        }




        private void lancadiaria()
        {
            try
            {
                data = DateTime.Now.ToShortDateString();
                hora_inicio = DateTime.Now.ToShortTimeString();
                id_funcionario = 1;//por que não tenho login


                Conexao.fechaConexao();

                string sql = "INSERT INTO  diaria(" +
                                    " id_funcionario," +
                                    " id_veiculo," +
                                    " data_entrada," +
                                    " hora_inicio" +
                                    " )" +
                                    " VALUES" +
                                    " (" +
                                    " @id_funcionario," +
                                    " @id_veiculo," +
                                    " @data_entrada," +
                                    " @hora_inicio" +
                                    " )";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);


                // PARAMETROS

                Conexao.comando.Parameters.AddWithValue("@id_funcionario", id_funcionario);//armazenando dados
                Conexao.comando.Parameters.AddWithValue("@id_veiculo", id_veiculo);
                Conexao.comando.Parameters.AddWithValue("@data_entrada", Convert.ToDateTime(data));
                Conexao.comando.Parameters.AddWithValue("@hora_inicio", Convert.ToDateTime(hora_inicio));
                Conexao.comando.ExecuteNonQuery();
                MessageBox.Show("Dados gravados com sucesso.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
       

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDiaria_Load(object sender, EventArgs e)
        {
            lblveiculo.Text = "";
            statusInicio();
            carregaGrid();
        }

        private bool verificaPlaca()
        {
            int contador=0;
            try
            {
                Conexao.fechaConexao();
                //sql que sera executado
                string sql = "SELECT * FROM  veiculo WHERE placa =@placa";
                //chama o metodo abre conexao
                Conexao.abreConexao();

                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);
                Conexao.comando.Parameters.AddWithValue("@placa", txtplaca.Text);
                Conexao.leitor = Conexao.comando.ExecuteReader();
               
                while(Conexao.leitor.Read())
                {
                    contador = contador + 1;
                    id_veiculo = Convert.ToInt32(Conexao.leitor["id_veiculo"].ToString());
                    lblveiculo.Text = Conexao.leitor["descricao"].ToString();
                   
                }
              

            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           //DataTable dt = new DataTable();
           // if (dt.Rows.Count > 0)
           if (contador > 0)
            {
               
                return true;

            }
            else
            {

                return false;
            }
        }

        private void lblveiculo_Click(object sender, EventArgs e)
        {

        }

        

        private void grdConsulta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //pega tudo da tabela e joga para meu grid,e converte pois aqui muda

            // captura o id do veiculo
            //id = Convert.ToInt32(grdConsulta.CurrentRow.Cells[0].Value.ToString());
            // txtcodigo.Text = grdConsulta.CurrentRow.Cells[0].Value.ToString();//passa para o campo
            txtconsultaplaca.Text = grdConsulta.CurrentRow.Cells[0].Value.ToString();
            txtconsultacliente.Text = grdConsulta.CurrentRow.Cells[1].Value.ToString();

       }

        //metodo para carregar o grid
        private void carregaGrid()//meu metodo
        {
            try
            {
                Conexao.fechaConexao();
                string sql = " SELECT " +
                              "diaria.id_diaria,diaria.data_entrada,diaria.hora_inicio, Veiculo.Descricao, Veiculo.Placa,Cliente.nome " +
                              "FROM diaria " +
                              "INNER JOIN Veiculo ON veiculo.id_veiculo = diaria.id_veiculo" +
                             " INNER JOIN Cliente ON cliente.id_cliente = veiculo.id_cliente";



                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Columns.Add("Codigo", typeof(string));
                dt.Columns.Add("Data", typeof(string));
                dt.Columns.Add("Hora", typeof(string));
                dt.Columns.Add("Descricao", typeof(string));
                dt.Columns.Add("Placa", typeof(string));
                dt.Columns.Add("Cliente", typeof(string));






                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();

                    dr["Codigo"] = Conexao.leitor["id_diaria"].ToString();
                    dr["Data"] = Conexao.leitor["data_entrada"].ToString();
                    dr["Hora"] = Conexao.leitor["hora_inicio"].ToString();
                    dr["Descricao"] = Conexao.leitor["Descricao"].ToString();
                    dr["Placa"] = Conexao.leitor["placa"].ToString();
                    dr["Cliente"] = Conexao.leitor["nome"].ToString();




                    dt.Rows.Add(dr);

                }

                grdConsulta.DataSource = dt;
                grdConsulta.Update();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void BtnConsultaPlacaVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.fechaConexao();
                string sql = "SELECT " +
                              "diaria.id_diaria,"+
                              "diaria.data_entrada,"+
                              "diaria.hora_inicio,"+
                              "Veiculo.Descricao,"+
                              "Veiculo.Placa ," +
                              "Cliente.nome " +
                              "FROM diaria  " +
                              "INNER JOIN Veiculo ON veiculo.id_veiculo = diaria.id_veiculo " +
                              "INNER JOIN Cliente ON cliente.id_cliente = veiculo.id_cliente " +
                             "WHERE 0=0 AND placa = @placa  OR nome =@nome";

                

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);

                Conexao.comando.Parameters.AddWithValue("@placa", txtconsultaplaca.Text.Trim());//parametro
                Conexao.comando.Parameters.AddWithValue("@nome", txtconsultacliente.Text.Trim());

                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable dt = new DataTable();

                //cabeçalho de minha tabela
                dt.Columns.Add("Cod", typeof(string));
                dt.Columns.Add("Data", typeof(string));
                dt.Columns.Add("Hora", typeof(string));
                dt.Columns.Add("descricao", typeof(string));
                dt.Columns.Add("placa", typeof(string));
                dt.Columns.Add("Cliente", typeof(string));



                while (Conexao.leitor.Read())
                {
                    DataRow dr = dt.NewRow();

                    //cabeçalho de minha tabela
                    dr["Cod"] = Conexao.leitor["id_diaria"].ToString();
                    dr["Data"] = Conexao.leitor["data_entrada"].ToString();
                    dr["Hora"] = Conexao.leitor["hora_inicio"].ToString();
                    dr["Descricao"] = Conexao.leitor["Descricao"].ToString();
                    dr["Placa"] = Conexao.leitor["placa"].ToString();
                    dr["Cliente"] = Conexao.leitor["nome"].ToString();

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

        
    }
}
