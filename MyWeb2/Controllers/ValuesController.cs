using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CircleController : ControllerBase
    {
        [HttpGet("cv_dt")]
        public IActionResult Tinh(double rr)
        {
            if (rr < 0)
                return BadRequest("Radius must be over 0!");
            double cv = Math.PI * rr * 2;
            double dt = Math.PI * rr * rr;
            double dk = rr * 2;
            var json_str = new { dien_tich = dt, chu_vi = cv, duong_kinh = dk };
            return Ok(json_str);
        }
    }
}
