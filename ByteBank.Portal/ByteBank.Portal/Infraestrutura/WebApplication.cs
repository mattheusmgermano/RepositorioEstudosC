using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Portal.Infraestrutura
{
    public class WebApplication
    {
        //O que está ouvindo?
        //precisamos definir.

        public string[] Prefixos { get; }
        public WebApplication(string[] prefixos)
        {
            if (prefixos == null)
            {
                throw new ArgumentNullException(nameof(prefixos));
            }
            Prefixos = prefixos;
        }


        public void Iniciar()
        {
            while (true)
            {
                ManipularRequisicao();
            }
        }

        public void ManipularRequisicao()
        {
            var httpListener = new HttpListener();
            foreach (var prefixo in Prefixos)
            {
                httpListener.Prefixes.Add(prefixo);
            }
            httpListener.Start();

            var contexto = httpListener.GetContext();
            var requisicao = contexto.Request;
            var resposta = contexto.Response;

            var caminho = requisicao.Url.AbsolutePath;

            var assembly = Assembly.GetExecutingAssembly();
            var nomeRecurso = Utilidades.IndicadorDirecaoAssembly(caminho);
            var streamRecurso = assembly.GetManifestResourceStream(nomeRecurso);
            var bytesRecurso = new byte[streamRecurso.Length];
            streamRecurso.Read(bytesRecurso, 0, (int)streamRecurso.Length);

            if(streamRecurso == null)
            {
                resposta.StatusCode = 404;
                resposta.OutputStream.Close();
            }

            resposta.ContentType = Utilidades.ObterTipoDeConteudo(caminho);
            resposta.StatusCode = 200;
            resposta.ContentLength64 = streamRecurso.Length;

            resposta.OutputStream.Write(bytesRecurso, 0, bytesRecurso.Length);

            resposta.OutputStream.Close();

            httpListener.Stop();
        }
    }
}
