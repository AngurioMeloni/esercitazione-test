using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_test_composite
{
    public class singola : Domanda
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public singola()
        {
            Text = "";
        }

        public singola(string text)
        {
            Text = text;
        }

        public singola(singola oldDomanda)
        {
            Text = oldDomanda.Text;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is singola) || obj == null)
                return false;

            singola other = (singola)obj;

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
            return $"il testo della domanda singola: {Text};";
        }

        public double Punteggio()
        {
            return 0;
        }
    }
}
