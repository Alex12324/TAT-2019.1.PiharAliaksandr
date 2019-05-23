using System;

namespace DEV_10
{
    interface IShop
    {
        event Action<IShop> Changing;

        void DisplayInfo();
    }
}
