using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MH_SocialnoOmrezje
{
    public class OUporabniku : INotifyPropertyChanged
    {
        public string Ime;
        public string Priimek;
        public int Datum_roj;
        public List<OUporabniku> seznam_prijateljev = new List<OUporabniku> { };
        public List<Objave> seznam_objav = new List<Objave> { };

        public event PropertyChangedEventHandler PropertyChanged;

        public OUporabniku()
        {

        }

        public OUporabniku(string ime, string priimek, int datum_roj)
        {
            this.Ime = ime;
            this.Priimek = priimek;
            this.Datum_roj = datum_roj;
        }

        public string imee
        {
            get { return Ime; }
            set
            {
                Ime = value;
                OnPropertyChanged();
            }
        }

        public string pri
        {
            get { return Priimek; }
            set
            {
                Priimek = value;
                OnPropertyChanged();
            }
        }

        public int dat
        {
            get { return Datum_roj; }
            set
            {
                Datum_roj = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return "Ime: " + this.Ime + "\n" + "Priimek: " + this.Priimek +"\n" + "Datum rojstva: " + this.Datum_roj + "\n";
        }

        protected void OnPropertyChanged([CallerMemberName] string Ime = null, string Priimek  = null, int? Datum_roj = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Ime));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Priimek));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Convert.ToString(Datum_roj)));
        }
    }
}
