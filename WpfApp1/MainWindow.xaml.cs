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

namespace WpfApp1
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

        private void numerLabel_LostFocus(object sender, RoutedEventArgs e)
        {
            PictureImage.Source = new BitmapImage(new Uri($"{numerTextBox.Text}-zdjecie.jpg",UriKind.Relative));
            FingerprintImage.Source = new BitmapImage(new Uri($"{numerTextBox.Text}-odcisk.jpg", UriKind.Relative));
        }

        private void confirmButton_Click(object sender, RoutedEventArgs e)
        {
            string color = "";
            if (niebieskieRadioButton.IsChecked == true) color = "niebieskie";
            else if (zieloneRadioButton.IsChecked == true) color = "zielone";
            else if (piwneRadioButton.IsChecked == true) color = "piwne";
            if (color == "" || String.IsNullOrEmpty(imieTextBox.Text) == true || string.IsNullOrEmpty(nazwiskoTextBox.Text) == true)
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }
            MessageBox.Show($"{imieTextBox.Text} {nazwiskoTextBox.Text} kolor oczu {color}");
        }
    }
}