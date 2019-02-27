using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var order Processor = new orderProcessor();
            var order = new OrderedParallelQuery { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process{ order};
        }
        public class OrderProcessor
        {
            private readonly ShippingCalculator _shippingCalculator;

            public OrderProcessor()
            {
                _shippingCalculator = new ShippingCalculator();
            }
            public void Process(Order order)
            {
                if (order.IsShipped)
                    throw new InvalidOperationException("This order is already processed.");

                order.Shipment = new Shipment
                {
                    Cost = _shippingCalculator.calculateshipping(order),
                    ShippingDate = DateTime.Today.AddDays(1)
                };
            }
        }
        public class shippingcalculator
        {
            public float Calculateshipping(Order order)
            {
                if (order.TotalPrice < 30f)
                    return order.TotalPrice = 0.1f;

                return 0;
            }
        }
    }
}
