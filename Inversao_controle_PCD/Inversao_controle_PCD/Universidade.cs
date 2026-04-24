using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversao_controle_PCD
{
    internal class Universidade : Observer
    {
        private string nome;

        // Implementação do callback, ele vai ser chamado de volta
        // sempre que houver uma mudança no sujeito
        public void update(string tipo, double valor)
        {
            Console.WriteLine($"Recebido o dado [{tipo}] com valor: {valor}");

            // Após isso a universidade toma a decisão de o que fazer
            // com a informação recebida
        }
    }
}
