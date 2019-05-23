using System;
using System.Runtime.Serialization;

namespace DEV_10
{
    [DataContract]
    [Serializable]
    class Manufacturer : IShop
    {
        private int _ID;

        private string _name;

        private int _registrationID;

        private string _country;

        [DataMember]
        public int ID
        {
            get => _ID;
            set
            {
                if(_ID != value)
                {
                    _ID = value;
                    this.Changing?.Invoke(this);
                } 
            }
        }

        [DataMember]
        public string Name
        {
            get => _name;
            set
            {
                if(_name != value)
                {
                    _name = value;
                    this.Changing?.Invoke(this);
                }
            }
        }

        [DataMember]
        public int RegistrationID
        {
            get => _registrationID;
            set
            {
                if(_registrationID != value)
                {
                    _registrationID = value;
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
                $"Name : {this._name}," +
                $"RegistrationID : {this._registrationID}," +
                $"Country : {this._country}");
        }
    }
}
