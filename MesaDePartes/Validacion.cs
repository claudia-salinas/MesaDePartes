using System;

namespace MesaDePartes
{
    static class Validacion
    {
        // Lee un entero desde consola; repite hasta que el valor sea válido
        public static int LeerEntero()
        {
            int valor;
            while (!int.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("Ingrese un número entero válido: ");
            }
            return valor;
        }
    }
} 