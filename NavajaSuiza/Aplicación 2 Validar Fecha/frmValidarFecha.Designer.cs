﻿namespace NavajaSuiza.Aplicación_2_ValidarFecha
{
    partial class frmValidarFecha
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
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnyo = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAnyo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(139, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Introduce la fecha a validar:";
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.Location = new System.Drawing.Point(252, 95);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(100, 75);
            this.btnInstrucciones.TabIndex = 2;
            this.btnInstrucciones.Text = "Validar fecha";
            this.btnInstrucciones.UseVisualStyleBackColor = true;
            this.btnInstrucciones.Click += new System.EventHandler(this.btnValidarFecha_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(12, 71);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(28, 13);
            this.lblDia.TabIndex = 3;
            this.lblDia.Text = "Día:";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(13, 130);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 4;
            this.lblMes.Text = "Mes:";
            // 
            // lblAnyo
            // 
            this.lblAnyo.AutoSize = true;
            this.lblAnyo.Location = new System.Drawing.Point(11, 185);
            this.lblAnyo.Name = "lblAnyo";
            this.lblAnyo.Size = new System.Drawing.Size(29, 13);
            this.lblAnyo.TabIndex = 5;
            this.lblAnyo.Text = "Año:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(52, 68);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 20);
            this.txtDia.TabIndex = 6;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(52, 123);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 7;
            // 
            // txtAnyo
            // 
            this.txtAnyo.Location = new System.Drawing.Point(52, 178);
            this.txtAnyo.Name = "txtAnyo";
            this.txtAnyo.Size = new System.Drawing.Size(100, 20);
            this.txtAnyo.TabIndex = 8;
            // 
            // frmValidarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 280);
            this.Controls.Add(this.txtAnyo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.lblAnyo);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Controls.Add(this.btnInstrucciones);
            this.Controls.Add(this.lbl1);
            this.Name = "frmValidarFecha";
            this.Text = "frmValidarFecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnyo;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAnyo;
    }
}