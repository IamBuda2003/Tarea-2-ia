using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2_ia
{
    public class CLEstado
    {

        #region Campos
        private int[,] _tablero;
        private int _nivel;
        private CLEstado _padre;
        #endregion

        #region Propiedades
        public int[,] tablero
        {
            get => _tablero;
            set => _tablero = value;
        }
        public int nivel
        {
            get => _nivel;
            set => _nivel = value;
        }
        public CLEstado padre
        {
            get => _padre;
            set => _padre = value;
        }
        #endregion

        #region Constructor
        public CLEstado()
        {
            this._tablero = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    this._tablero[i, j] = 0;
            this._nivel = 0;
            this._padre = null;
        }
        public CLEstado(int p00, int p01, int p02,
                        int p10, int p11, int p12,
                        int p20, int p21, int p22
                        )
        {
            this._tablero = new int[3, 3];
            this._tablero[0, 0] = p00;
            this._tablero[1, 0] = p10;
            this._tablero[2, 0] = p20;
            this._tablero[0, 1] = p01;
            this._tablero[1, 1] = p11;
            this._tablero[2, 1] = p21;
            this._tablero[0, 2] = p02;
            this._tablero[1, 2] = p12;
            this._tablero[2, 2] = p22;
            this._nivel = 0;
            this._padre = null;
        }


        #endregion

        #region Métodos
        public List<CLEstado> GenerarHijos()
        {
            List<CLEstado> Respuesta = new List<CLEstado>();
            String pos0 = "";
            int[,] aux = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (this._tablero[i, j] == 0)
                    {
                        pos0 = i.ToString() + j.ToString();
                    }
            CLEstado A = new CLEstado();
            switch (pos0)
            {
                case "00":
                    A = new CLEstado(this._tablero[0, 1],
                                             this._tablero[0, 0],
                                             this._tablero[0, 2],
                                             this._tablero[1, 0],
                                             this._tablero[1, 1],
                                             this._tablero[1, 2],
                                             this._tablero[2, 0],
                                             this._tablero[2, 1],
                                             this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[1, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[0, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "01":
                    A = new CLEstado(this._tablero[0, 1],
                                         this._tablero[0, 0],
                                         this._tablero[0, 2],
                                         this._tablero[1, 0],
                                         this._tablero[1, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                         this._tablero[1, 1],
                                         this._tablero[0, 2],
                                         this._tablero[1, 0],
                                         this._tablero[0, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                         this._tablero[0, 2],
                                         this._tablero[0, 1],
                                         this._tablero[1, 0],
                                         this._tablero[1, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "02":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 2],
                                     this._tablero[0, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "10":
                    A = new CLEstado(this._tablero[0, 1],
                                     this._tablero[0, 0],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "11":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[1, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[0, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[1, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2]);

                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "12":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[1, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "20":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "21":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2],
                                     this._tablero[2, 1]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "22":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2],
                                     this._tablero[2, 1]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
            }
            return Respuesta;
        }

        public bool EsFinal()
        {
            bool res = false;
            if (_tablero[0, 0] == 1 &&
                _tablero[0, 1] == 2 &&
                _tablero[0, 2] == 3 &&
                _tablero[1, 0] == 4 &&
                _tablero[1, 1] == 5 &&
                _tablero[1, 2] == 6 &&
                _tablero[2, 0] == 7 &&
                _tablero[2, 1] == 8 &&
                _tablero[2, 2] == 0)
            {
                res = true;
            }
            return res;
        }

        public bool EsIgual(CLEstado a)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a.tablero[i, j] != this.tablero[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        #endregion
    }
}
