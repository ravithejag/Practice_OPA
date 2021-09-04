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
        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
