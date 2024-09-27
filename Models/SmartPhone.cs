using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_celular_poo.Models
{
    public abstract class SmartPhone
    {
        public SmartPhone(string numero, string modelo, string imei, int memoria){

            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }

        public string Modelo { get; set;}

        public string Imei { get; set; }

        public int Memoria { get; set; }

        public void Ligar(){
            Console.WriteLine($"Ligando...");
        }

        public void RecebendoLigacao(){
            Console.WriteLine("Recebendo ligação");
        }

        public abstract void InstalandoApp(string nomeApp);
            
        
    }
}