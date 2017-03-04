namespace NavajaSuiza.Aplicación_3_JuegoAdivinarNumero
{
    partial class frmJuegoAdivinarNumero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJuegoAdivinarNumero));
            this.btnJuegoAdivinarNumero = new System.Windows.Forms.Button();
            this.lblTituloJuego = new System.Windows.Forms.Label();
            this.lblInstruccionesJuego = new System.Windows.Forms.Label();
            this.lblNumerosProbados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnJuegoAdivinarNumero
            // 
            this.btnJuegoAdivinarNumero.Location = new System.Drawing.Point(12, 204);
            this.btnJuegoAdivinarNumero.Name = "btnJuegoAdivinarNumero";
            this.btnJuegoAdivinarNumero.Size = new System.Drawing.Size(207, 69);
            this.btnJuegoAdivinarNumero.TabIndex = 0;
            this.btnJuegoAdivinarNumero.Text = "JUGAR";
            this.btnJuegoAdivinarNumero.UseVisualStyleBackColor = true;
            this.btnJuegoAdivinarNumero.Click += new System.EventHandler(this.btnJuegoAdivinarNumero_Click);
            // 
            // lblTituloJuego
            // 
            this.lblTituloJuego.AutoSize = true;
            this.lblTituloJuego.Location = new System.Drawing.Point(12, 9);
            this.lblTituloJuego.Name = "lblTituloJuego";
            this.lblTituloJuego.Size = new System.Drawing.Size(195, 13);
            this.lblTituloJuego.TabIndex = 1;
            this.lblTituloJuego.Text = "¡EL JUEGO DE ADIVINAR NÚMEROS!";
            // 
            // lblInstruccionesJuego
            // 
            this.lblInstruccionesJuego.AutoSize = true;
            this.lblInstruccionesJuego.Location = new System.Drawing.Point(12, 40);
            this.lblInstruccionesJuego.Name = "lblInstruccionesJuego";
            this.lblInstruccionesJuego.Size = new System.Drawing.Size(376, 130);
            this.lblInstruccionesJuego.TabIndex = 2;
            this.lblInstruccionesJuego.Text = resources.GetString("lblInstruccionesJuego.Text");
            // 
            // lblNumerosProbados
            // 
            this.lblNumerosProbados.AutoSize = true;
            this.lblNumerosProbados.Location = new System.Drawing.Point(15, 325);
            this.lblNumerosProbados.Name = "lblNumerosProbados";
            this.lblNumerosProbados.Size = new System.Drawing.Size(105, 13);
            this.lblNumerosProbados.TabIndex = 3;
            this.lblNumerosProbados.Text = "Números probados:  ";
            // 
            // frmJuegoAdivinarNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 350);
            this.Controls.Add(this.lblNumerosProbados);
            this.Controls.Add(this.lblInstruccionesJuego);
            this.Controls.Add(this.lblTituloJuego);
            this.Controls.Add(this.btnJuegoAdivinarNumero);
            this.Name = "frmJuegoAdivinarNumero";
            this.Text = "JuegoAdivinarNumero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJuegoAdivinarNumero;
        private System.Windows.Forms.Label lblTituloJuego;
        private System.Windows.Forms.Label lblInstruccionesJuego;
        private System.Windows.Forms.Label lblNumerosProbados;
    }
}