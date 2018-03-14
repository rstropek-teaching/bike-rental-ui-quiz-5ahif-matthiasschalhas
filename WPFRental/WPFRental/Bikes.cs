using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRental
{
    class Bikes : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }

        public string _brand;
        public String Brand
        {
            get { return _brand; }
            set { _brand = value;  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_brand))); }
        }

        public DateTime? _purchaseDate;
        public DateTime? PurchaseDate
        {
            get { return _purchaseDate; }
            set { _purchaseDate = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_purchaseDate))); }
        }

        public string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value;PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_notes))); }
        }

        public DateTime? _lastService;
        public DateTime? LastService
        {
            get { return _lastService; }
            set { _lastService = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_lastService))); }
        }

        public double priceFirstHour;
        public double PriceFirstHour { get => priceFirstHour; set
            {
                priceFirstHour = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(priceFirstHour)));
            }
        }

        public double _priceAddHour;
        public double PriceAddHour
        {
            get { return _priceAddHour; }
            set { _priceAddHour = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_priceAddHour))); }
        }

        public String _category;
        public String Category
        {
            get { return _category; }
            set { _category = value;PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_category))); }
        }
    }
}
