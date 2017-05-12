namespace NavajaSuiza.Aplicación_1_NumerosPrimos
{
    partial class frmNumerosPrimos
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnNumerosPrimos = new System.Windows.Forms.Button();
            this.txtNumeroUsuario = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(199, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Introduce un número entero mayor que 0";
            // 
            // btnNumerosPrimos
            // 
            this.btnNumerosPrimos.Enabled = false;
            this.btnNumerosPrimos.Location = new System.Drawing.Point(15, 118);
            this.btnNumerosPrimos.Name = "btnNumerosPrimos";
            this.btnNumerosPrimos.Size = new System.Drawing.Size(144, 128);
            this.btnNumerosPrimos.TabIndex = 1;
            this.btnNumerosPrimos.Text = "Comprobar si el número es primo";
            this.btnNumerosPrimos.UseVisualStyleBackColor = true;
            this.btnNumerosPrimos.Click += new System.EventHandler(this.btnNumerosPrimos_Click);
            // 
            // txtNumeroUsuario
            // 
            this.txtNumeroUsuario.Location = new System.Drawing.Point(15, 50);
            this.txtNumeroUsuario.MaxLength = 10;
            this.txtNumeroUsuario.Name = "txtNumeroUsuario";
            this.txtNumeroUsuario.Size = new System.Drawing.Size(196, 20);
            this.txtNumeroUsuario.TabIndex = 2;
            this.txtNumeroUsuario.TextChanged += new System.EventHandler(this.txtNumeroUsuario_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(178, 150);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 3;
            // 
            // frmNumerosPrimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 307);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtNumeroUsuario);
            this.Controls.Add(this.btnNumerosPrimos);
            this.Controls.Add(this.lbl1);
            this.Name = "frmNumerosPrimos";
            this.Text = "Aplicacion1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnNumerosPrimos;
        private System.Windows.Forms.TextBox txtNumeroUsuario;
        private System.Windows.Forms.Label lblError;
    }
}