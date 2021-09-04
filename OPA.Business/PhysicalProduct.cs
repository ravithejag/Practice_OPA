using OPA.Abstraction;
using OPA.Model;
using System;
using System.Threading.Tasks;

namespace OPA.Business
{
    public class PhysicalProduct : IOrder
    {
        private readonly IAgent agent;

        public PhysicalProduct()
        {

        }
        public PhysicalProduct(IAgent agent)
        {
            this.agent = agent;
        }
        public Task<Response> ProcessOrder()
        {
            agent.PayCommission();
            throw new NotImplementedException();
        }
    }
}
