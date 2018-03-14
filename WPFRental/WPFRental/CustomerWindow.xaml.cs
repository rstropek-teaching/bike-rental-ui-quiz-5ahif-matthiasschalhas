using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window,INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Customers Customer { get; set; }
        private MainWindow Window { get; set; }

        public CustomerWindow(MainWindow win)
        {
            InitializeComponent();
            this.Window = win;
            Customer = new Customers();
            this.DataContext = Customer;
            
            this.BindCustList("");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CrudOperationListener(object sender, RoutedEventArgs e)
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50819");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            Button Button = sender as Button;
            if (Button.Content.ToString().Contains("Löschen"))
            {
                Customers c = listboxCustomer.SelectedItem as Customers;
                String Url = "api/customers/" + c.Id;

                HttpResponseMessage Response = Client.DeleteAsync(Url).Result;
                if (Response.IsSuccessStatusCode)
                {
                    this.BindCustList("");
                }
            }
            else if (Button.Content.ToString().Contains("Hinzufügen"))
            {
                
                if(Customer.Birthday != null && Customer.FirstName != null && !Customer.FirstName.Trim().Equals("") && Customer.LastName != null && !Customer.LastName.Trim().Equals("") && 
                   Customer.HouseNumber > 0 && Customer.Street != null && !Customer.Street.Trim().Equals("") && Customer.Town != null && !Customer.Town.Trim().Equals("") && Customer.ZipCode > 0)
                {
                    String url = "api/Customers";
                    HttpResponseMessage Response = Client.PutAsJsonAsync(url, Customer).Result;
                    if (Response.IsSuccessStatusCode)
                    {
                        Customer = new Customers();
                        this.DataContext = Customer;
                        this.BindCustList("");
                    }
                }
            }
            else if (Button.Content.ToString().Contains("Bearbeiten"))
            {
                
                Customers Customer = listboxCustomer.SelectedItem as Customers;
                if (Customer != null)
                {
                    if (Customer.Birthday != null && Customer.FirstName != null && !Customer.FirstName.Trim().Equals("") && Customer.LastName != null && !Customer.LastName.Trim().Equals("") &&
                        Customer.HouseNumber > 0 && Customer.Street != null && !Customer.Street.Trim().Equals("") && Customer.Town != null && !Customer.Town.Trim().Equals("") && Customer.ZipCode > 0)
                    {
                        String url = "api/customers/" + Customer.Id;
                        HttpResponseMessage Response = Client.PutAsJsonAsync(url, Customer).Result;
                        if (Response.IsSuccessStatusCode)
                        {

                            this.BindCustList("");
                        }
                    }
                }
            }
        }

        public void BindCustList(String filter)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50819");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            String Url = "api/customers";
            if (!filter.Trim().Equals(""))
            {
                Url += "/" + filter;
            }

            HttpResponseMessage Response = client.GetAsync(Url).Result;
            if (Response.IsSuccessStatusCode)
            {
                var res = Response.Content.ReadAsAsync<IEnumerable<Customers>>().Result;
                listboxCustomer.DataContext = res;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Window.Show();
        }

        private void FilterChange(object sender, TextChangedEventArgs e)
        {
            BindCustList(textFilter.Text.Trim());
        }
    }
}
