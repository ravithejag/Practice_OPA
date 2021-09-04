using OPA.Abstraction;
using OPA.Factory;
using OPA.Model;
using System;
using System.Collections.Generic;

namespace OrderProcessingApplication
{
    class OrderProcessingApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("Welcome to the Order Processing Application");
            Console.WriteLine("******************************************************");
            Console.WriteLine("Please select the Appropriate Order type");

            var orderTypes = GetOrderTypes();

            foreach (var item in orderTypes)
            {
                Console.WriteLine(String.Format("{0} . {1}", item.Id, item.Description));
            }

            var orderType = Console.ReadLine();
            var data = string.Empty;
            if ((bool)(orderTypes.Find(x => x.Id == Convert.ToInt32(orderType))?.IsDetailsRequired))
            {
                Console.WriteLine("Please Enter the Video Name");
                data = Console.ReadLine();
            }

            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(Convert.ToInt32(orderType),data);
            Console.WriteLine(order.ProcessOrder());
        }

        public static List<Order> GetOrderTypes()
        {
            return new List<Order>
            {
                new Order{Id =1,Type="Physical product",Description="Payment for physical product"},
                new Order{Id =2,Type="Book",Description="Payment for a book"},
                new Order{Id =3,Type="Membership",Description="To Activate the membership"},
                new Order{Id =4,Type="MembershipUpgrade",Description="Apply for Membership Upgrade"},
                new Order{Id =5,Type="Video",Description="Payment for a Video",IsDetailsRequired=true}
            };
        }

    }
}
