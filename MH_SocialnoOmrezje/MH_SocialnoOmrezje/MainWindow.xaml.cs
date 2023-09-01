using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace MH_SocialnoOmrezje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Objave> items1 = new List<Objave>();
        public MainWindow()
        {
            InitializeComponent();
            //ena.IsEnabled = true;
            //dva.IsEnabled = false;
            //ime.IsReadOnly = true;
            //priimek.IsReadOnly = true;
            //datum_roj.IsReadOnly = true;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Objave>));
            using (FileStream stream = File.OpenRead("pp.xml"))
            {
                items1 = (List<Objave>)serializer.Deserialize(stream);

            }
            list.ItemsSource = items1;
            list.Items.Refresh();

            items1.Add(new Objave()
            {
                Vsebina = "ToJeVsebina1",
                Naslov = "Naslov1",
                Slika = "slika1",
                Oznacen_prijatelj = "Miha Hirtl",
                Omogoci_komentiranje = false,
                Omogoci_lajkanje = false
            });
            items1.Add(new Objave()
            {
                Vsebina = "ToJeObjava brez prijatelja",
                Naslov = " brez prijatelja",
                Slika = "slika1",
                Omogoci_komentiranje = false,
                Omogoci_lajkanje = false
            });
            list.ItemsSource = items1;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex > -1)
            {
                items1.RemoveAt(list.SelectedIndex);
                list.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Ni izbrana objava!");
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            DodajObjavo win1 = new DodajObjavo(items1, list);
            Nullable<bool> dialogResult = win1.ShowDialog();
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Vsebina objave:");
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Vsebina objave:");
        }

        private void dc(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            items1.Add(new Objave() { Naslov = "NOVA OBJAVA!", Vsebina = "To je vsebina!" });
            list.ItemsSource = items1;

            list.Items.Refresh();
        }

        //private void Button_Click2(object sender, RoutedEventArgs e)
        //{
        //    ena.IsEnabled = false;
        //    dva.IsEnabled = true;
        //    ime.IsReadOnly = false;
        //    priimek.IsReadOnly = false;
        //    datum_roj.IsReadOnly = false;
        //}

        //private void Button_Click3(object sender, RoutedEventArgs e)
        //{
        //    Properties.Settings.Default.Ime = ime.Text;
        //    Properties.Settings.Default.Priimek = priimek.Text;
        //    Properties.Settings.Default.Datum_rojstva = int.Parse(datum_roj.Text);
        //    Properties.Settings.Default.Save();
        //    dva.IsEnabled = false;
        //    ena.IsEnabled = true;
        //    ime.IsReadOnly = true;
        //    priimek.IsReadOnly = true;
        //    datum_roj.IsReadOnly = true;
        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txt.Text == "Isci prijatelja: ")
            {
                txt.Text = "";
            }
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            UrediPrijatelja win = new UrediPrijatelja();
            Nullable<bool> dialogResult = win.ShowDialog();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            if (list.SelectedIndex > -1)
            {
                items1.RemoveAt(list.SelectedIndex);
                Uredi2 win3 = new Uredi2(items1, list, list);
                win3.Show();
            }
            else
            {
                MessageBox.Show("Ni izbrana objava!");
            }
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            //uvoz           
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            openFileDialog.Title = "Izberite datoteko!";

            openFileDialog.ShowDialog();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Objave>));

            using (FileStream stream = File.OpenRead(openFileDialog.FileName))
            {
                items1 = (List<Objave>)serializer.Deserialize(stream);

            }
            list.ItemsSource = items1;
            list.Items.Refresh();

        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            //izvoz
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML-File | *.xml";
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, Convert.ToString(items1));

            TextWriter writer = new StreamWriter(@saveFileDialog.FileName);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Objave>));
            serializer.Serialize(writer, items1);
        }

    }


}
