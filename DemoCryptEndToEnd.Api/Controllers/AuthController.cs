using DemoCryptEndToEnd.Api.Models.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cryptography.Asymmetric;
using Tools.Cryptography.Hash;

namespace DemoCryptEndToEnd.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ICryptoRSA _cryptoRSA;

        public AuthController(ICryptoRSA cryptoRSA)
        {
            _cryptoRSA = cryptoRSA;
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterUserForm form)
        {
            byte[] cryptedPasswd = Convert.FromBase64String(form.Passwd);

            HashTool hashTool = new HashTool();
            byte[] hashPasswd = hashTool.Hash(Encoding.Unicode.GetBytes(_cryptoRSA.DecryptAsString(cryptedPasswd)));


            return NoContent();
        }
    }
}
