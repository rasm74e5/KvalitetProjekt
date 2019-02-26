
using System.Collections.Generic;

namespace KvalitetProjekt.Domain
{
    public class Order
    {
        private List<SaleOrderLine> OrderLine = new List<SaleOrderLine>();

        private Costumer _customer;
        public Costumer Costumer
        {
            get { return _customer; }
            set { _customer = value; }
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
        public void AddOrderLine(string product, string quantity, string price)
        {

        }
        public void RemoveOrderLines(string OrderID) //index af 
        {

        }
        public void GetOrderLines()
        {
            
        }

    }


}
