using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_test_composite
{
    public class Test : Component
    {
        private List<Component> _lista;

        public List<Component> Lista
        {
            get { return _lista; }
            set { _lista = value; }
        }

        public Test()
        {
            Lista = new List<Component>();
        }

        public Test(List<Component> lista)
        {
            Lista = lista;
        }

        public Test(Test oldLista)
        {
            Lista = oldLista.Lista;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Test) || obj == null)
            {
                return false;
            }

            Test other = (Test)obj;

            foreach (var item in Lista)
            {
                if (!item.Equals(other))
                {
                    return false;
                }
            }

            return true;
        }

        public void Aggiunta(Component componente)
        {
            Lista.Add(componente);
        }

        public void Rimuovi(int index)
        {
            Lista.RemoveAt(index);
        }

        public Component GetChild(int index)
        {
            return Lista[index];
        }

        public override string ToString()
        {
            string str = "";

            foreach (var item in Lista)
            {
                str += item.ToString();
            }

            return str;
        }

        public double Punteggio()
        {
            return 0;
        }
    }
}
