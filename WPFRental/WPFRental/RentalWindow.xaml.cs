using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WPFRental
{
    /// <summary>
    /// Interaction logic for RentalWindow.xaml
    /// </summary>
    public partial class RentalWindow : Window
    {

        private MainWindow Window { get; set; }

        public RentalWindow(MainWindow win)
        {
            InitializeComponent();
            this.Window = win;
            BindUnpaidRentalsList();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        public void BindUnpaidRentalsList()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50819");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage Response = Client.GetAsync("api/rentals/unpaid").Result;

            ObservableCollection<UnpaidRentals> List = new ObservableCollection<UnpaidRentals>();

            if (Response.IsSuccessStatusCode)
            {
                var res = Response.Content.ReadAsAsync<IEnumerable<Object[]>>().Result;
                foreach (Object[] a in res)
                {
                    UnpaidRentals Neu = new UnpaidRentals()
                    {
                        CustomerID = Int32.Parse(a.GetValue(0).ToString()),
                        FirstName = a.GetValue(1).ToString(),
                        LastName = a.GetValue(2).ToString(),
                        BikeID = Int32.Parse(a.GetValue(3).ToString()),
                        BeginTime = DateTime.Parse(a.GetValue(4).ToString()),
                        EndTime = DateTime.Parse(a.GetValue(5).ToString()),
                        TotalCost = Double.Parse(a.GetValue(6).ToString())
                    };
                    List.Add(Neu);
                    
                }
                listBoxRentals.DataContext = List;
            }
            
        }

        private void CrudOperationListener(object sender, RoutedEventArgs e)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50819");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Button Button = sender as Button;
            UnpaidRentals Rental = listBoxRentals.SelectedItem as UnpaidRentals;
            if (Rental != null)
            {
                String url = "api/rentals/paid?idCustomer=" + Rental.CustomerID + "&idBike=" + Rental.BikeID;

                HttpResponseMessage Response = Client.GetAsync(url).Result;
                if (Response.IsSuccessStatusCode)
                {
                    this.BindUnpaidRentalsList();
                }
            }
        }


        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Window.Show();
        }
    } 
               
}
