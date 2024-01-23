using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercitazione_test_composite
{
    public class Verofalso : Domanda
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public Verofalso()
        {
            Text = "";
        }

        public Verofalso(string text)
        {
            Text = text;
        }

        public Verofalso(Verofalso oldDomanda)
        {
            Text = oldDomanda.Text;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Verofalso) || obj == null)
                return false;

            Verofalso other = (Verofalso)obj;

            return Text == other.Text;
        }

        public void Aggiunta(Component comp)
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
            return $"il testo della domanda vero/falso: {Text};";
        }

        public double Punteggio()
        {
            return 0;
        }
    }
}
