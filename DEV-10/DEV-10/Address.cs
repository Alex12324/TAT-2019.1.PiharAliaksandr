using System;
using System.Runtime.Serialization;

namespace DEV_10
{
    [DataContract]
    [Serializable]
    class Address : IShop
    {
        private int _ID;
        private string _town;
        private string _street;
        private int _house;
        private string _country;

        [DataMember]
        public int ID
        {
            get => _ID;
            set
            {
                if (_ID != value)
                {
                    _ID = value;
                    this.Changing?.Invoke(this);
                }
            }
        }

        [DataMember]
        public string Town
        {
            get => _town;
            set
            {
                _town = value;
                this.Changing?.Invoke(this);
            }
        }

        [DataMember]
        public string Street
        {
            get => _street;
            set
            {
                if(_street != value)
                {
                    _street = value;
                    this.Changing?.Invoke(this);
                }
            }
        }

        [DataMember]
        public int House
        {
            get => _house;
            set
            {
                if(_house != value)
                {
                    _house = value;
                    this.Changing?.Invoke(this);
                }        
            }
        }

        [DataMember]
        public string Country
        {
            get => _country;
            set
            {
                if(_country != value)
                {
                    _country = value;
                    this.Changing?.Invoke(this);
                }
            }
        }

        public event Action<IShop> Changing;

        public void DisplayInfo()
        {
            Console.WriteLine($"ID : {this._ID}," +
                $"Town : {this._town}," +
                $"Street : {this._street}," +
                $"House : {this._house}," +
                $"Country : {this._country}");
        }
    }
}
