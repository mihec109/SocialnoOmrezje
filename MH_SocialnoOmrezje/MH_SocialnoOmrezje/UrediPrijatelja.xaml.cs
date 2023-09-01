using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MH_SocialnoOmrezje
{
    /// <summary>
    /// Interaction logic for UrediPrijatelja.xaml
    /// </summary>
    public partial class UrediPrijatelja : Window
    {
        List<OUporabniku> items = new List<OUporabniku>();

        public UrediPrijatelja()
        {
            InitializeComponent();
            //List<OUporabniku> items = new List<OUporabniku>();
            items.Add(new OUporabniku() { Ime = "John", Priimek = "Hirtl", Datum_roj = 42 });
            items.Add(new OUporabniku() { Ime = "Miha", Priimek = "Kupar", Datum_roj = 17 });
            items.Add(new OUporabniku() { Ime = "Vid", Priimek = "Rozman", Datum_roj = 22 });
            list.ItemsSource = items;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //dodaj
            DodajPrijatelja win22 = new DodajPrijatelja(items, list);
            Nullable<bool> dialogResult = win22.ShowDialog();
            list.ItemsSource = items;

            list.Items.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //izbrisi
            //List<OUporabniku> items = new List<OUporabniku>();

            if (list.SelectedIndex > -1)
            {
                items.RemoveAt(list.SelectedIndex);
                list.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Ni izbran prijatelj!");
            }
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //uredi
            if (list.SelectedIndex > -1)
            {
                items.RemoveAt(list.SelectedIndex);
                Uredi win2 = new Uredi(items, list);
                Nullable<bool> dialogResult = win2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ni izbran prijatelj!");
            }
            
        }
    }
}
