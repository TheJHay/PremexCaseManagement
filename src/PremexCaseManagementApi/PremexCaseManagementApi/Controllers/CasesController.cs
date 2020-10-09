using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PremexCaseManagementApi.DataAccess;
using PremexCaseManagementApi.Models.Dtos.BigBoys;
using PremexCaseManagementApi.Models.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PremexCaseManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICaseManagementDataAccess _dataAccess;

        public CasesController(IMapper mapper, ICaseManagementDataAccess dataAccess)
        {
            _mapper = mapper;
            _dataAccess = dataAccess;
        }
        // GET: api/<CasesController>
        [HttpPost]
        public async Task<IActionResult> CreatePremexCase([FromBody] Message message)
        {
            var premexCase = _mapper.Map<PremexCase>(message);
            var createdId = await _dataAccess.CreateCase(premexCase);
            return Created("", premexCase);
        }

    }
}
