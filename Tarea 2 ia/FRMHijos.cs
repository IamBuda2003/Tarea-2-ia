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
    public partial class FRMHijos : Form
    {
        #region Variables

        public List<CLEstado> Hijos = new List<CLEstado>();
        private int apuntador = 0;

        #endregion
        public FRMHijos()
        {
            InitializeComponent();
        }

        private void FRMHijos_Load(object sender, EventArgs e)
        {
            if (Hijos.Count > 0)
            {
                apuntador = 0;
                TrasladarEstadoATablero(apuntador);
            }
            else
            {
                MessageBox.Show("Sin hijos");
            }
        }
        #region Métodos
        private void TrasladarEstadoATablero(int apuntador)
        {
            LBL00.Text = Hijos[apuntador].tablero[0, 0].ToString();
            LBL01.Text = Hijos[apuntador].tablero[0, 1].ToString();
            LBL02.Text = Hijos[apuntador].tablero[0, 2].ToString();
            LBL10.Text = Hijos[apuntador].tablero[1, 0].ToString();
            LBL11.Text = Hijos[apuntador].tablero[1, 1].ToString();
            LBL12.Text = Hijos[apuntador].tablero[1, 2].ToString();
            LBL20.Text = Hijos[apuntador].tablero[2, 0].ToString();
            LBL21.Text = Hijos[apuntador].tablero[2, 1].ToString();
            LBL22.Text = Hijos[apuntador].tablero[2, 2].ToString();
            LBLHijo.Text = "Hijo " + (apuntador + 1).ToString();
        }
        #endregion

        private void BTNIzquierda_Click(object sender, EventArgs e)
        {
            if (apuntador > 0)
            {
                apuntador--;
                TrasladarEstadoATablero(apuntador);
            }
        }

        private void BTNDerecha_Click(object sender, EventArgs e)
        {
            if ((Hijos.Count - 1) > apuntador)
            {
                apuntador++;
                TrasladarEstadoATablero(apuntador);
            }
        }
    }
}
