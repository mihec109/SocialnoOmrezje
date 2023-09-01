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
    /// Interaction logic for DodajObjavo.xaml
    /// </summary>
    public partial class DodajObjavo : Window
    {
        //List<Objave> items = new List<Objave>();
        List<Objave> items;
        ListView listt;
        public DodajObjavo(List<Objave> _items, ListView _list)
        {
            InitializeComponent();
            items = _items;
            listt = _list;
            list.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new Objave() { Vsebina = textbox1.Text, Naslov = textbox4.Text, Slika = Convert.ToString(imgg.Source),
                Oznacen_prijatelj = textbox3.Text, Omogoci_komentiranje = check1.IsChecked.Value, Omogoci_lajkanje = check2.IsChecked.Value
            });
            list.ItemsSource = items;
            list.Items.Refresh();
            listt.Items.Refresh();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void Imgg_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void Button_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //uredi
            if (list.SelectedIndex > -1)
            {
                items.RemoveAt(list.SelectedIndex);
                Uredi2 win3 = new Uredi2(items, list, listt);
                Nullable<bool> dialogResult = win3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ni izbrana objava!");
            }
        }
    }
}
