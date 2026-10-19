using System;

namespace MesaDePartes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;

            int[] codigos = new int[n];
            string[] solicitantes = new string[n];
            string[] dnis = new string[n];
            string[] tramites = new string[n];

            Console.WriteLine("=== MUNICIPALIDAD DISTRITAL DE VÍCTOR LARCO HERRERA ===");
            Console.WriteLine("--- REGISTRO INICIAL DE EXPEDIENTES ---");
            Registro.LlenarArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- LISTADO GENERAL DE EXPEDIENTES ---");
            Registro.EscribirArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- BÚSQUEDA DE UN EXPEDIENTE ---");
            Busqueda.BuscarExpediente(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- INSERTAR UN NUEVO EXPEDIENTE ---");
            n = n + 1;
            Array.Resize(ref codigos, n);
            Array.Resize(ref solicitantes, n);
            Array.Resize(ref dnis, n);
            Array.Resize(ref tramites, n);
            Registro.InsertarExpediente(codigos, solicitantes, dnis, tramites, n);
            Console.WriteLine("***********");
            Registro.EscribirArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- ELIMINAR UN EXPEDIENTE ---");
            Registro.EliminarExpediente(codigos, solicitantes, dnis, tramites, n);
            n = n - 1;
            Array.Resize(ref codigos, n);
            Array.Resize(ref solicitantes, n);
            Array.Resize(ref dnis, n);
            Array.Resize(ref tramites, n);

            // Ordenamiento predeterminado automático (sin encabezado en pantalla)
            Ordenamiento.OrdenarBurbuja(codigos, solicitantes, dnis, tramites, n);
            Console.WriteLine("***********");
            Registro.EscribirArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        } 
    }
}