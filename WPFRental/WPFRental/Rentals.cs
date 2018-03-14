using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRental
{
    class Rentals: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }

        public Customers _customer;
        public Customers Customer
        {
            get { return _customer; }
            set { this._customer = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_customer))); }
        }

        public Bikes _bike;
        public Bikes Bike
        {
            get { return _bike; }
            set { this._bike = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_bike))); }
        }

        public DateTime _beginTime;
        public DateTime BeginTime
        {
            get { return _beginTime; }
            set { this._beginTime = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_beginTime))); }
        }

        public DateTime _endTime;
        public DateTime EndTime
        {
            get { return _endTime; }
            set { this._endTime = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_endTime))); }
        }

        public double _totalCost;
        public double TotalCost
        {
            get { return _totalCost; }
            set { this._totalCost = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_totalCost))); }
        }

        public Boolean _paid;
        public Boolean Paid
        {
            get { return _paid; }
            set { this._paid = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_paid))); }
        }
    }
}
