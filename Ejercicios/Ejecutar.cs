using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenPOO1.Ejercicios
{
    public class Ejecutar
    {
        public void ejecutar()
        {
            int op=0;
            Ejercicio01 ej1 = new Ejercicio01();
            
            Ejercicio02 ej2 = new Ejercicio02();
            
            Ejercicio03 ej3 = new Ejercicio03();

            Ejercicio04 ej4 = new Ejercicio04();
            
            Ejercicio05 ej5 = new Ejercicio05();
            
            Console.WriteLine("Menu de ejecucion de ejercicios");
            while (op != 6)
            {
                 Console.WriteLine("Seleccione el ejercicio a ejecutar");
                 op=int.TryParse(Console.ReadLine(), out int nro) ? nro:0;
                switch (op)
                {
                    case 1:
                    ej1.envios();
                    break;
                    case 2: 
                    ej2.Combustible();
                    break;
                    case 3:
                    ej3.Control();
                    break;
                    case 4:
                    ej4.Fila();
                    break;
                    case 5:
                    Console.WriteLine("Ejercicio no terminado,lo realizado esta comentado.");
                    break;
                    default: Console.WriteLine("Opcion invalida"); break;
                }

            }
        }
    }
}