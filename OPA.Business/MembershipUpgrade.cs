using OPA.Abstraction;
using OPA.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.Business
{
    public class MembershipUpgrade : IOrder
    {
        private readonly IEmailManager emailManager;
        //public MembershipUpgrade(IEmailManager emailManager)
        //{
        //    this.emailManager = emailManager;
        //}
        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }
    }
}
