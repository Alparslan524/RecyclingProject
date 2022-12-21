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
    public class TCController : ControllerBase
    {
        bool status;
        public async void TcDogrula(string ad, string soyad, long tc, int dogumTarih)
        {
            using (tcNoDogrula.KPSPublicSoapClient servis = new tcNoDogrula.KPSPublicSoapClient(tcNoDogrula.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
            {
                var response = await servis.TCKimlikNoDogrulaAsync(tc, ad.ToUpper(), soyad.ToUpper(), dogumTarih);
                status = response.Body.TCKimlikNoDogrulaResult;
                
            }
        }


        [HttpGet("tcdogrula")]
        public bool TcDogrulamaFrontEnd(string ad, string soyad, long tc, int dogumTarih)
        {
            TcDogrula(ad, soyad, tc, dogumTarih);
            Thread.Sleep(2000);
            return status;
        }


    }
}
