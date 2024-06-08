using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular_Csharp.Models
{
    public abstract class Smartphone
    {
        
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }


        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação");
        }
        public abstract void InstalarAplicativo(string app);


    }
}



