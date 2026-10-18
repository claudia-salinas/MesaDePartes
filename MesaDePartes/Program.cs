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
            LlenarArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- LISTADO GENERAL DE EXPEDIENTES ---");
            EscribirArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- BÚSQUEDA DE UN EXPEDIENTE ---");
            BuscarExpediente(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- INSERTAR UN NUEVO EXPEDIENTE ---");
            n = n + 1;
            Array.Resize(ref codigos, n);
            Array.Resize(ref solicitantes, n);
            Array.Resize(ref dnis, n);
            Array.Resize(ref tramites, n);
            InsertarExpediente(codigos, solicitantes, dnis, tramites, n);
            Console.WriteLine("***********");
            EscribirArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("--- ELIMINAR UN EXPEDIENTE ---");
            EliminarExpediente(codigos, solicitantes, dnis, tramites, n);
            n = n - 1;
            Array.Resize(ref codigos, n);
            Array.Resize(ref solicitantes, n);
            Array.Resize(ref dnis, n);
            Array.Resize(ref tramites, n);

            // Ordenamiento predeterminado automático (sin encabezado en pantalla)
            OrdenarBurbuja(codigos, solicitantes, dnis, tramites, n);
            Console.WriteLine("***********");
            EscribirArreglos(codigos, solicitantes, dnis, tramites, n);

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

        static void LlenarArreglos(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
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

        static void EscribirArreglos(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Expediente N° " + (i + 1) + " -> Código: " + codigos[i] +
                                  " | Solicitante: " + solicitantes[i] +
                                  " | DNI: " + dnis[i] +
                                  " | Trámite: " + tramites[i]);
            }
        }

        static void BuscarExpediente(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
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

        static void InsertarExpediente(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
        {
            Console.WriteLine("Ingrese la posición donde desea insertar: ");
            int posicion = Validacion.LeerEntero();

            posicion = posicion - 1;

            if (posicion < 0 || posicion > n - 1)
            {
                Console.WriteLine("Ingrese una posición correcta");
            }
            else
            {
                // Desplaza los elementos hacia la derecha para abrir espacio
                for (int i = n - 1; i >= posicion + 1; i--)
                {
                    codigos[i] = codigos[i - 1];
                    solicitantes[i] = solicitantes[i - 1];
                    dnis[i] = dnis[i - 1];
                    tramites[i] = tramites[i - 1];
                }

                Console.WriteLine("Ingrese el código del nuevo expediente: ");
                codigos[posicion] = Validacion.LeerEntero();
                Console.WriteLine("Ingrese el nombre del solicitante: ");
                solicitantes[posicion] = Console.ReadLine();

                do
                {
                    Console.WriteLine("Ingrese el DNI del solicitante (exactamente 8 dígitos): ");
                    dnis[posicion] = Console.ReadLine();
                    if (dnis[posicion].Length != 8)
                    {
                        Console.WriteLine("¡ERROR: El DNI debe contener exactamente 8 dígitos!");
                    }
                } while (dnis[posicion].Length != 8);

                Console.WriteLine("Ingrese el tipo de trámite: ");
                tramites[posicion] = Console.ReadLine();
            }
        }

        static void EliminarExpediente(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
        {
            Console.WriteLine("Ingrese la posición a eliminar: ");
            int posicion = Validacion.LeerEntero();

            posicion = posicion - 1;

            if (posicion < 0 || posicion > n - 1)
            {
                Console.WriteLine("Ingrese una posición correcta");
            }
            else
            {
                // Desplaza los elementos hacia la izquierda para tapar el espacio
                if (posicion < n - 1)
                {
                    for (int i = posicion; i <= n - 2; i++)
                    {
                        codigos[i] = codigos[i + 1];
                        solicitantes[i] = solicitantes[i + 1];
                        dnis[i] = dnis[i + 1];
                        tramites[i] = tramites[i + 1];
                    }
                }

                Console.WriteLine("***********");
                EscribirArreglos(codigos, solicitantes, dnis, tramites, n - 1);
            }
        }

        static void OrdenarBurbuja(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
        {
            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = 0; j <= n - 2 - i; j++)
                {
                    if (codigos[j] > codigos[j + 1])
                    {
                        int tmpCodigo = codigos[j + 1];
                        codigos[j + 1] = codigos[j];
                        codigos[j] = tmpCodigo;

                        string tmpSolicitante = solicitantes[j + 1];
                        solicitantes[j + 1] = solicitantes[j];
                        solicitantes[j] = tmpSolicitante;

                        string tmpDni = dnis[j + 1];
                        dnis[j + 1] = dnis[j];
                        dnis[j] = tmpDni;

                        string tmpTramite = tramites[j + 1];
                        tramites[j + 1] = tramites[j];
                        tramites[j] = tmpTramite;
                    }
                }
            }
        }
    }
}