using CRUDAppServer.DAL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDAppServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CascadingController : ControllerBase
    {
        private readonly EmpDbContext empDbContext;

        public CascadingController(EmpDbContext empDbContext)
        {
            this.empDbContext = empDbContext;
        }

        [HttpGet("getAllCountry")]
        public IActionResult getAllCountry()
        {
            var countryList = empDbContext.CountryMst.ToList();
            return Ok(countryList);
        }

        [HttpGet("GetStateById/{countryid}")]
        public IActionResult GetStateById(int countryid)
        {
            var stateList = empDbContext.StateMst.Where(a => a.countryId == countryid)
                .Select(a=>new { a.stateId,a.stateName });
            return Ok(stateList);
        }


    }
}
