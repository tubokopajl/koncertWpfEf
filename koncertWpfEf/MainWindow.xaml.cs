using koncertWpfEf.Controls;
using koncertWpfEf.Models;
using System.Runtime.CompilerServices;
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

namespace koncertWpfEf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly KoncertContext context;

        private KoncertAddControl koncertAddControl;

        private KoncertListazControl koncertListazControl;
        public MainWindow()
        {
         
            InitializeComponent();
            context = new KoncertContext();
            koncertAddControl = new KoncertAddControl(context);
            koncertListazControl = new KoncertListazControl(context);

        }

        private void menuListaz_Click(object sender, RoutedEventArgs e)
        {
            ccKoncert.Content = koncertListazControl;
        }

        private void menuFelvesz_Click(object sender, RoutedEventArgs e)
        {
           
         ccKoncert.Content = koncertAddControl;

            

           
        }

        private void menuFajl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}