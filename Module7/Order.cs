using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    public class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery { get; set; }

        public int Number { get; set; }
        public string Description { get; set; }
        public Client Client { get; set; }
        public Product[] products { get; set; }

        private double orderCost;
        public double OrderCost
        {
            get => orderCost;
            set
            {
                var totalCost = CountTotalCost();
                if (Client.Rating > 100) orderCost = totalCost - totalCost * 0.1; //Расчет скидки
                else orderCost = totalCost;
            }
        }
        public bool IsPaid { get; set; } = false;

       public Order(TDelivery delivery, Client client)
        {
            Delivery = delivery;
            Client = client;
        }
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
        public void DisplayDeliveryInfo()
        {
            Delivery.DisplayInfo();
        }
        private double CountTotalCost()
        {
            double totalCost = 0;
            foreach (var item in products)
            {
                totalCost += item.Price;
            }
            return totalCost;
        }

    }
}
