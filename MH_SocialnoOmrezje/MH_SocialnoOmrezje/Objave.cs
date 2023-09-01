using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MH_SocialnoOmrezje
{
    public class Objave : INotifyPropertyChanged
    {
        public string Vsebina;
        public string Slika;
        public string Oznacen_prijatelj;
        public string Naslov;
        public bool Omogoci_komentiranje;
        public bool Omogoci_lajkanje;

        public event PropertyChangedEventHandler PropertyChanged;


        public Objave()
        {

        }

        public Objave(string vsebina, string slika, string oznacen, string naslov, bool omogocik, bool omogocil)
        {
            this.Vsebina = vsebina;
            this.Slika = slika;
            this.Oznacen_prijatelj = oznacen;
            this.Naslov = naslov;
            this.Omogoci_komentiranje = omogocik;
            this.Omogoci_lajkanje = omogocil;
        }

        public string vseb
        {
            get { return Vsebina;}
            set
            {
                Vsebina = value;
                OnPropertyChanged();
            }
        }

        public string slik
        {
            get { return Slika; }
            set
            {
                Slika = value;
                OnPropertyChanged();
            }
        }

        public string ozn
        {
            get { return Oznacen_prijatelj; }
            set
            {
                Oznacen_prijatelj = value;
                OnPropertyChanged();
            }
        }

        public string nas
        {
            get { return Naslov; }
            set
            {
                Naslov = value;
                OnPropertyChanged();
            }
        }

        public bool omk
        {
            get { return Omogoci_komentiranje; }
            set
            {
                Omogoci_komentiranje = value;
                OnPropertyChanged();
            }
        }

        public bool oml
        {
            get { return Omogoci_lajkanje; }
            set
            {
                Omogoci_lajkanje = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return "Naslov: " + this.Naslov + "\n" + "Vsebina: " + this.Vsebina + "\n " + "Slika: " + this.Slika + "\n" + "Oznaceni prijatelji: " + this.Oznacen_prijatelj + "\n" + "Omogoceni komentarji: " + this.Omogoci_komentiranje + "\n" + "Omogoceno lajkanje: " + this.Omogoci_lajkanje + "\n";
        }

        protected void OnPropertyChanged([CallerMemberName] string Vsebina = null, string Slika = null, string Oznacen_prijatelj = null, string Naslov = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Vsebina));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Slika));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Oznacen_prijatelj));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Naslov));
        }
    }
}
