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

namespace WpfConsole
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

  

        private void AggGatto_Click_1(object sender, RoutedEventArgs e)
        {
            AddCat add = new AddCat();
            add.Show();
            this.Close();
        }


        private void VisGatti_Click(object sender, RoutedEventArgs e)
        {
            ViewCat view = new ViewCat();
            view.Show();
            this.Close();
        }
    }
}