using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_test_composite
{
    public interface Component
    {
        void Aggiunta(Component comp);

        void Rimuovi(int index);

        Component GetChild(int index);

        bool Equals(object obj);

        string ToString();

        double Punteggio();
    }
}
