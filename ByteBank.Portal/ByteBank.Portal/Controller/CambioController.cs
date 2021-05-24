using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Service;
using ByteBank.Service.Cambio;

namespace ByteBank.Portal.Controller
{
    public class CambioController
    {
        private ICambioService _cambioService;
        public CambioController()
        {
            _cambioService = new CambioTesteService();
        }
        public string MXN()
        {
            var valorFinal = _cambioService.Calcular("MXN", "BRL", 1);
            var nomeCompletoResource = "ByteBank.Portal.View.Cambio.MXN.html";
            var assembly = Assembly.GetExecutingAssembly();
            var streamRecurso = assembly.GetManifestResourceStream(nomeCompletoResource);

            var streamLeitura = new StreamReader(streamRecurso);

            var textoPagina = streamLeitura.ReadToEnd();
            return null;
        }
        public string USD()
        {
            return null;
        }
    }
}
