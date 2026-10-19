using System;

namespace MesaDePartes
{
    static class Registro
    {
        public static void LlenarArreglos(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("--- Expediente N° " + (i + 1) + " ---");
                Console.WriteLine("Ingrese el código del expediente (Ej: 202601): ");
                codigos[i] = Validacion.LeerEntero();
                Console.WriteLine("Ingrese el nombre del solicitante: ");
                solicitantes[i] = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese el DNI del solicitante (exactamente 8 dígitos): ");
                    dnis[i] = Console.ReadLine();
                    if (dnis[i].Length != 8)
                    {
                        Console.WriteLine("¡ERROR: El DNI debe contener exactamente 8 dígitos!");
                    }
                } while (dnis[i].Length != 8);

                Console.WriteLine("Ingrese el tipo de trámite: ");
                tramites[i] = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public static void EscribirArreglos(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Expediente N° " + (i + 1) + " -> Código: " + codigos[i] +
                                  " | Solicitante: " + solicitantes[i] +
                                  " | DNI: " + dnis[i] +
                                  " | Trámite: " + tramites[i]);
            }
        }
    }
}