using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    internal class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; set; }

        public ExtratorValorDeArgumentosURL(string url)
        {
            //IsNullOrEmpty é um método estático e por isso deve ser usado chamando através do tipo do objeto e não pela instância
            //Foi utilizada a classe String (S maísculo) para chamar o método para deixar bem claro que é um método estático da classe String
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("Argumento url não pode ser nulo ou vazio.", nameof(url));

            }

            URL = url;//.ToUpper();

            _argumentos = url.Substring(url.IndexOf('?') + 1);
            //_argumentos = _argumentos.ToUpper();

        }

        //moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            if (String.IsNullOrEmpty(nomeParametro))
            {
                throw new ArgumentException("Argumento nomeParametro não pode ser nulo ou vazio.", nameof(nomeParametro));

            }

            //string termoProcurado = nomeParametro + "=";



            string nomeParametroUpper = nomeParametro.ToUpper();
            string argumentosUpper = _argumentos.ToUpper();
            string parametro = _argumentos.Substring(argumentosUpper.IndexOf(nomeParametroUpper) + nomeParametroUpper.Length + 1);
            //string parametroUpper = parametro.ToUpper();
            if (parametro.Contains("&"))
            {
                return parametro.Remove(parametro.IndexOf('&'));
            }

            return parametro;
        }



    }
}
