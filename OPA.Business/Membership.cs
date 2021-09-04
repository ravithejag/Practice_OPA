using OPA.Abstraction;
using OPA.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.Business
{
    public class Membership : IOrder
    {
        private readonly IEmailManager emailManager;
        //public Membership(IEmailManager emailManager)
        //{
        //    this.emailManager = emailManager;
        //}
        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }

    }
}
