using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace ExamenPOO1.Ejercicios
{
    public class Ejercicio03
    {
        public void Control()
        {
            int i;
            int siasis=0;
            int noasis=0;
            int j=0;
            bool esta=false;
            Console.WriteLine($"Control de asistencia de participantes");
            string[] participantes= new string[10];
            participantes[0]= "Jose";
            participantes[1]= "Josue";
            participantes[2]= "Maria";
            participantes[3]= "Pedro";
            participantes[4]= "Juan";
            participantes[5]= "Carlos";
            participantes[6]= "Sarahi";
            participantes[7]= "bryan";
            participantes[8]= "Darlan";
            participantes[9]= "Tayron";
            bool[] asistencia = new bool[9];
            asistencia[0] = true;
            asistencia[1] = false;
            asistencia[2] = false;
            asistencia[3] = true;
            asistencia[4] = true;
            asistencia[5] = false;
            asistencia[6] = true;
            asistencia[7] = true;
            asistencia[8] = false;
            asistencia[9] = true;
            for ( i = 9; i >= 0; i--)
            Console.WriteLine($"Lista de asistencia");
            {
                if (asistencia[i] == true)
                {
                    Console.WriteLine($"{participantes[i]} ");
                    siasis++;
                }
                else
                {
                    Console.WriteLine($"{participantes[i]} ");

                    noasis++;
                }

            }
            i=0;
            foreach(string nombres in participantes)
            {

                if (asistencia[i] == false)
                {
                    Console.WriteLine($"{participantes[i]} no asistio ");

                }
            };
           Console.WriteLine($"{siasis} participantes asistieron, {noasis} participantes no asistieron. Porcentaje de asistencia: {(siasis/noasis)*100}");
           Console.WriteLine($"Que nombre desea buscar? ");
           string nombreins = Console.ReadLine() ?? "";
           int part=0;
           for (j = 0; j <= 9; j++)
           {    
            if(participantes[j]== nombreins)
                {
                    esta=true;
                    part=j;
                }
                else
                {
                    esta=false;
                }
            
           }
            if (esta == true)
            {
                if (asistencia[part] == true)
                {
                  Console.WriteLine($"El participante {nombreins} esta en la lista, Si asistio. ");
                }
                else
                {
                  Console.WriteLine($"El participante {nombreins} esta en la lista, NO asistio. ");

                }
            }

        }
    }
}