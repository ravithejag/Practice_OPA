using OPA.Abstraction;
using OPA.Model;
using System;
using System.Threading.Tasks;

namespace OPA.Business
{
    public class PhysicalProduct : IOrder
    {
        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
