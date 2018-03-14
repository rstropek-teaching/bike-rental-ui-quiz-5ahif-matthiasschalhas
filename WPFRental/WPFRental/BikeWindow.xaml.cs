using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace WPFRental
{
    /// <summary>
    /// Interaction logic for BikeWindow.xaml
    /// </summary>
    public partial class BikeWindow : Window
    {

        private Bikes Bike { get; set; }
        private MainWindow MainWin { get; set; }

        public BikeWindow(MainWindow win)
        {
            InitializeComponent();
            this.MainWin = win;
            Bike = new Bikes();
            this.DataContext = Bike;
            this.BindBikesList();
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
                Bikes b = listboxBike.SelectedItem as Bikes;
                String Url = "api/bikes/" + b.Id;

                HttpResponseMessage Response = Client.DeleteAsync(Url).Result;
                if (Response.IsSuccessStatusCode)
                {
                    this.BindBikesList();
                }
            }
            else if (Button.Content.ToString().Contains("Hinzufügen"))
            {
                if(Bike.Brand != null && !Bike.Brand.Trim().Equals("") && Bike.PurchaseDate != null && Bike.Category != null && !Bike.Category.Trim().Equals("") && Bike.LastService != null
                   && Bike.Notes != null && Bike.PriceFirstHour >= 0 && Bike.PriceAddHour >= 0)
                {
                    String Url = "api/bikes";
                    HttpResponseMessage Response = Client.PutAsJsonAsync(Url, Bike).Result;
                    if (Response.IsSuccessStatusCode)
                    {
                        Bike = new Bikes();
                        this.DataContext = Bike;
                        this.BindBikesList();
                    }
                }
            }
            else if (Button.Content.ToString().Contains("Bearbeiten"))
            {
                Bikes Bike = listboxBike.SelectedItem as Bikes;
                if(Bike != null)
                {
                    if (Bike.Brand != null && !Bike.Brand.Trim().Equals("") && Bike.PurchaseDate != null && Bike.Category != null && !Bike.Category.Trim().Equals("") && Bike.LastService != null
                        && Bike.Notes != null && Bike.PriceFirstHour >= 0 && Bike.PriceAddHour >= 0)
                    {
                        String Url = "api/bikes/" + Bike.Id;
                        HttpResponseMessage Response = Client.PutAsJsonAsync(Url, Bike).Result;
                        if (Response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Fahrrad Bearbeitet");
                            this.BindBikesList();
                        }
                    }
                }
            }
        }

        public void BindBikesList()
        {
            HttpClient Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:50819");
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage Response = Client.GetAsync("api/Bikes").Result;

            if (Response.IsSuccessStatusCode)
            {
                IEnumerable<Bikes> res = null;
                if (cb1.IsChecked == true && cb2.IsChecked == true && cb3.IsChecked == true)
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result.OrderBy(a => a.PriceFirstHour).ThenBy(a => a.PriceAddHour).ThenByDescending(a => a.PurchaseDate);
                else if (cb1.IsChecked == true && cb2.IsChecked == true)
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result.OrderBy(a => a.PriceFirstHour).ThenBy(a => a.PriceAddHour);
                else if (cb1.IsChecked == true && cb3.IsChecked == true)
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result.OrderBy(a => a.PriceFirstHour).ThenByDescending(a => a.PurchaseDate);
                else if (cb1.IsChecked == true)
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result.OrderBy(a=>a.PriceFirstHour);
                else if (cb2.IsChecked == true && cb3.IsChecked == true)
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result.OrderBy(a => a.PriceAddHour).ThenByDescending(a => a.PurchaseDate);
                else if (cb2.IsChecked == true)
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result.OrderBy(a => a.PriceAddHour);
                else if(cb3.IsChecked == true)
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result.OrderByDescending(a => a.PurchaseDate);
                else
                    res = Response.Content.ReadAsAsync<IEnumerable<Bikes>>().Result;

                listboxBike.DataContext = res;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.MainWin.Show();
        }

        private void CheckedChanged(object sender, RoutedEventArgs e)
        {
            BindBikesList();
        }
    }
}
