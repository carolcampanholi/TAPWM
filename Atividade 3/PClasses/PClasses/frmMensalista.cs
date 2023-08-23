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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void Inspecionar_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioHr.Text);
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            if (bttSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" +
                "Data entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + "\n" + objMensalista.VerificaHome());

        }

        private void Button2_Click(object sender, EventArgs e)
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

        private void TxtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNome_Click(object sender, EventArgs e)
        {

        }

        private void LblSalarioHr_Click(object sender, EventArgs e)
        {

        }

        private void LblDataEntrada_Click(object sender, EventArgs e)
        {

        }

        private void LblMatricula_Click(object sender, EventArgs e)
        {

        }

        private void BttSim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BttNão_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
