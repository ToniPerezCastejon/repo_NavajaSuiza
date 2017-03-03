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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumeroUsuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 77);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(199, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Introduce un número entero mayor que 0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 128);
            this.button1.TabIndex = 1;
            this.button1.Text = "LLama a la  lógica de la clase Aplicación1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumeroUsuario
            // 
            this.txtNumeroUsuario.Location = new System.Drawing.Point(15, 105);
            this.txtNumeroUsuario.Name = "txtNumeroUsuario";
            this.txtNumeroUsuario.Size = new System.Drawing.Size(196, 20);
            this.txtNumeroUsuario.TabIndex = 2;
            // 
            // frmNumerosPrimos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 307);
            this.Controls.Add(this.txtNumeroUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl1);
            this.Name = "frmNumerosPrimos";
            this.Text = "Aplicacion1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumeroUsuario;
    }
}