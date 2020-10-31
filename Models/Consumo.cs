using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiConsumo.Models
{
    public class Consumo
    {
        public double VelMedia { get; set; }
        public double Tempo { get; set; }
        public double KmLitro { get; set; }

        public double Ditancia { get; set; }
        public double QtdLitros { get; set; }

        public Consumo()
        {
            VelMedia = 10;
            Tempo = 2.8;
            KmLitro = 3;
            Ditancia = 0;
            QtdLitros = 0;
        }
    }
}