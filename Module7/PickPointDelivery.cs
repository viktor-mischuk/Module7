using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class PickPointDelivery : Delivery
    {
        DeliveryDate storeDate; //Интервал хранения
        public int boxCode; //Код открытия ячейки
        PickPointDelivery(DeliveryDate storeDate, int boxCode)
        {
            this.storeDate = storeDate;
            this.boxCode = boxCode;
        }
        public override void DisplayInfo()
        {
            Console.Write($"Код открытия ячейки: {boxCode}");
        }
    }
}
