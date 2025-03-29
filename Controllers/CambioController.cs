using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practica2025.Models; ///addd

namespace practica2025.Controllers
{
    
    [Route("[controller]")]
    public class CambioController : Controller
    {
        private const decimal TIPO_CAMBIO = 0.75m; // 1 BRL = 0.75 PEN

        public IActionResult Index()
        {
            return View(new TransaccionModel());
        }

        [HttpPost]
        public IActionResult Convertir(TransaccionModel transaccion)
        {
            if (transaccion.MonedaOrigen == "BRL" && transaccion.MonedaDestino == "PEN")
            {
                transaccion.Resultado = transaccion.Cantidad * TIPO_CAMBIO;
            }
            else if (transaccion.MonedaOrigen == "PEN" && transaccion.MonedaDestino == "BRL")
            {
                transaccion.Resultado = transaccion.Cantidad / TIPO_CAMBIO;
            }
            else
            {
                ModelState.AddModelError("", "Monedas no soportadas.");
            }

            return View("Index", transaccion);
        }
    }
}