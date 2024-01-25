using koncertWpfEf.Models;
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

namespace koncertWpfEf.Controls
{
    /// <summary>
    /// Interaction logic for KoncertListazControl.xaml
    /// </summary>
    public partial class KoncertListazControl : UserControl
    {
        KoncertContext _context;
        public KoncertListazControl(Models.KoncertContext context)
        {
            _context = context;
            InitializeComponent();
            FillGrid();
        }

        private void FillGrid()
        {
            dgContext.ItemsSource = _context.Koncertek.ToList();
         //   dgContext.AutoGenerateColumns = false;
          
        }
    }
}
