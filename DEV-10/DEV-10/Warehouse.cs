using System;
using System.Runtime.Serialization;

namespace DEV_10
{
    [DataContract]
    [Serializable]
    class Warehouse : IShop
    {
        private int _ID;
        private string _name;
        private string _adress;

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
        public string Adress
        {
            get => _adress;
            set
            {
                if(_adress != value)
                {
                    _adress = value;
                    this.Changing?.Invoke(this);
                }  
            }
        }

        public event Action<IShop> Changing;

        public void DisplayInfo()
        {
            Console.WriteLine($"ID : {this._ID}," +
                $"Name : {this._name}," +
                $"Adress : {this._adress}");
        }
    }
}
