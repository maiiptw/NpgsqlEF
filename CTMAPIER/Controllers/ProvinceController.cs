using CTMAPIER.Data;
using CTMAPIER.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CTMAPIER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly ProvinceContext _context;

        public ProvinceController(ProvinceContext context)
        {
            _context = context;
        }
        [HttpGet("GetProvince")]
        public async Task<ActionResult<Province>> Get()
        {
            //var provinces = _context.Provinces.ToList();
            var provinces = _context.Provinces.OrderByDescending(province => province.ProvinceCode)
                .Select(
                    province => new {province.ProvinceCode})
                .ToList();
            return Ok(provinces);
        }
    }
}
