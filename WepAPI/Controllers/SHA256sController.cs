using Bussines.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SHA256sController : ControllerBase
    {
        ISHA256Service _sHA256Service;

        public SHA256sController(ISHA256Service sHA256Service)
        {
            _sHA256Service = sHA256Service;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(2000);
            var result = _sHA256Service.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPost("add")]
        public IActionResult Add(SHA256 sHA256)
        {
            Thread.Sleep(2000);
            var result = _sHA256Service.Add(sHA256);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SHA256 sHA256)
        {
            Thread.Sleep(2000);
            var result = _sHA256Service.Delete(sHA256);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(SHA256 sHA256)
        {
            Thread.Sleep(2000);
            var result = _sHA256Service.Update(sHA256);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyadress")]
        public IActionResult GetByAdress(string adress)
        {
            
            var result = _sHA256Service.GetByAdress(adress);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }




    }
}
