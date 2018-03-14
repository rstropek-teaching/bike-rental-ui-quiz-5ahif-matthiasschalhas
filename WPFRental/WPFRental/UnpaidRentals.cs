using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRental
{
    class UnpaidRentals : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        public int CustomerID { get; set; }

        public int BikeID { get; set; }

        public String _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_firstName))); }
        }

        public String _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_lastName))); }
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
    }
}
