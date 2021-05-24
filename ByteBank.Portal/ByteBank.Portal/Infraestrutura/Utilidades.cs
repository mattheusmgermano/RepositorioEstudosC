using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{
    public static class Utilidades
    {
        public static string IndicadorDirecaoAssembly(string caminho)
        {
            var prefixoAssembly = "ByteBank.Portal";
            var diretorioComPontos = caminho.Replace('/', '.');
            var diretorioCompleto = $"{prefixoAssembly}{diretorioComPontos}";
            return diretorioCompleto;

        }
        public static string ObterTipoDeConteudo(string caminho)
        {
            if (caminho.EndsWith(".css")) return "text/css; charset=utf-8";
            if (caminho.EndsWith(".js")) return "application/js; charset=utf-8";
            if (caminho.EndsWith(".html")) return "text/html; charset=utf-8";
            throw new NotImplementedException("Tipo de conteúdo não esperado!");
        }
    }
}
