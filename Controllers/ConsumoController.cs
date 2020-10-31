using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiConsumo.Models;

namespace WebApiConsumo.Controllers
{
    public class ConsumoController : ApiController
    {
        private Consumo consumo = new Consumo();

        public Consumo Get()
        {
            consumo.Ditancia = consumo.Tempo * consumo.VelMedia;
            consumo.QtdLitros = consumo.Ditancia / consumo.KmLitro;
            return consumo;
        }
    }
}
