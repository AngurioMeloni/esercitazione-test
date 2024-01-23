using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_test_composite
{
    public class multipla : Domanda
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public multipla()
        {
            Text = "";
        }

        public multipla(string testo)
        {
            Text = testo;
        }

        public multipla(multipla oldDomanda)
        {
            Text = oldDomanda.Text;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is multipla) || obj == null)
                return false;

            multipla other = (multipla)obj;

            return Text == other.Text;
        }

        public void Aggiunta(Component componente)
        {

        }

        public void Rimuovi(int index)
        {

        }

        public Component GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"il testo della domanda multipla: {Text};";
        }

        public double Punteggio()
        {
            return 0;
        }
    }
}
