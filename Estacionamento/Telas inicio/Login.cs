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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Boolean usuarioValido;

        

        private void btnAcesso_Click(object sender, EventArgs e)
        {

            try
            {
                usuarioValido = false;

                verificaUsuario();

                if (usuarioValido == true)
                {
                    txtSenha.Text = string.Empty;
                    this.Hide();
                    frmMenu Principal = new frmMenu();
                    Principal.ShowDialog();
                }
                else
                {

                    txtSenha.Text = string.Empty;

                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void carregaUsuario()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "SELECT * FROM funcionario ORDER BY usuario";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);
                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(Conexao.leitor);

                DataRow linha = tabela.NewRow();
                tabela.Rows.InsertAt(linha, 0);

                this.cmbUsuario.DataSource = tabela;
                this.cmbUsuario.ValueMember = "id_funcionario";
                this.cmbUsuario.DisplayMember = "usuario";
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



        private void verificaUsuario()
        {
            try
            {
                int i = 0;

                Conexao.fechaConexao();

                string sql = "SELECT * FROM Funcionario WHERE usuario = @usuario AND senha = @senha";
                Conexao.abreConexao();

                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);
                Conexao.comando.Parameters.AddWithValue("@usuario", cmbUsuario.Text);
                Conexao.comando.Parameters.AddWithValue("@senha", txtSenha.Text);

                Conexao.leitor = Conexao.comando.ExecuteReader();

                while (Conexao.leitor.Read())
                {
                    i = i + 1;
                }

                if (i > 0)
                {
                    usuarioValido = true;
                }
                else
                {
                    usuarioValido = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void CarregarUsuario()
        {
            try
            {
                Conexao.fechaConexao();

                string sql = "SELECT * FROM Funcionario ORDER BY usuario";

                Conexao.abreConexao();
                Conexao.comando = new System.Data.SqlClient.SqlCommand(sql, Conexao.conecta);
                Conexao.leitor = Conexao.comando.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(Conexao.leitor);

                DataRow linha = tabela.NewRow();
                tabela.Rows.InsertAt(linha, 0);

                this.cmbUsuario.DataSource = tabela;
                this.cmbUsuario.ValueMember = "id_funcionario";
                this.cmbUsuario.DisplayMember = "usuario";
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

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //usando a tecla enter usando evento keyDown 
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnAcesso.PerformClick();
            }
        }

        private void cmbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void btnAcessoRapido_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu principal = new frmMenu();
            principal.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbUsuario.Focus();
            CarregarUsuario();
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }
}

