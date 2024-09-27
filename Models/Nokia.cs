using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_celular_poo.Models
{
    public class Nokia : SmartPhone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalandoApp(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} em Nokia");
        }
    }
}