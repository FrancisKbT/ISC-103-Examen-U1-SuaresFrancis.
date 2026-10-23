using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO1.Ejercicios
{
    public class Ejercicio01
    {
        public void envios()
        {
            decimal TarifaBase = 0.00m;
            decimal Extraenv = 0.00m;
            decimal PrecioKilo = 0.00m;
            decimal Seguro = 0.00m;
            decimal descuento = 0.00m;
            // bool seguro=false;


            Console.WriteLine("Cotizador de envios");
            Console.WriteLine("Introduzca su nombre:");
            string Nombre = Console.ReadLine() ?? "";//nombre

            Console.WriteLine("Introduzca su zona:");
            Console.WriteLine("1. Zona local");
            Console.WriteLine("2. Zona departamental");
            Console.WriteLine("3. Zona nacional");
            int Zona = int.TryParse(Console.ReadLine(), out int nro) ? nro:0;//zona

            Console.WriteLine("Introduzca el peso del paquete:");
            decimal Peso = decimal.TryParse(Console.ReadLine(), out decimal nropeso) ? nropeso:0.00m; //peso

            Console.WriteLine("Introduzca el valor del paquete:");
            decimal Valor = decimal.TryParse(Console.ReadLine(), out decimal nropval) ? nropval:0.00m; //valor

            Console.WriteLine("Introduzca su tipo de servicio:");
            Console.WriteLine("1. Estandar");
            Console.WriteLine("2. Express");
            Console.WriteLine("3. Mismo dia");
            int Envio = int.TryParse(Console.ReadLine(), out int nroenv) ? nroenv:0;//tipo de envio
            if (Peso <= 0 || Valor<0 || Zona>3 && Zona<1 ||Envio>3 || Envio<1 )
            {
                Console.WriteLine("El valor que introdujo es invalido");
                
            }
            else
            {
                switch (Zona)
                {
                    case 1:
                    TarifaBase=60;
                    Console.WriteLine($"Selecciono envio local, tarifa base asignada : {TarifaBase}");
                    break;
                    case 2:
                    TarifaBase=100;
                    Console.WriteLine($"Selecciono envio Departamental, tarifa base asignada : {TarifaBase}");
                    break;
                    case 3:
                    TarifaBase=150;
                    Console.WriteLine($"Selecciono envio  Nacional, tarifa base asignada : {TarifaBase}");
                    break;

                    default: Console.WriteLine("Opcion invalida"); break;
                }
                switch (Envio)
                {
                    case 1:
                    Extraenv=0.00m;
                    Console.WriteLine($"Selecciono envio estandar, tarifa base asignada : {Extraenv}");
                    break;
                    case 2:
                    Extraenv=0.25m;
                    Console.WriteLine($"Selecciono envio Departamental, tarifa base asignada : {Extraenv}");
                    break;
                    case 3:
                    Extraenv=0.50m;
                    Console.WriteLine($"Selecciono envio  Nacional, tarifa base asignada : {Extraenv}");
                    break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }
                if (Peso < 1)
                {
                    PrecioKilo = 0.00m;
                }
                else if (Peso <= 5)
                {
                    PrecioKilo = 40.00m;
                    Console.WriteLine($"El Recargo por peso es de {PrecioKilo}p/k");
                }
                else if (Peso <= 10)
                {
                    PrecioKilo = 80.00m;
                    Console.WriteLine($"El Recargo por peso es de {PrecioKilo}p/k");

                }
                else
                {
                    PrecioKilo = 140.00m;
                    Console.WriteLine($"El Recargo por peso es de {PrecioKilo}p/k");

                }

                if (Valor > 5000)
                {
                    Seguro=Valor*0.02m;
                    Console.WriteLine($"El valor por seguro sumado es de {Seguro}");
                }


                 decimal SubTotal= (TarifaBase*Peso*PrecioKilo);
                if (SubTotal > 700)
                {
                    descuento=0.05m;
                    Console.WriteLine("Su descuento es de {descuento} Lps");

                }

                //pendiente ternario

                Console.WriteLine($"Su total a pagar sera de {SubTotal-descuento+Seguro}");



                

            }

            
        }
    }
}