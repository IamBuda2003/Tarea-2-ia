namespace Tarea_2_ia
{
    partial class FRMOchoPuzzle
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LBL00 = new System.Windows.Forms.Label();
            this.LBL01 = new System.Windows.Forms.Label();
            this.LBL02 = new System.Windows.Forms.Label();
            this.LBL12 = new System.Windows.Forms.Label();
            this.LBL11 = new System.Windows.Forms.Label();
            this.LBL10 = new System.Windows.Forms.Label();
            this.LBL22 = new System.Windows.Forms.Label();
            this.LBL21 = new System.Windows.Forms.Label();
            this.LBL20 = new System.Windows.Forms.Label();
            this.BTNDesordenar = new System.Windows.Forms.Button();
            this.TMRRelog = new System.Windows.Forms.Timer(this.components);
            this.LBLContador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL00
            // 
            this.LBL00.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL00.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL00.Location = new System.Drawing.Point(12, 9);
            this.LBL00.Name = "LBL00";
            this.LBL00.Size = new System.Drawing.Size(130, 130);
            this.LBL00.TabIndex = 0;
            this.LBL00.Text = "1";
            this.LBL00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL00.Click += new System.EventHandler(this.LBL00_Click);
            // 
            // LBL01
            // 
            this.LBL01.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL01.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL01.Location = new System.Drawing.Point(148, 9);
            this.LBL01.Name = "LBL01";
            this.LBL01.Size = new System.Drawing.Size(130, 130);
            this.LBL01.TabIndex = 1;
            this.LBL01.Text = "2";
            this.LBL01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL01.Click += new System.EventHandler(this.LBL01_Click);
            // 
            // LBL02
            // 
            this.LBL02.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL02.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL02.Location = new System.Drawing.Point(284, 9);
            this.LBL02.Name = "LBL02";
            this.LBL02.Size = new System.Drawing.Size(130, 130);
            this.LBL02.TabIndex = 2;
            this.LBL02.Text = "3";
            this.LBL02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL02.Click += new System.EventHandler(this.LBL02_Click);
            // 
            // LBL12
            // 
            this.LBL12.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL12.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL12.Location = new System.Drawing.Point(284, 148);
            this.LBL12.Name = "LBL12";
            this.LBL12.Size = new System.Drawing.Size(130, 130);
            this.LBL12.TabIndex = 5;
            this.LBL12.Text = "6";
            this.LBL12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL12.Click += new System.EventHandler(this.LBL12_Click);
            // 
            // LBL11
            // 
            this.LBL11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL11.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL11.Location = new System.Drawing.Point(148, 148);
            this.LBL11.Name = "LBL11";
            this.LBL11.Size = new System.Drawing.Size(130, 130);
            this.LBL11.TabIndex = 4;
            this.LBL11.Text = "5";
            this.LBL11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL11.Click += new System.EventHandler(this.LBL11_Click);
            // 
            // LBL10
            // 
            this.LBL10.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL10.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL10.Location = new System.Drawing.Point(12, 148);
            this.LBL10.Name = "LBL10";
            this.LBL10.Size = new System.Drawing.Size(130, 130);
            this.LBL10.TabIndex = 3;
            this.LBL10.Text = "4";
            this.LBL10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL10.Click += new System.EventHandler(this.LBL10_Click);
            // 
            // LBL22
            // 
            this.LBL22.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL22.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL22.Location = new System.Drawing.Point(284, 288);
            this.LBL22.Name = "LBL22";
            this.LBL22.Size = new System.Drawing.Size(130, 130);
            this.LBL22.TabIndex = 8;
            this.LBL22.Text = "0";
            this.LBL22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL22.Click += new System.EventHandler(this.LBL22_Click);
            // 
            // LBL21
            // 
            this.LBL21.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL21.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL21.Location = new System.Drawing.Point(148, 288);
            this.LBL21.Name = "LBL21";
            this.LBL21.Size = new System.Drawing.Size(130, 130);
            this.LBL21.TabIndex = 7;
            this.LBL21.Text = "8";
            this.LBL21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL21.Click += new System.EventHandler(this.LBL21_Click);
            // 
            // LBL20
            // 
            this.LBL20.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBL20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL20.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL20.Location = new System.Drawing.Point(12, 288);
            this.LBL20.Name = "LBL20";
            this.LBL20.Size = new System.Drawing.Size(130, 130);
            this.LBL20.TabIndex = 6;
            this.LBL20.Text = "7";
            this.LBL20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL20.Click += new System.EventHandler(this.LBL20_Click);
            // 
            // BTNDesordenar
            // 
            this.BTNDesordenar.Location = new System.Drawing.Point(420, 9);
            this.BTNDesordenar.Name = "BTNDesordenar";
            this.BTNDesordenar.Size = new System.Drawing.Size(172, 52);
            this.BTNDesordenar.TabIndex = 9;
            this.BTNDesordenar.Text = "Desordenar";
            this.BTNDesordenar.UseVisualStyleBackColor = true;
            this.BTNDesordenar.Click += new System.EventHandler(this.BTNDesordenar_Click);
            // 
            // TMRRelog
            // 
            this.TMRRelog.Interval = 1000;
            this.TMRRelog.Tick += new System.EventHandler(this.TMRRelog_Tick);
            // 
            // LBLContador
            // 
            this.LBLContador.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LBLContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBLContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLContador.Location = new System.Drawing.Point(440, 76);
            this.LBLContador.Name = "LBLContador";
            this.LBLContador.Size = new System.Drawing.Size(130, 130);
            this.LBLContador.TabIndex = 10;
            this.LBLContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FRMOchoPuzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 428);
            this.Controls.Add(this.LBLContador);
            this.Controls.Add(this.BTNDesordenar);
            this.Controls.Add(this.LBL22);
            this.Controls.Add(this.LBL21);
            this.Controls.Add(this.LBL20);
            this.Controls.Add(this.LBL12);
            this.Controls.Add(this.LBL11);
            this.Controls.Add(this.LBL10);
            this.Controls.Add(this.LBL02);
            this.Controls.Add(this.LBL01);
            this.Controls.Add(this.LBL00);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FRMOchoPuzzle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8 Puzzle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL00;
        private System.Windows.Forms.Label LBL01;
        private System.Windows.Forms.Label LBL02;
        private System.Windows.Forms.Label LBL12;
        private System.Windows.Forms.Label LBL11;
        private System.Windows.Forms.Label LBL10;
        private System.Windows.Forms.Label LBL22;
        private System.Windows.Forms.Label LBL21;
        private System.Windows.Forms.Label LBL20;
        private System.Windows.Forms.Button BTNDesordenar;
        private System.Windows.Forms.Timer TMRRelog;
        private System.Windows.Forms.Label LBLContador;
    }
}

