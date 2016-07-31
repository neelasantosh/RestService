using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace RestServicesDemo
{
    //this metadata is for preventing creation of new every object of Service
    //PerSession is for wsHTTP and for proxy calls it can be used
    //Single: it is like singleton class. Only one object for service
    //all binding supprt Single Context mode
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    class Service : iservice
    {
        List<Order> orders = new List<Order>();
        static int i = 0;
        public Service()
        {
            Console.WriteLine("Service constructor created!" + (i++));

            orders.Add(new Order { _orderId = 101, _custId = 1001, _orderAmount = 5430 });
            orders.Add(new Order { _orderId = 102, _custId = 1008, _orderAmount = 57945 });
            orders.Add(new Order { _orderId = 103, _custId = 1006, _orderAmount = 32340 });
            orders.Add(new Order { _orderId = 104, _custId = 1009, _orderAmount = 540 });
            orders.Add(new Order { _orderId = 105, _custId = 1009, _orderAmount = 36540 });
            orders.Add(new Order { _orderId = 106, _custId = 1001, _orderAmount = 878560 });
            orders.Add(new Order { _orderId = 107, _custId = 1001, _orderAmount = 45000 });
        }
        public List<Order> getOrders(string custId)
        {
            List<Order> temp = new List<Order>();
            foreach (Order o in orders)
            {
                if (o._custId == Convert.ToInt32(custId))
                {
                    temp.Add(o);
                }
            }
            /*bool status = !temp.Any();
            if (status) return temp;*/
            return temp;
        }

        public string getOrder(string orderId)
        {
            foreach (Order o in orders)
            {
                if (o._orderId == Convert.ToInt32(orderId)) return o.ToString();
            }
            return "Not Found!";
        }

        public int login(string userId, string password)
        {
            if (userId == "mohsin" && password == "123") return 1;
            else return 0;
        }
    }
}
