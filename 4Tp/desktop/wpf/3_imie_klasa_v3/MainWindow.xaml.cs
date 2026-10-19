using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2_imie_klasa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = imieBox.Text.Trim();
            string nazwisko = nazwiskoBox.Text.Trim();
            string klasa = kla.Text;

            if (women.IsChecked == false && man.IsChecked == false)
            {
                MessageBox.Show("Wybierz płeć!");
                return;
            }
            if (man.IsChecked == true)
            {
                wynik.Content = $"Uczeń: {imie} {nazwisko} z klasy {klasa}";
            }
            if (women.IsChecked == true)
            {
                wynik.Content = $"Uczennica: {imie} {nazwisko} z klasy {klasa}";
            }
        }

        private void Button_Wyczysc_Click(object sender, RoutedEventArgs e)
        {
            imieBox.Text = nazwiskoBox.Text = "";
            wynik.Content= imieBox.Text;
            imieBox.Focus();
        }
    }
}