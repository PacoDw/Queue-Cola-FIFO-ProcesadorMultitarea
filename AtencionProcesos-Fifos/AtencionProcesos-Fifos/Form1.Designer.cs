namespace AtencionProcesos_Fifos
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
            this.bttonComenzar = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.bttonMostrarProcesos = new System.Windows.Forms.Button();
            this.txtCiclosOcio = new System.Windows.Forms.TextBox();
            this.lblCiclosOcio = new System.Windows.Forms.Label();
            this.txtListaProFaltantes = new System.Windows.Forms.TextBox();
            this.lblProcesosFaltantes = new System.Windows.Forms.Label();
            this.txtNumProFaltantes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttonComenzar
            // 
            this.bttonComenzar.AutoSize = true;
            this.bttonComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonComenzar.Location = new System.Drawing.Point(12, 12);
            this.bttonComenzar.Name = "bttonComenzar";
            this.bttonComenzar.Size = new System.Drawing.Size(159, 60);
            this.bttonComenzar.TabIndex = 0;
            this.bttonComenzar.Text = "Comenzar";
            this.bttonComenzar.UseVisualStyleBackColor = true;
            this.bttonComenzar.Click += new System.EventHandler(this.bttonComenzar_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(192, 12);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.ReadOnly = true;
            this.txtReporte.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReporte.Size = new System.Drawing.Size(194, 461);
            this.txtReporte.TabIndex = 0;
            this.txtReporte.TabStop = false;
            // 
            // bttonMostrarProcesos
            // 
            this.bttonMostrarProcesos.AutoSize = true;
            this.bttonMostrarProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonMostrarProcesos.Location = new System.Drawing.Point(12, 87);
            this.bttonMostrarProcesos.Name = "bttonMostrarProcesos";
            this.bttonMostrarProcesos.Size = new System.Drawing.Size(159, 60);
            this.bttonMostrarProcesos.TabIndex = 0;
            this.bttonMostrarProcesos.Text = "Mostrar Procesos";
            this.bttonMostrarProcesos.UseVisualStyleBackColor = true;
            this.bttonMostrarProcesos.Click += new System.EventHandler(this.bttonMostrarProcesos_Click);
            // 
            // txtCiclosOcio
            // 
            this.txtCiclosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiclosOcio.Location = new System.Drawing.Point(12, 175);
            this.txtCiclosOcio.Name = "txtCiclosOcio";
            this.txtCiclosOcio.ReadOnly = true;
            this.txtCiclosOcio.Size = new System.Drawing.Size(159, 22);
            this.txtCiclosOcio.TabIndex = 0;
            this.txtCiclosOcio.TabStop = false;
            // 
            // lblCiclosOcio
            // 
            this.lblCiclosOcio.AutoSize = true;
            this.lblCiclosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclosOcio.Location = new System.Drawing.Point(9, 156);
            this.lblCiclosOcio.Name = "lblCiclosOcio";
            this.lblCiclosOcio.Size = new System.Drawing.Size(107, 16);
            this.lblCiclosOcio.TabIndex = 2;
            this.lblCiclosOcio.Text = "Ciclos de ocio";
            // 
            // txtListaProFaltantes
            // 
            this.txtListaProFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaProFaltantes.Location = new System.Drawing.Point(12, 295);
            this.txtListaProFaltantes.Multiline = true;
            this.txtListaProFaltantes.Name = "txtListaProFaltantes";
            this.txtListaProFaltantes.ReadOnly = true;
            this.txtListaProFaltantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaProFaltantes.Size = new System.Drawing.Size(159, 178);
            this.txtListaProFaltantes.TabIndex = 0;
            this.txtListaProFaltantes.TabStop = false;
            // 
            // lblProcesosFaltantes
            // 
            this.lblProcesosFaltantes.AutoSize = true;
            this.lblProcesosFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcesosFaltantes.Location = new System.Drawing.Point(9, 276);
            this.lblProcesosFaltantes.Name = "lblProcesosFaltantes";
            this.lblProcesosFaltantes.Size = new System.Drawing.Size(137, 16);
            this.lblProcesosFaltantes.TabIndex = 0;
            this.lblProcesosFaltantes.Text = "Procesos faltantes";
            // 
            // txtNumProFaltantes
            // 
            this.txtNumProFaltantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumProFaltantes.Location = new System.Drawing.Point(12, 241);
            this.txtNumProFaltantes.Name = "txtNumProFaltantes";
            this.txtNumProFaltantes.ReadOnly = true;
            this.txtNumProFaltantes.Size = new System.Drawing.Size(159, 22);
            this.txtNumProFaltantes.TabIndex = 0;
            this.txtNumProFaltantes.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de procesos\r\nfaltantes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 485);
            this.Controls.Add(this.lblProcesosFaltantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCiclosOcio);
            this.Controls.Add(this.txtNumProFaltantes);
            this.Controls.Add(this.txtListaProFaltantes);
            this.Controls.Add(this.txtCiclosOcio);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.bttonMostrarProcesos);
            this.Controls.Add(this.bttonComenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttonComenzar;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button bttonMostrarProcesos;
        private System.Windows.Forms.TextBox txtCiclosOcio;
        private System.Windows.Forms.Label lblCiclosOcio;
        private System.Windows.Forms.TextBox txtListaProFaltantes;
        private System.Windows.Forms.Label lblProcesosFaltantes;
        private System.Windows.Forms.TextBox txtNumProFaltantes;
        private System.Windows.Forms.Label label1;
    }
}

