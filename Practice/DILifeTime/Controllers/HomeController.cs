using DILifeTime.Models;
using LifeTime.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DILifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonServices singleton1;
        private readonly ISingletonServices singleton2;

        private readonly IScopedServices scope1;
        private readonly IScopedServices scope2;

        private readonly ITransientServices transient1;
        private readonly ITransientServices transient2;

        public HomeController(ITransientServices _transient1, ITransientServices _transient2,
                                IScopedServices _scoped1, IScopedServices _scoped2,
                                ISingletonServices _single1, ISingletonServices _single2)
        {
            singleton1 = _single1;
            singleton2 = _single2;
            scope1 = _scoped1;
            scope2 = _scoped2;
            transient1 = _transient1;
            transient2 = _transient2;
        }

        public IActionResult Index()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Transient 1:{transient1.GetServiceName()} \n");
            message.Append($"Transient 2:{transient2.GetServiceName()} \n\n\n");
            message.Append($"Scoped 1:{scope1.GetServiceName()} \n");
            message.Append($"Scoped 2:{scope2.GetServiceName()} \n\n\n");
            message.Append($"Transient 1:{singleton1.GetServiceName()} \n");
            message.Append($"Transient 2:{singleton2.GetServiceName()} \n\n\n");
            return Ok(message.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
