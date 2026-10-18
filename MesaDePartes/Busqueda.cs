using System;

namespace MesaDePartes
{
    static class Busqueda
    {
        public static void BuscarExpediente(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
        {
            bool encontrado = false;

            Console.WriteLine("Ingrese el código exacto que desea buscar: ");
            int codigoBuscado = Validacion.LeerEntero();

            for (int i = 0; i < n; i++)
            {
                if (codigos[i] == codigoBuscado)
                {
                    Console.WriteLine("¡EXPEDIENTE ENCONTRADO!");
                    Console.WriteLine("-> Se encuentra registrado en el orden N°: " + (i + 1));
                    Console.WriteLine("-> Solicitante: " + solicitantes[i] + " (DNI: " + dnis[i] + ")");
                    Console.WriteLine("-> Trámite: " + tramites[i]);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El código ingresado no se encuentra registrado.");
            }
        }
    }
} 