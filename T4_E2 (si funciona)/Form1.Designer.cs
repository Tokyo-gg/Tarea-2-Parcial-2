namespace T4_E2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxMarcas = new System.Windows.Forms.ListBox();
            this.listBoxModelos = new System.Windows.Forms.ListBox();
            this.listBoxAños = new System.Windows.Forms.ListBox();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año";
            // 
            // listBoxMarcas
            // 
            this.listBoxMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMarcas.FormattingEnabled = true;
            this.listBoxMarcas.ItemHeight = 25;
            this.listBoxMarcas.Location = new System.Drawing.Point(62, 44);
            this.listBoxMarcas.Name = "listBoxMarcas";
            this.listBoxMarcas.Size = new System.Drawing.Size(204, 204);
            this.listBoxMarcas.TabIndex = 3;
            this.listBoxMarcas.SelectedIndexChanged += new System.EventHandler(this.listBoxMarcas_SelectedIndexChanged);
            // 
            // listBoxModelos
            // 
            this.listBoxModelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxModelos.FormattingEnabled = true;
            this.listBoxModelos.ItemHeight = 25;
            this.listBoxModelos.Location = new System.Drawing.Point(321, 44);
            this.listBoxModelos.Name = "listBoxModelos";
            this.listBoxModelos.Size = new System.Drawing.Size(204, 204);
            this.listBoxModelos.TabIndex = 4;
            this.listBoxModelos.SelectedIndexChanged += new System.EventHandler(this.listBoxModelo_SelectedIndexChanged);
            // 
            // listBoxAños
            // 
            this.listBoxAños.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAños.FormattingEnabled = true;
            this.listBoxAños.ItemHeight = 25;
            this.listBoxAños.Location = new System.Drawing.Point(586, 44);
            this.listBoxAños.Name = "listBoxAños";
            this.listBoxAños.Size = new System.Drawing.Size(204, 204);
            this.listBoxAños.TabIndex = 5;
            this.listBoxAños.SelectedIndexChanged += new System.EventHandler(this.listBoxAños_SelectedIndexChanged);
            // 
            // pbxFoto
            // 
            this.pbxFoto.Location = new System.Drawing.Point(62, 299);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(482, 338);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFoto.TabIndex = 6;
            this.pbxFoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(659, 413);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(67, 25);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 737);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxFoto);
            this.Controls.Add(this.listBoxAños);
            this.Controls.Add(this.listBoxModelos);
            this.Controls.Add(this.listBoxMarcas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoLote \"Casi Nuevo\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxMarcas;
        private System.Windows.Forms.ListBox listBoxModelos;
        private System.Windows.Forms.ListBox listBoxAños;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecio;
    }
}

