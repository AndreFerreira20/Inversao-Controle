using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversao_controle_PCD
{
    internal class Subject
    {
        List<Observer> observers = new List<Observer>();

        public Subject() { }

        public void AddObserver(Observer observer) { observers.Add(observer); }
        public void RemoveObserver(Observer observer) { observers.Remove(observer); }

        public void NotifyObservers(string tipo, double valor)
        {
            // Callback está aqui. Ele está apenas passando o tipo e o valor
            // que foi alterado, esperando que o observador possui um método update.
            foreach (Observer universidade in observers)
            {
                universidade.update(tipo, valor);
            }
        }
    }
}
