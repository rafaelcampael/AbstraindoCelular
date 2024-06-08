using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celular_Csharp.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(){}
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string app)
        {
            Console.WriteLine($"Instalando o aplivativo {app} no Nokia.");
        }

        public override void ReceberLigacao()
        {
            throw new ArgumentException("Ocorreu um erro ao receber ligação.");
        }
    }
}
       
            
           
