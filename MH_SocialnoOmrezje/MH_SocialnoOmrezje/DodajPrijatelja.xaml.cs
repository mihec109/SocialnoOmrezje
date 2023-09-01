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
    /// Interaction logic for DodajPrijatelja.xaml
    /// </summary>
    public partial class DodajPrijatelja : Window
    {
        List<OUporabniku> items;
        ListView list;
        public DodajPrijatelja(List<OUporabniku> _items, ListView _list)
        {
            InitializeComponent();
            items = _items;
            list = _list;
            list.ItemsSource = items;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items.Add(new OUporabniku()
            {
                Ime = txt1.Text,
                Priimek = txt2.Text,
                Datum_roj = Convert.ToInt32(txt3.Text),
            });
            list.ItemsSource = items;
            list.Items.Refresh();
            this.Close();
        }
    }
}
