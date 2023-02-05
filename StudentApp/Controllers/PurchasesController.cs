using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentApp.Data.ViewModels;
using StudentApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : Controller
    {
        readonly IPurchaseService _service;
        public PurchasesController(IPurchaseService purchaseService)
        {
            _service = purchaseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAllPurchases());
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_service.GetPurchaseById(id));
        }


        [HttpPost]
        public IActionResult AddPurchase([FromBody] PurchaseVM purchaseVM)
        {
            return Created("", _service.AddPurchase(purchaseVM));
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePurchase([FromBody] PurchaseVM purchaseVM, int id)
        {
            var school = _service.UpdatePurchase(purchaseVM, id);

            return Ok($"Purchase with id = {id} was updated");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            _service.DeletePurchaseById(id);

            return Ok($"Purchase with id {id} deleted");
        }
    }
}

