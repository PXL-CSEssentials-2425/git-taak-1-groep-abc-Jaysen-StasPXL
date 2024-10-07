using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace GIT_taak_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Kleurcodes en informatie
        string redCode = "#FF0000";
        string redInfo = "Rood is de kleur van warmte";

        string greenCode = "#008000";
        string greenInfo = "Groen is de kleur van genezing";

        string yellowCode = "#FFFF00";
        string yellowInfo = "Geel is de kleur van levenslust";

        string blueCode = "#0000FF";
        string blueInfo = "Blauw is de kleur van intelligentie";

        public MainWindow()
        {
            InitializeComponent();
        }

        // Event handlers voor klik op kleuren
        private void redImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = redCode;
            infoTextbox.Text = redInfo;
        }

        private void greenImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = greenCode;
            infoTextbox.Text = greenInfo;
        }

        private void yellowImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = yellowCode;
            infoTextbox.Text = yellowInfo;
        }

        private void blueImage_Click(object sender, RoutedEventArgs e)
        {
            codeTextbox.Text = blueCode;
            infoTextbox.Text = blueInfo;
        }