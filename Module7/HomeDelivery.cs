using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    public class HomeDelivery : Delivery
    {
        DeliveryMan deliveryMan;
        DeliveryDate deliveryDate; //Интервал доставки
        HomeDelivery(DeliveryMan deliveryMan, DeliveryDate deliveryDate)
        {
            this.deliveryMan = deliveryMan;
            this.deliveryDate = deliveryDate;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Доставка товара произойдет с {deliveryDate.From} до {deliveryDate.To}");
            Console.WriteLine($"Ваш курьер: {deliveryMan.Name}");
            Console.WriteLine($"Телефон: {deliveryMan.Phone}");
        }

    }
}
