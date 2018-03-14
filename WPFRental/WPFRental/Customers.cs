using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFRental
{
    class Customers : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }

        public int _gender;
        public int Gender
        {
            get { return _gender; }
            set { _gender = value; PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(nameof(_gender))); }
        }

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

        public DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_birthday))); }
        }

        public String _street;
        public string Street
        {
            get { return _street; }
            set { _street = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_street))); }
        }

        public int _houseNumber;
        public int HouseNumber
        {
            get { return _houseNumber; }
            set { _houseNumber = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_houseNumber))); }
        }

        public int _zipCode;
        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_zipCode))); }
        }

        public String _town;
        public string Town
        {
            get { return _town; }
            set { _town = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_town))); }
        }
    }
}
