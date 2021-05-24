using Caelum.Stella.CSharp.Vault;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Dinheiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = 10.00;
            Debug.WriteLine(money);
            //
            var valor1 = 10.00;
            var valor2 = 20.00;
            Money dinheiro1 = valor1 + valor2;
            Debug.WriteLine(dinheiro1);
            //
            var minuendo = 20m;
            var subtraindo = 15m;
            Money dinheiro2 = minuendo - subtraindo;
            Debug.WriteLine(dinheiro2);
            //
            Money euros = new Money(Currency.EUR, 10000);
            Debug.WriteLine(euros);
            //
            Money dolars = new Money(Currency.USD, 100000);
            Debug.WriteLine(dolars);
            CultureChanger.ChangeCulture("en-US");
            Debug.WriteLine(dolars);
            CultureChanger.ChangeCulture("pt-BR");
            Debug.WriteLine(dolars);

            

        }
        class CultureChanger
        {
            public static void ChangeCulture(string idiomas)
            {
                CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(idiomas);
            }
        }
    }
}
