using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace WPFRental
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

        private void ClickEventButton(object sender, RoutedEventArgs e)
        {
            Button But = sender as Button;
            switch (But.Name)
            {
                case "bike":
                    BikeWindow bikeWin = new BikeWindow(this);
                    bikeWin.Show();
                    break;
                case "cust":
                    CustomerWindow custWin = new CustomerWindow(this);
                    custWin.Show();
                    break;
                case "rent":
                    RentalWindow rentWin = new RentalWindow(this);
                    rentWin.Show();
                    break;
            }
            this.Visibility = Visibility.Collapsed;
        }
    }
}
