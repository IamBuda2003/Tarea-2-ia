using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_2_ia
{
    public partial class FRMOchoPuzzle : Form
    {
        private int contador = 0;
        private String pos0;
        private String[,] posiciones;
        private List<CLEstado> Solucion = new List<CLEstado>();
        private List<CLEstado> Original = new List<CLEstado>();
        private CLEstado IniGuardado;
        private bool Regreso = false;
        private int PasoSolucion = 0;
        public FRMOchoPuzzle()
        {
            InitializeComponent();
        }

        private void LBL00_Click(object sender, EventArgs e)
        {
            if (LBL10.Text == "0")
            {
                LBL10.Text = LBL00.Text;
                LBL00.Text = "0";
            }
            else if (LBL01.Text == "0")
            {
                LBL01.Text = LBL00.Text;
                LBL00.Text = "0";
            }
        }

        private void LBL01_Click(object sender, EventArgs e)
        {
            if (LBL00.Text == "0")
            {
                LBL00.Text = LBL01.Text;
                LBL01.Text = "0";
            }
            else if (LBL11.Text == "0")
            {
                LBL11.Text = LBL01.Text;
                LBL01.Text = "0";
            }
            else if (LBL02.Text == "0")
            {
                LBL02.Text = LBL01.Text;
                LBL01.Text = "0";
            }
        }

        private void LBL10_Click(object sender, EventArgs e)
        {
            if (LBL00.Text == "0")
            {
                LBL00.Text = LBL10.Text;
                LBL10.Text = "0";
            }
            else if (LBL11.Text == "0")
            {
                LBL11.Text = LBL10.Text;
                LBL10.Text = "0";
            }
            else if (LBL20.Text == "0")
            {
                LBL20.Text = LBL10.Text;
                LBL10.Text = "0";
            }
        }

        private void LBL20_Click(object sender, EventArgs e)
        {
            if (LBL10.Text == "0")
            {
                LBL10.Text = LBL20.Text;
                LBL20.Text = "0";
            }
            else if (LBL21.Text == "0")
            {
                LBL21.Text = LBL20.Text;
                LBL20.Text = "0";
            }
        }

        private void LBL11_Click(object sender, EventArgs e)
        {
            if (LBL01.Text == "0")
            {
                LBL01.Text = LBL11.Text;
                LBL11.Text = "0";
            }
            else if (LBL10.Text == "0")
            {
                LBL10.Text = LBL11.Text;
                LBL11.Text = "0";
            }
            else if (LBL21.Text == "0")
            {
                LBL21.Text = LBL11.Text;
                LBL11.Text = "0";
            }
            else if (LBL12.Text == "0")
            {
                LBL12.Text = LBL11.Text;
                LBL11.Text = "0";
            }
        }

        private void LBL21_Click(object sender, EventArgs e)
        {
            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL21.Text;
                LBL21.Text = "0";
            }
            else if (LBL20.Text == "0")
            {
                LBL20.Text = LBL21.Text;
                LBL21.Text = "0";
            }
            else if (LBL22.Text == "0")
            {
                LBL22.Text = LBL21.Text;
                LBL21.Text = "0";
            }
        }

        private void LBL02_Click(object sender, EventArgs e)
        {
            if (LBL01.Text == "0")
            {
                LBL01.Text = LBL02.Text;
                LBL02.Text = "0";
            }
            else if (LBL12.Text == "0")
            {
                LBL12.Text = LBL02.Text;
                LBL02.Text = "0";
            }
        }

        private void LBL12_Click(object sender, EventArgs e)
        {
            if (LBL11.Text == "0")
            {
                LBL11.Text = LBL12.Text;
                LBL12.Text = "0";
            }
            else if (LBL22.Text == "0")
            {
                LBL22.Text = LBL12.Text;
                LBL12.Text = "0";
            }
            else if (LBL02.Text == "0")
            {
                LBL02.Text = LBL12.Text;
                LBL12.Text = "0";
            }
        }

        private void LBL22_Click(object sender, EventArgs e)
        {
            if (LBL21.Text == "0")
            {
                LBL21.Text = LBL22.Text;
                LBL22.Text = "0";
            }
            else if (LBL12.Text == "0")
            {
                LBL12.Text = LBL22.Text;
                LBL22.Text = "0";
            }
        }

        private void BTNDesordenar_Click(object sender, EventArgs e)
        {
            TMRReloj.Enabled= true;
        }

        private void TMRReloj_Tick(object sender, EventArgs e)
        {
            posiciones = new string[3, 3];

            posiciones[0, 0] = LBL00.Text;
            posiciones[0, 1] = LBL01.Text;
            posiciones[0, 2] = LBL02.Text;
            posiciones[1, 0] = LBL10.Text;
            posiciones[1, 1] = LBL11.Text;
            posiciones[1, 2] = LBL12.Text;
            posiciones[2, 0] = LBL20.Text;
            posiciones[2, 1] = LBL21.Text;
            posiciones[2, 2] = LBL22.Text;



            if (contador < 50)
            {
                contador++;
                LBLContador.Text = contador.ToString();

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (posiciones[i, j] == "0")
                        {
                            pos0 = i.ToString() + j.ToString();
                        }

                    }
                }

                Random rn = new Random();
                int aleatorio = 0;
                switch (pos0)
                {
                    case "00":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL00.Text = LBL10.Text;
                            LBL10.Text = "0";
                        }
                        else
                        {
                            LBL00.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }

                        break;
                    case "01":

                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL01.Text = LBL00.Text;
                            LBL00.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL01.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL01.Text = LBL02.Text;
                                LBL02.Text = "0";

                            }
                        }

                        break;
                    case "02":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL02.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }
                        else
                        {
                            LBL02.Text = LBL12.Text;
                            LBL12.Text = "0";
                        }

                        break;
                    case "10":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL10.Text = LBL00.Text;
                            LBL00.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL10.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL10.Text = LBL20.Text;
                                LBL20.Text = "0";

                            }
                        }

                        break;
                    case "11":
                        aleatorio = rn.Next(1, 5);
                        if (aleatorio == 1)
                        {
                            LBL11.Text = LBL01.Text;
                            LBL01.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL11.Text = LBL12.Text;
                                LBL12.Text = "0";

                            }
                            else
                            {
                                if (aleatorio == 3)
                                {
                                    LBL11.Text = LBL21.Text;
                                    LBL21.Text = "0";
                                }
                                else
                                {
                                    LBL11.Text = LBL10.Text;
                                    LBL10.Text = "0";

                                }
                            }
                        }

                        break;
                    case "12":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL12.Text = LBL02.Text;
                            LBL02.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL12.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL12.Text = LBL22.Text;
                                LBL22.Text = "0";

                            }
                        }

                        break;
                    case "20":
                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL20.Text = LBL10.Text;
                            LBL10.Text = "0";
                        }
                        else
                        {
                            LBL20.Text = LBL21.Text;
                            LBL21.Text = "0";
                        }

                        break;
                    case "21":
                        aleatorio = rn.Next(1, 4);
                        if (aleatorio == 1)
                        {
                            LBL21.Text = LBL20.Text;
                            LBL20.Text = "0";
                        }
                        else
                        {
                            if (aleatorio == 2)
                            {
                                LBL21.Text = LBL11.Text;
                                LBL11.Text = "0";
                            }
                            else
                            {
                                LBL21.Text = LBL22.Text;
                                LBL22.Text = "0";

                            }
                        }

                        break;
                    case "22":

                        aleatorio = rn.Next(1, 3);
                        if (aleatorio == 1)
                        {
                            LBL22.Text = LBL21.Text;
                            LBL21.Text = "0";
                        }
                        else
                        {
                            LBL22.Text = LBL12.Text;
                            LBL12.Text = "0";
                        }

                        break;
                }

            }
            else
            {
                TMRReloj.Enabled = false;
                MessageBox.Show("Reloj apagado");
                LBLContador.Text = "";
                contador = 0;
            }
        }

        private void BTNGenerarHijos_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL00.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text)
                                            );
            List<CLEstado> Hijos = Inicial.GenerarHijos();
            FRMHijos A = new FRMHijos();
            A.Hijos = Hijos;
            A.ShowDialog();
        }

        private void BTNEsFinal_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL00.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text)
                                            );
            if (Inicial.EsFinal())
            {
                MessageBox.Show("ES el estado FINAL");
            }
            else
            {
                MessageBox.Show("NO ES el estado FINAL");
            }
        }

        private void BTNAnchuraPrioritaria_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(Convert.ToInt32(LBL00.Text),
                                            Convert.ToInt32(LBL01.Text),
                                            Convert.ToInt32(LBL02.Text),
                                            Convert.ToInt32(LBL10.Text),
                                            Convert.ToInt32(LBL11.Text),
                                            Convert.ToInt32(LBL12.Text),
                                            Convert.ToInt32(LBL20.Text),
                                            Convert.ToInt32(LBL21.Text),
                                            Convert.ToInt32(LBL22.Text)
                                            );
            Solucion = CLAlgoritmosDeBusqueda.AnchuraPrioritaria(Inicial);
            Original = CLAlgoritmosDeBusqueda.AnchuraPrioritaria(Inicial);
            if (Solucion.Count > 0)
            {

                Solucion.Reverse();
                MessageBox.Show("Solución Encontrada: " + (Solucion.Count - 1) + " pasos");
                PasoSolucion = 0;
                TMRSolucion.Enabled = true;
            }
            else
            { MessageBox.Show("Solucion No Encontrada"); }
        }

        private void TMRSolucion_Tick(object sender, EventArgs e)
        {

            if (PasoSolucion < Solucion.Count)
            {
                CLEstado A = Solucion[PasoSolucion];

                LBL00.Text = A.tablero[0, 0].ToString();
                LBL01.Text = A.tablero[0, 1].ToString();
                LBL02.Text = A.tablero[0, 2].ToString();
                LBL10.Text = A.tablero[1, 0].ToString();
                LBL11.Text = A.tablero[1, 1].ToString();
                LBL12.Text = A.tablero[1, 2].ToString();
                LBL20.Text = A.tablero[2, 0].ToString();
                LBL21.Text = A.tablero[2, 1].ToString();
                LBL22.Text = A.tablero[2, 2].ToString();

                LBLContador.Text = "Paso " + PasoSolucion;

                PasoSolucion++;
            }
            else
            {
                TMRSolucion.Enabled = false;
                LBLContador.Text = "Resuelto";
                MessageBox.Show("Resuelto en " + (Solucion.Count - 1));
                PasoSolucion = 0;
                TMROriginal.Enabled = true;
            }
        }

        private void TMROriginal_Tick(object sender, EventArgs e)
        {
            if (PasoSolucion < Original.Count)
            {
                CLEstado A = Original[PasoSolucion];

                LBL00.Text = A.tablero[0, 0].ToString();
                LBL01.Text = A.tablero[0, 1].ToString();
                LBL02.Text = A.tablero[0, 2].ToString();
                LBL10.Text = A.tablero[1, 0].ToString();
                LBL11.Text = A.tablero[1, 1].ToString();
                LBL12.Text = A.tablero[1, 2].ToString();
                LBL20.Text = A.tablero[2, 0].ToString();
                LBL21.Text = A.tablero[2, 1].ToString();
                LBL22.Text = A.tablero[2, 2].ToString();

                LBLContador.Text = "Paso " + PasoSolucion;

                PasoSolucion++;
            }
            else
            {
                TMROriginal.Enabled = false;
                LBLContador.Text = "Original";
                MessageBox.Show("Estado Original");
            }
        }

        private void BTNProfundidadLimitada_Click(object sender, EventArgs e)
        {
            CLEstado Inicial = new CLEstado(
                   Convert.ToInt32(LBL00.Text),
                   Convert.ToInt32(LBL01.Text),
                   Convert.ToInt32(LBL02.Text),
                   Convert.ToInt32(LBL10.Text),
                   Convert.ToInt32(LBL11.Text),
                   Convert.ToInt32(LBL12.Text),
                   Convert.ToInt32(LBL20.Text),
                   Convert.ToInt32(LBL21.Text),
                   Convert.ToInt32(LBL22.Text)
                   );

            int Limite = Convert.ToInt32(NUDLimitada.Value);
            Solucion = CLAlgoritmosDeBusqueda.ProfundidadLimitada(Inicial, Limite);

            if (Solucion.Count > 0)
            {
                MessageBox.Show("Solución Encontrada: " + (Solucion.Count - 1) + " pasos");
                PasoSolucion = 0;
                TMRProLim.Enabled = true;
            }
            else
            {
                MessageBox.Show("Solución No Encontrada dentro del límite");
            }
        }    
        

        private void TMRProLim_Tick(object sender, EventArgs e)
        {
            if (PasoSolucion < Solucion.Count)
            {
                CLEstado A = Solucion[PasoSolucion];

                LBL00.Text = A.tablero[0, 0].ToString();
                LBL01.Text = A.tablero[0, 1].ToString();
                LBL02.Text = A.tablero[0, 2].ToString();
                LBL10.Text = A.tablero[1, 0].ToString();
                LBL11.Text = A.tablero[1, 1].ToString();
                LBL12.Text = A.tablero[1, 2].ToString();
                LBL20.Text = A.tablero[2, 0].ToString();
                LBL21.Text = A.tablero[2, 1].ToString();
                LBL22.Text = A.tablero[2, 2].ToString();

                LBLContador.Text = "Paso " + PasoSolucion;
                PasoSolucion++;
            }
            else
            {
                TMRProLim.Enabled = false;
                LBLContador.Text = "Resuelto";
                MessageBox.Show("Resuelto en " + (Solucion.Count - 1) + " pasos");
                PasoSolucion = 0;
            }
        }

        
    }
}
