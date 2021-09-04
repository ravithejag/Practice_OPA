using OPA.Abstraction;
using OPA.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.Factory
{
    /// <summary>
    /// A Concrete Creator class
    /// </summary>
    public class OPAConcreteFactory : OPAFactory
    {
        public override IOrder GetOrderPaymentType(int orderType,string data)
        {
            IOrder order = null;
            switch (orderType)
            {
                case 1:
                    order = new PhysicalProduct();
                    break;
                case 2:
                    order = new Book();
                    break;
                case 3:
                    order = new Membership();
                    break;
                case 4:
                    order = new MembershipUpgrade();
                    break;
                case 5:
                    order = new Video();
                    break;
                default:
                    throw new ApplicationException("Error in processing the payment, Please try again");
                    ///break;
            }
            return order;
        }
    }
}
