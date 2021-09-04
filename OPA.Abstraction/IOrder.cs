using OPA.Model;
using System;
using System.Threading.Tasks;

namespace OPA.Abstraction
{
    public interface IOrder
    {
        /// <summary>
        /// Generate Packing Slip based on the order types
        /// </summary>
        /// <returns></returns>
        Task<Response> ProcessOrder();
    }
}
