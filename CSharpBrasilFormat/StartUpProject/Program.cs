using System;
using System.Diagnostics;
using System.Globalization;

namespace StartUpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2017, 09, 23);
            Debug.WriteLine(data.ToString("d"));
            Debug.WriteLine(data.ToString("d", new CultureInfo("pt-BR")));
            Debug.WriteLine(data.ToString("dd/MM"));
            Debug.WriteLine(data.ToString("dd/MM/yy"));
            Debug.WriteLine(data.ToString("dd/MM/yyyy"));

            data = new DateTime(2017, 09, 23, 14, 15, 39, 987);
            Debug.WriteLine(data);
            Debug.WriteLine(data.ToString("HH:mm"));
            Debug.WriteLine(data.ToString("D"));
            Debug.WriteLine(data.ToString("m"));
            Debug.WriteLine(data.ToString("Y"));
            Debug.WriteLine(data.ToString("G"));
            Debug.WriteLine(data.ToString("g"));
            Debug.WriteLine(data.ToString("O"));
            Debug.WriteLine(DateTime.Parse(data.ToString("O")));
        }
    }
}
