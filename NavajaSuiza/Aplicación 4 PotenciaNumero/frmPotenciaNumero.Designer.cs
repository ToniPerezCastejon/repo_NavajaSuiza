namespace NavajaSuiza.Aplicación_4_PotenciaNumero
{
    partial class frmPotenciaNumero
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
            this.btnPotenciaNumero = new System.Windows.Forms.Button();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtExponente = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblExponente = new System.Windows.Forms.Label();
            this.lblInstruccionesPotencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPotenciaNumero
            // 
            this.btnPotenciaNumero.Location = new System.Drawing.Point(16, 162);
            this.btnPotenciaNumero.Name = "btnPotenciaNumero";
            this.btnPotenciaNumero.Size = new System.Drawing.Size(145, 98);
            this.btnPotenciaNumero.TabIndex = 0;
            this.btnPotenciaNumero.Text = "Calcular Potencia";
            this.btnPotenciaNumero.UseVisualStyleBackColor = true;
            this.btnPotenciaNumero.Click += new System.EventHandler(this.btnPotenciaNumero_Click);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(80, 67);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;
            // 
            // txtExponente
            // 
            this.txtExponente.Location = new System.Drawing.Point(80, 109);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(100, 20);
            this.txtExponente.TabIndex = 2;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(13, 74);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 3;
            this.lblBase.Text = "Base:";
            // 
            // lblExponente
            // 
            this.lblExponente.AutoSize = true;
            this.lblExponente.Location = new System.Drawing.Point(13, 116);
            this.lblExponente.Name = "lblExponente";
            this.lblExponente.Size = new System.Drawing.Size(61, 13);
            this.lblExponente.TabIndex = 4;
            this.lblExponente.Text = "Exponente:";
            // 
            // lblInstruccionesPotencia
            // 
            this.lblInstruccionesPotencia.AutoSize = true;
            this.lblInstruccionesPotencia.Location = new System.Drawing.Point(13, 13);
            this.lblInstruccionesPotencia.Name = "lblInstruccionesPotencia";
            this.lblInstruccionesPotencia.Size = new System.Drawing.Size(294, 13);
            this.lblInstruccionesPotencia.TabIndex = 5;
            this.lblInstruccionesPotencia.Text = "Introduce una base y un exponente para calcular la potencia";
            // 
            // frmPotenciaNumero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 272);
            this.Controls.Add(this.lblInstruccionesPotencia);
            this.Controls.Add(this.lblExponente);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtExponente);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.btnPotenciaNumero);
            this.Name = "frmPotenciaNumero";
            this.Text = "frmFibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPotenciaNumero;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtExponente;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblExponente;
        private System.Windows.Forms.Label lblInstruccionesPotencia;
    }
}