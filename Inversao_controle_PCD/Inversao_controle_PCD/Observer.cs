using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inversao_controle_PCD
{
    internal interface Observer
    {
        void update(string tipo, double valor);
    }
}