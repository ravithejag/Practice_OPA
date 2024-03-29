﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OPA.Abstraction;
using OPA.Business;
using OPA.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OPA.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        public OrderController(IOrder agent)
        {
            agent = new PhysicalProduct();
            agent.ProcessOrder();
        }

        [HttpGet]
        public string Get(int id)
        {
            OPAFactory oPAFactory = new OPAConcreteFactory();
            IOrder order = oPAFactory.GetOrderPaymentType(id);

            return order.ProcessOrder().Result.Message;
        }
    }
}
