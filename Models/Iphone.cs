using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular_Csharp.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(){}
        public Iphone(int numero, string modelo, string imei, int memoria){}
        public override void InstalarAplicativo(string app)
        {
            Console.WriteLine($"Instalando o aplicativo {app} no iPhone.");
        }

        public override void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação");
        }
    }
}
       
        
