using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Inspecionar_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHr.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            if (bttSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objHorista.TempoTrabalho() + "\n" + objHorista.VerificaHome());

        }

        private void FrmHorista_Load(object sender, EventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSalarioHr_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDataEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void BttNão_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BttSim_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
