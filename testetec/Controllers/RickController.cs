using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteTec.Aplication.Interfaces;
using TesteTec.Aplication.Services;
using TesteTec.Aplication.ViewModels;
using TesteTec.Domain.Entities;

namespace testetec.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RickController : Controller
    {
        private readonly ILogger<Rick> _logger;
        private readonly IRickAppService _rickAppService;
        public RickController(ILogger<Rick> logger,
           IRickAppService rickAppService)
        {
            _rickAppService = rickAppService;
            _logger = logger;
        }
        [HttpGet]
        public List<RickViewModel> Get()
        {
            var usuarios = _rickAppService.GetAll().ToList();
            return usuarios;
        }
        [HttpGet]
        [Route("GetById/{id?}")]
        public RickViewModel GetById(int id)
        {
            return _rickAppService.GetByIdFull(id);
        }
        [HttpPost]
        public void Post(RickViewModel model)
        {
            _rickAppService.Register(model);
        }
        [HttpPut]
        public void Put(RickViewModel model)
        {
            _rickAppService.Update(model);
        }
        [HttpDelete]
        public void Delete(RickViewModel model)
        {
            _rickAppService.Remove(model.Id);
        }
    }
}