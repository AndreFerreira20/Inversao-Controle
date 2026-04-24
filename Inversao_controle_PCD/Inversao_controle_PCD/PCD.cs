using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversao_controle_PCD
{
    internal class PCD : Subject
    {
        private double temp;
        private double ph;
        private double umidade;
        private string localiza;

        public PCD(string localiza) { this.localiza = localiza; }


        public double GetTemp() { return temp; }
        public double GetPh() { return ph; }
        public double GetUmidade() { return umidade; }
        public string GetLocaliza() { return localiza; }


        public void SetTipo(string tipo, double valor)
        {
            switch (tipo)
            {
                case "temp":
                    temp = valor;
                    NotifyObservers(tipo, valor);
                    break;
                case "ph":
                    ph = valor;
                    NotifyObservers(tipo, valor);
                    break;
                case "umidade":
                    umidade = valor;
                    NotifyObservers(tipo, valor);
                    break;
            }
        }
    }

}
