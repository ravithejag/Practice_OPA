using OPA.Abstraction;
using OPA.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OPA.Business
{
    public class Membership : IOrder, IEmailManager
    {
        public Task<Response> ProcessOrder()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendMail(EmailDto emailDto)
        {
            throw new NotImplementedException();
        }
    }
}
