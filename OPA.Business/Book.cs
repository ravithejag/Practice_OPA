using OPA.Abstraction;
using OPA.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.Business
{
   public class Book : IOrder
    {
        private readonly IAgent agent;

        public Book()
        {

        }
        public Book(IAgent agent)
        {
            this.agent = agent;
        }

        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
