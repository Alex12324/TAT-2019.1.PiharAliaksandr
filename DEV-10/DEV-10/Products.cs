using System;
using System.Runtime.Serialization;

namespace DEV_10
{
    [DataContract]
    [Serializable]
    class Products : IShop
    {
        private int _ID;
        private string _name;
        private int _count;
        private int _manufacturer_ID;
        private int _warehouse_ID;
        private int _shipping_Description_ID;
        private string _product_Date;

        [DataMember]
        public int ID
        {
            get => this._ID;
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
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value) 
                {
                    _name = value;
                    this.Changing?.Invoke(this);
                }  
            }
        }
        [DataMember]
        public int Count
        {
            get => _count;
            set
            {
                if(_count != value)
                {
                    _count = value;
                    this.Changing?.Invoke(this);
                }
            }
        }
        [DataMember]
        public int Manufacturer_ID
        {
            get => _manufacturer_ID;
            set
            {
                if(_manufacturer_ID != value)
                {
                    _manufacturer_ID = value;
                    this.Changing?.Invoke(this);
                }   
            }
        }
        [DataMember]
        public int Warehouse_ID
        {
            get => _warehouse_ID;
            set
            {
                if(_warehouse_ID != value)
                {
                    _warehouse_ID = value;
                    this.Changing?.Invoke(this);
                }
            }
        }

        [DataMember]
        public int Shipping_Description_ID
        {
            get => _shipping_Description_ID;
            set
            {
                if(_shipping_Description_ID != value)
                {
                    _shipping_Description_ID = value;
                    this.Changing?.Invoke(this);
                }
            }
        }
        [DataMember]
        public string Product_Date
        {
            get => _product_Date;
            set
            {
                if(_product_Date != value)
                {
                    _product_Date = value;
                    this.Changing?.Invoke(this);
                }
            }
        }
        public event Action<IShop> Changing;

        public void DisplayInfo()
        {
            Console.WriteLine($"ID : {this._ID}," +
                $"Name : {this._name}," +
                $"Count : {this.Count}," +
                $"Manufacture_ID : {this._manufacturer_ID}," +
                $"Warehouse_ID {this.Warehouse_ID}," +
                $"Shipping_Description_ID {this._shipping_Description_ID}," +
                $"Product_Date : {this._product_Date}");
        }
    }
}
