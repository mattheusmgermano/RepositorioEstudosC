using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Controller
{
    class BarbsController
    {
        public string BarbeariaGermano()
        {
            var nomeCompletoResource = "ByteBank.Portal.Assets.BarbeariaGermano.index.html";
            var assembly = Assembly.GetExecutingAssembly();
            var streamRecurso = assembly.GetManifestResourceStream(nomeCompletoResource);

            var streamLeitura = new StreamReader(streamRecurso);

            return streamLeitura;
        }
}
