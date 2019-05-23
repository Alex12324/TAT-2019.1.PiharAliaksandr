using System;
using System.Runtime.Serialization;

namespace DEV_10
{
    [DataContract]
    [Serializable]
    class Delivery : IShop
    {
        private int _ID;
        private string _description;
        private string _date;

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
        public string Description
        {
            get => _description;
            set
            {
                if(_description != value)
                {
                    _description = value;
                    this.Changing?.Invoke(this);
                }
                
            }
        }
        [DataMember]
        public string Date
        {
            get => _date;
            set
            {
                if(_date != value)
                {
                    _date = value;
                    this.Changing?.Invoke(this);
                } 
            }
        }

        public event Action<IShop> Changing;

        public void DisplayInfo()
        {
            Console.WriteLine($"ID : {this._ID}," +
                $"Description : {this._description}," +
                $"Date : {this._date}");
        }
    }
}
