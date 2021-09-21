using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteOO
{
    public partial class FormContaBancaria : Form
    {
        public FormContaBancaria()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            ContaBancaria contaGui = new ContaBancaria("1234", "12345678", "90090090090");
            RespostaOperacaoBancaria resposta = contaGui.Depositar(2000);

            ContaBancaria contaCelo = new ContaBancaria("4567", "32165498", "90090090090");
            double valor = 1000;

            contaGui.Transferir(valor, contaCelo);

            MessageBox.Show(resposta.Mensagem);
        }
    }
}
