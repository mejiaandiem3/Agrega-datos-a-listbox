namespace listboxsabdo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtdato = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnrecorrer = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lstlista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(99, 40);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(100, 20);
            this.txtdato.TabIndex = 0;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(337, 37);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 45);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar a ListBox";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnrecorrer
            // 
            this.btnrecorrer.Location = new System.Drawing.Point(337, 98);
            this.btnrecorrer.Name = "btnrecorrer";
            this.btnrecorrer.Size = new System.Drawing.Size(75, 38);
            this.btnrecorrer.TabIndex = 2;
            this.btnrecorrer.Text = "Recorer el ListBox";
            this.btnrecorrer.UseVisualStyleBackColor = true;
            this.btnrecorrer.Click += new System.EventHandler(this.btnrecorrer_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(337, 164);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // lstlista
            // 
            this.lstlista.FormattingEnabled = true;
            this.lstlista.Location = new System.Drawing.Point(48, 116);
            this.lstlista.Name = "lstlista";
            this.lstlista.Size = new System.Drawing.Size(120, 95);
            this.lstlista.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Datos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstlista);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnrecorrer);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtdato);
            this.Name = "Form1";
            this.Text = "Ejemplo de ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnrecorrer;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ListBox lstlista;
        private System.Windows.Forms.Label label1;
    }
}

