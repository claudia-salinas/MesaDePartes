using System;

namespace MesaDePartes
{
    static class Ordenamiento
    {
        public static void OrdenarBurbuja(int[] codigos, string[] solicitantes, string[] dnis, string[] tramites, int n)
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