using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_ia
{
    public static class CLAlgoritmosDeBusqueda
    {
        public static List<CLEstado> AnchuraPrioritaria(CLEstado Inicial)
        {
            //Definición de variables
            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos = new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            List<CLEstado> Hijos = new List<CLEstado>();
            CLEstado Actual = new CLEstado();
            //Algoritmo
            Abiertos.Add(Inicial);
            Actual = Abiertos[0];
            while (!Actual.EsFinal() && Abiertos.Count > 0)
            {
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(0);
                Hijos = Actual.GenerarHijos();
                Hijos = TratarRepetidos(Hijos, Abiertos, Cerrados);
                foreach (CLEstado a in Hijos)
                    Abiertos.Add(a);
                Actual = Abiertos[0];
            }
            if (Actual.EsFinal())
            {
                Solucion.Add(Actual);
                while (Actual.padre != null)
                {
                    Solucion.Add(Actual.padre);
                    Actual = Actual.padre;
                }
            }
            return Solucion;
        }

        private static List<CLEstado> TratarRepetidos(List<CLEstado> hijos, List<CLEstado> abiertos, List<CLEstado> cerrados)
        {
            List<CLEstado> HijosDepurado = new List<CLEstado>();
            bool encontrado = false;
            foreach (CLEstado hijo in hijos)
            {
                encontrado = false;
                // comparar con abiertos
                foreach (var a in abiertos)
                {
                    if (hijo.EsIgual(a))
                    {
                        encontrado = true; break;
                    }
                }

                if (encontrado) continue;

                // comparar con cerrados
                foreach (var c in cerrados)
                {
                    if (hijo.EsIgual(c))
                    {
                        encontrado = true; break;
                    }
                }

                if (!encontrado)
                {
                    HijosDepurado.Add(hijo);
                }
            }

            return HijosDepurado;
        }
        public static List<CLEstado> ProfundidadLimitada(CLEstado Inicial, int Limite)
        {
            // Definición de Variables

            List<CLEstado> Solucion = new List<CLEstado>();
            List<CLEstado> Abiertos = new List<CLEstado>();
            List<CLEstado> Cerrados = new List<CLEstado>();
            List<CLEstado> Hijos = new List<CLEstado>();
            CLEstado Actual = new CLEstado();
            // Algoritmo

            Abiertos.Add(Inicial);
            Actual = Abiertos[Abiertos.Count - 1];

            while (!Actual.EsFinal() && Abiertos.Count > 0)
            {
                Cerrados.Add(Actual);
                Abiertos.RemoveAt(Abiertos.Count - 1);
                if (Actual.nivel <= Limite)
                {
                    Hijos = Actual.GenerarHijos();
                    Hijos = TratarRepetidosProfundidad(Hijos, Abiertos, Cerrados);
                    foreach (CLEstado a in Hijos)
                        Abiertos.Add(a);
                }
                if (Abiertos.Count == 0) break;
                Actual = Abiertos[Abiertos.Count - 1];
            }

            if (Actual.EsFinal())
            {
                while (Actual != null)
                {
                    Solucion.Insert(0, Actual);
                    Actual = Actual.padre;
                }
            }
            return Solucion;
        }

        private static List<CLEstado> TratarRepetidosProfundidad(List<CLEstado> hijos, List<CLEstado> abiertos, List<CLEstado> cerrados)
        {
            List<CLEstado> HijosDepurados = new List<CLEstado>();
            bool Encontrado = false;

            foreach (CLEstado hijo in hijos)
            {
                Encontrado = false;

                //Comparar con abiertos
                foreach (var a in abiertos)
                {
                    if (hijo.EsIgual(a))
                    {
                        Encontrado = true; break;
                    }
                }

                if (Encontrado) continue;

                // comparar con cerrados
                foreach (var c in cerrados)
                {
                    if (hijo.EsIgual(c))
                    {
                        if (hijo.nivel >= c.nivel)
                            Encontrado = true; break;
                    }
                }

                if (!Encontrado)
                {
                    HijosDepurados.Add(hijo);
                }
            }
            return HijosDepurados;
        }
    }

}
