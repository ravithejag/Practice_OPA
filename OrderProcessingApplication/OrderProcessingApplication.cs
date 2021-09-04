using OPA.Model;
using System;
using System.Collections.Generic;

namespace OrderProcessingApplication
{
    class OrderProcessingApplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public List<Order> GetOrderTypes()
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
