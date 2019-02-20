using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvalitetProjekt.Domain
{
    public class Order
    {
        private string OrderLines
        {
            get;
            set;
        }
        public string Costumer
        {
            get;
            set;
        }
        public string OrderID
        {
            get;
            set;
        }
        public string OrderDate
        {
            get;
            set;
        }
        public string DeliveryDate
        {
            get;
            set;
        }
        public string Picked
        {
            get;
            set;
        }
        public AddOrder(string product, string quantity, string price)
        {

        }

    }


}
