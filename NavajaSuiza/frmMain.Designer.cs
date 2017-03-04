namespace NavajaSuiza
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNumerosPrimos = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnJuegoAdivinarNumero = new System.Windows.Forms.Button();
            this.btnValidarFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnNumerosPrimos
            // 
            this.btnNumerosPrimos.Location = new System.Drawing.Point(36, 50);
            this.btnNumerosPrimos.Name = "btnNumerosPrimos";
            this.btnNumerosPrimos.Size = new System.Drawing.Size(122, 69);
            this.btnNumerosPrimos.TabIndex = 1;
            this.btnNumerosPrimos.Text = "Aplicación 1: Números Primos";
            this.btnNumerosPrimos.UseVisualStyleBackColor = true;
            this.btnNumerosPrimos.Click += new System.EventHandler(this.btnNumerosPrimos_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Aplicación 4";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnJuegoAdivinarNumero
            // 
            this.btnJuegoAdivinarNumero.Location = new System.Drawing.Point(36, 283);
            this.btnJuegoAdivinarNumero.Name = "btnJuegoAdivinarNumero";
            this.btnJuegoAdivinarNumero.Size = new System.Drawing.Size(122, 69);
            this.btnJuegoAdivinarNumero.TabIndex = 3;
            this.btnJuegoAdivinarNumero.Text = "Aplicación 3: Adivinar Número";
            this.btnJuegoAdivinarNumero.UseVisualStyleBackColor = true;
            this.btnJuegoAdivinarNumero.Click += new System.EventHandler(this.btnJuegoAdivinarNumero_Click);
            // 
            // btnValidarFecha
            // 
            this.btnValidarFecha.Location = new System.Drawing.Point(495, 50);
            this.btnValidarFecha.Name = "btnValidarFecha";
            this.btnValidarFecha.Size = new System.Drawing.Size(122, 69);
            this.btnValidarFecha.TabIndex = 4;
            this.btnValidarFecha.Text = "Aplicación 2: Validar Fecha";
            this.btnValidarFecha.UseVisualStyleBackColor = true;
            this.btnValidarFecha.Click += new System.EventHandler(this.btnValidarFecha_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 375);
            this.Controls.Add(this.btnValidarFecha);
            this.Controls.Add(this.btnJuegoAdivinarNumero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNumerosPrimos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMain";
            this.Text = "Navaja Suiza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNumerosPrimos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnJuegoAdivinarNumero;
        private System.Windows.Forms.Button btnValidarFecha;
    }
}

