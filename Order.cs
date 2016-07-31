using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestServicesDemo
{
    public class Order
    {
        private int orderId;
        private int custId;
        private double orderAmount;

       
        public int _orderId { get { return orderId; } set { orderId = value; } }
        public int _custId { get { return custId; } set { custId = value; } }
        public double _orderAmount { get { return orderAmount; } set { orderAmount = value; } }

        public Order() { }

        public Order(int orderId, int custId, string orderCity, double orderAmount)
        {
            this.orderId = orderId;
            this.custId = custId;
            this.orderAmount = orderAmount;
        }

        public override string ToString()
        {
            return "Order ID: " + orderId +
                ", Customer ID: " + custId + 
                ", Total Amount:" + orderAmount;
        }

    }
}
