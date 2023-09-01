using Microsoft.Win32;
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
    /// Interaction logic for Uredi2.xaml
    /// </summary>
    public partial class Uredi2 : Window
    {
        List<Objave> items;
        ListView list;
        ListView listt;
        public Uredi2(List<Objave> _items, ListView _list, ListView _listt)
        {
            InitializeComponent();
            items = _items;
            list = _list;
            listt = _list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool a;
            bool b;
            if (check1.IsChecked ?? false)
            {
                a = false;
            }
            else
            {
                a = true;
            }
            if (check2.IsChecked ?? false)
            {
                b = false;
            }
            else
            {
                b = true;
            }
            items.Add(new Objave()
            {
                Vsebina = textbox1.Text,
                Naslov = textbox4.Text,
                Slika = Convert.ToString(imgg.Source),
                Oznacen_prijatelj = textbox3.Text,
                Omogoci_komentiranje = a,
                Omogoci_lajkanje = b
            });
            list.Items.Refresh();
            listt.Items.Refresh();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files| *.jpg; *.jpeg; *.png;";
            openFileDialog.Title = "Izberite sliko!";
            //openFileDialog.ShowDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                imgg.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }
        }
    }
}
