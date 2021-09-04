using OPA.Abstraction;
using OPA.Model;
using System;
using System.Threading.Tasks;

namespace OPA.Business
{
    public class EmailManager : IEmailManager
    {
        public Task<bool> SendMail(EmailDto emailDto)
        {
            throw new NotImplementedException();
        }
    }
}
