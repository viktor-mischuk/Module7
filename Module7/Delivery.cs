using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
   internal struct DeliveryDate
    {
        internal DateTime From; //Начало отсчета времени
        internal DateTime To; //Окончание отсчета времени
    }
    public abstract class Delivery
    {
        public string Address {  get; set; }
        public bool IsDone = false;
        public abstract void DisplayInfo();
    }
}
