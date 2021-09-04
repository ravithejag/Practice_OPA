using OPA.Model;
using System;
using System.Threading.Tasks;

namespace OPA.Abstraction
{
    public interface IOrder
    {
        Task<Response> GeneratePackingSlip();
    }
}
