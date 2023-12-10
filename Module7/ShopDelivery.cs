using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    public class ShopDelivery : Delivery
    {
        DeliveryDate storeDate; //Интервал хранения
        public int idStoragePlace; //Номер места хранения
        ShopDelivery(DeliveryDate storeDate, int idStoragePlace)
        {
            this.storeDate = storeDate;
            this.idStoragePlace = idStoragePlace;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Период хранения с {storeDate.From} до {storeDate.To}");
        }
    }
}
