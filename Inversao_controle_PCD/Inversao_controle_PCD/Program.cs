using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversao_controle_PCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PCD estacao = new PCD("Campus Norte");
            Universidade usp = new Universidade();
            
            estacao.AddObserver(usp);

            estacao.SetTipo("temp", 28.5);
            estacao.SetTipo("ph", 7.2);
            estacao.SetTipo("umidade", 60);
        }
    }
}
