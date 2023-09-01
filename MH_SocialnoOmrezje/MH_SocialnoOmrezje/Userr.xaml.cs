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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MH_SocialnoOmrezje
{
    /// <summary>
    /// Interaction logic for Userr.xaml
    /// </summary>
    public partial class Userr : UserControl
    {
        public Userr()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.Ime = ime.Text;
            Properties.Settings.Default.Priimek = priimek.Text;
            Properties.Settings.Default.Datum_rojstva = int.Parse(datum_roj.Text);
            Properties.Settings.Default.Save();
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

