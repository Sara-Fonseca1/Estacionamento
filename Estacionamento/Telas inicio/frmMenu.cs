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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }


        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServiço serviço = new FrmServiço();
            serviço.ShowDialog();
        }



        private void veículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeículo Veículo = new frmVeículo();
            Veículo.ShowDialog();
        }



        //sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estacionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRecebimento Recebimento = new FrmRecebimento();
            Recebimento.ShowDialog();
        }
        //chamada Caixa
        private void caixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCaixa caixa = new FrmCaixa();
            caixa.ShowDialog();
        }
        //criando um objeto
      //  private void frmMenu_Load(object sender, EventArgs e)
      //  {
          //  Login Login = new Login();
           // Login.ShowDialog();
     //   }
        

        private void diariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiaria diaria = new FrmDiaria();
            diaria.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
