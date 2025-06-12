namespace Ejercicio1
{
    partial class Form1
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
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbMostrarValor = new System.Windows.Forms.Label();
            this.btnSolicitarValor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(93, 128);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(55, 13);
            this.lbResultado.TabIndex = 0;
            this.lbResultado.Text = "Resultado";
            // 
            // lbMostrarValor
            // 
            this.lbMostrarValor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbMostrarValor.Location = new System.Drawing.Point(213, 128);
            this.lbMostrarValor.Name = "lbMostrarValor";
            this.lbMostrarValor.Size = new System.Drawing.Size(78, 22);
            this.lbMostrarValor.TabIndex = 1;
            // 
            // btnSolicitarValor
            // 
            this.btnSolicitarValor.Location = new System.Drawing.Point(127, 39);
            this.btnSolicitarValor.Name = "btnSolicitarValor";
            this.btnSolicitarValor.Size = new System.Drawing.Size(138, 23);
            this.btnSolicitarValor.TabIndex = 2;
            this.btnSolicitarValor.Text = "Solicitar Valor";
            this.btnSolicitarValor.UseVisualStyleBackColor = true;
            this.btnSolicitarValor.Click += new System.EventHandler(this.btnSolicitarValor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 197);
            this.Controls.Add(this.btnSolicitarValor);
            this.Controls.Add(this.lbMostrarValor);
            this.Controls.Add(this.lbResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo Modal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbMostrarValor;
        private System.Windows.Forms.Button btnSolicitarValor;
    }
}

