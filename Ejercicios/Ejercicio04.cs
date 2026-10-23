using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO1.Ejercicios
{
    public class Ejercicio04
    {
        int opcion =0;
        int urgencia=0;
        string temporal="";

        List<string> pacientesurgentes = new List<string>();
        List<string> pacientesnourg = new List<string>();


        public void Fila()
        {
            while (opcion != 5)
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1. agregar pacientes");
                Console.WriteLine("2. antender pacientes");
                Console.WriteLine("3. mostrar fila");
                Console.WriteLine("4. Buscar paciente");
                Console.WriteLine("5. salir");
                opcion=int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
                switch (opcion)
                {
                    case 1: 
                    Console.WriteLine("El paciente necesita atencio urgente? 1 si, 2 no");
                    urgencia= int.TryParse(Console.ReadLine(), out int nrour) ? nrour:0;
                        if (urgencia == 1)
                        {
                           Console.WriteLine("inserte nombre del paciente:");
                           temporal=Console.ReadLine() ?? "";
                           pacientesurgentes.Add(temporal);

                        }
                        else if(urgencia == 2)
                        {
                           Console.WriteLine("inserte nombre del paciente:");
                           temporal=Console.ReadLine() ?? "";
                           pacientesnourg.Add(temporal);
                        }
                        else Console.WriteLine("Entrada invalida");

                    break;
                    case 2: 
                    Console.WriteLine("El paciente necesita atencio urgente? 1 si, 2 no");
                    urgencia= int.TryParse(Console.ReadLine(), out  nrour) ? nrour:0;
                        if (urgencia == 1)
                        {
                           
                           pacientesurgentes.RemoveAt(0);

                        }
                        else if(urgencia == 2)
                        {
                           
                           pacientesnourg.RemoveAt(0);
                        }
                        else Console.WriteLine("Entrada invalida");

                    break;
                    case 3: 
                    Console.WriteLine($"Se encuentran {pacientesurgentes.Count} pacientes urgentes y {pacientesnourg}pacientes no urgentes");
                    break;
                    case 4: 
                    Console.WriteLine("ingrese nombre de paciente a buscar");
                    string pacientebs= Console.ReadLine() ?? "";
                    if(pacientesurgentes.Contains(pacientebs)== true)
                        {
                            Console.WriteLine("EL paciente se encontro en la lista de pacientes urgentes");
                        }
                    else if (pacientesnourg.Contains(pacientebs) == true)
                        {
                            Console.WriteLine("EL paciente se encontro en la lista de pacientes no urgentes");

                        }
                        else
                        {
                            Console.WriteLine("EL paciente no se encontro en ninguna lista");
                        }
                    break;
                    case 5: 
                    Console.WriteLine("Saliendo...");
                    break;
                    default: Console.WriteLine("Opcion invalida"); break;

                }

                
            }
        }
    }
}