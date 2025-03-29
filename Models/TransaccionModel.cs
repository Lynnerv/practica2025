using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practica2025.Models
{
    public class TransaccionModel
    {
        public decimal Cantidad { get; set; }
        public string MonedaOrigen { get; set; }
        public string MonedaDestino { get; set; }
        public decimal Resultado { get; set; }
    }
}