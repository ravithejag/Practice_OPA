using OPA.Model;
using System.Threading.Tasks;

namespace OPA.Abstraction
{
    public interface IEmailManager
    {
        Task<bool> SendMail(EmailDto emailDto);
    }
}
