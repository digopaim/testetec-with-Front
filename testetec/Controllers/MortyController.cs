using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteTec.Aplication.Services;
using TesteTec.Aplication.ViewModels;
using TesteTec.Domain.Entities;

namespace testetec.Controllers
{
    public class MortyController : ControllerBase
    {
        private readonly ILogger<Morty> _logger;
        private readonly MortyAppService _mortyAppService;
        
      [HttpGet]
      public List<MortyViewModel> Get()
        {
            var morty = _mortyAppService.GetAll().ToList();
            return morty;
        }
    }
}