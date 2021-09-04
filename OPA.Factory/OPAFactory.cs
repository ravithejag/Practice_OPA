using OPA.Abstraction;
using System;

namespace OPA.Factory
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class OPAFactory
    {
        public abstract IOrder GetOrderPaymentType(int orderType, string data=null);
    }
}
