using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado 
    {
        private int matricula; //atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;


        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string NomeEmpregado
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public char HomeOffice
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        //Métodos

        public string VerificaHome()
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em Home Office";
            else
                return "Empregado NÃO trabalha em Home Office";
        }

        public virtual int TempoTrabalho()
        {
            // representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract
                (DataEntradaEmpresa);

            return (span.Days);
        }

        public abstract double SalarioBruto();
        
          

    }
}
