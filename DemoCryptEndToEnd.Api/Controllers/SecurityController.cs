using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Tools.Cryptography.Asymmetric;

namespace DemoCryptEndToEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private readonly ICryptoRSA _cryptoRSA;

        public SecurityController(ICryptoRSA cryptoRSA)
        {
            _cryptoRSA = cryptoRSA;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(JsonSerializer.Serialize(new { PublicKey = Convert.ToBase64String(_cryptoRSA.PublicBinaryKey) }));
        }
    }
}
