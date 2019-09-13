using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rabbit.MVC.Models;
using Rabbit.MVC.Models.DTO;
using Rabbit.MVC.Services;

namespace Rabbit.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransferService _transferService;

        public HomeController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        public IActionResult Index()
        {
            return View();
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

        [HttpPost]
        public async Task<IActionResult> Transfer(TransferViewModel model)
        {
            TransferDTO transferDTO = new TransferDTO()
            {
                FromAccount = model.FromAccount,
                ToAccount = model.ToAccount,
                TransferAmout = model.TransferAmout
            };

            await _transferService.Transfer(transferDTO);

            return Ok();
        }
    }
}
