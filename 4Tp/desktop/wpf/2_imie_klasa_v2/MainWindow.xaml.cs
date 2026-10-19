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
            if (imieBox.Text.Trim()!= "" && klasaBox.Text.Trim()!= "")
            {
                string imie = imieBox.Text.Trim();
                string klasa = klasaBox.Text.Trim();
                wynik.Content = $"Uczeń: {imie} z klasy: {klasa}";
                wynik.Foreground = Brushes.Green;
            }
            else if(imieBox.Text.Trim()==""&& klasaBox.Text.Trim()=="")
            {
                wynik.Content = "Nie wypełniono żadnego pola";
                wynik.Foreground= Brushes.Red;
            }
            else if(imieBox.Text.Trim() == "")
            {
                wynik.Content = "Nie wypełniono pola imienia";
                wynik.Foreground = Brushes.Red;
            }
            else
            {
                wynik.Content = "Nie wypełniono pola klasy";
                wynik.Foreground = Brushes.Red;
            }
        }

        private void Button_Wyczysc_Click(object sender, RoutedEventArgs e)
        {
            imieBox.Text = klasaBox.Text = "";
            wynik.Content= imieBox.Text;
            imieBox.Focus();
        }
    }
}