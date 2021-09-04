using OPA.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace OPA.Factory
{
    /// <summary>
    /// A Concrete Creator class
    /// </summary>
    public class ConcreteFactory : OPAFactory
    {
        public override IOrder GetOrderPaymentType(int orderType)
        {
            IOrder order = null;
            switch (orderType)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    throw new ApplicationException("Error in processing the payment, Please try again");
                    ///break;
            }
            return order;
        }
    }
}
