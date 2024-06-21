using System;

namespace estacionesNUM
{
    public class Program

    {
        enum Estacion
        { 
            Primavera,
            Verano,
            Otonio,
            Invierno
        }
        public static void Main()

        {
            Console.WriteLine("Escribe la estación del año (Primavera, Verano, Otonio, Invierno): \n");
            string probando = Console.ReadLine();

            Estacion estacionSeleccionada;

            if (!Enum.TryParse(probando, true, out estacionSeleccionada))
            {
                Console.WriteLine("Estación inválida. Por favor, ingresa una estación válida. ");
                return;
            }

            switch (estacionSeleccionada)
            {
                case Estacion.Primavera:
                    Console.WriteLine("Marzo, Abril, Mayo");
                    break;
                case Estacion.Verano:
                    Console.WriteLine("Junio, Julio, Agosto");
                    break;
                case Estacion.Otonio:
                    Console.WriteLine("Septiembre, Octubre, Noviembre");
                    break;
                case Estacion.Invierno:
                    Console.WriteLine("Diciembre, Enero, Febrero");
                    break;
                default:
                    Console.WriteLine("Estación Inválida. Por favor, ingresa una estación válida.");
                    break;
            }
        }
    
    }

}

