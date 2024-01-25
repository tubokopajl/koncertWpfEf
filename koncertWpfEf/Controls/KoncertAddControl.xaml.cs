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
    /// Interaction logic for KoncertAddControl.xaml
    /// </summary>
    public partial class KoncertAddControl : UserControl
    {
        KoncertContext _context;
        public KoncertAddControl(KoncertContext context)
        {
            _context = context;
            InitializeComponent();
        }

      

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //store Idopont in YYYY-MM-DD format
            string date = dpDatum.SelectedDate.Value.ToString("yyyy-MM-dd");

            Koncert koncert = new Koncert()
            {
                Cim = tbCim.Text,
                Eloado = tbEloado.Text,
                IdoPont = DateTime.Parse(date),
                Letszam = int.Parse(tbLetszam.Text),
                Ar = int.Parse(tbJegyar.Text),
                Helyszin = tbHelyszin.Text
            };
            _context.Koncertek.Add(koncert);
            _context.Database.EnsureCreated();
            _context.SaveChanges();
            MessageBox.Show("Sikeresen hozzáadva");
           //reset
            tbCim.Text = "";
            tbEloado.Text = "";
            dpDatum.Text = "";
            tbLetszam.Text = "";
            tbJegyar.Text = "";
            tbHelyszin.Text = "";
           

        }
    }
}
