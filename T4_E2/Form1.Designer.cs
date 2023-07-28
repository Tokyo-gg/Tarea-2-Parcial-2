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
            this.components = new System.ComponentModel.Container();
            this.listBoxMarcas = new System.Windows.Forms.ListBox();
            this.listBoxModelos = new System.Windows.Forms.ListBox();
            this.listBoxAños = new System.Windows.Forms.ListBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.autoLoteDataSet = new T4_E2.AutoLoteDataSet();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaTableAdapter = new T4_E2.AutoLoteDataSetTableAdapters.MarcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLoteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMarcas
            // 
            this.listBoxMarcas.DataSource = this.marcaBindingSource;
            this.listBoxMarcas.DisplayMember = "Marca";
            this.listBoxMarcas.FormattingEnabled = true;
            this.listBoxMarcas.ItemHeight = 20;
            this.listBoxMarcas.Location = new System.Drawing.Point(50, 73);
            this.listBoxMarcas.Name = "listBoxMarcas";
            this.listBoxMarcas.Size = new System.Drawing.Size(199, 244);
            this.listBoxMarcas.TabIndex = 3;
            this.listBoxMarcas.ValueMember = "Id";
            this.listBoxMarcas.SelectedIndexChanged += new System.EventHandler(this.listBoxMarcas_SelectedIndexChanged);
            // 
            // listBoxModelos
            // 
            this.listBoxModelos.FormattingEnabled = true;
            this.listBoxModelos.ItemHeight = 20;
            this.listBoxModelos.Location = new System.Drawing.Point(327, 73);
            this.listBoxModelos.Name = "listBoxModelos";
            this.listBoxModelos.Size = new System.Drawing.Size(199, 244);
            this.listBoxModelos.TabIndex = 4;
            // 
            // listBoxAños
            // 
            this.listBoxAños.FormattingEnabled = true;
            this.listBoxAños.ItemHeight = 20;
            this.listBoxAños.Location = new System.Drawing.Point(600, 73);
            this.listBoxAños.Name = "listBoxAños";
            this.listBoxAños.Size = new System.Drawing.Size(197, 244);
            this.listBoxAños.TabIndex = 5;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(50, 347);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(476, 271);
            this.pictureBoxFoto.TabIndex = 6;
            this.pictureBoxFoto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Marcas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modelos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Año";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(604, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(608, 437);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(18, 20);
            this.lblPrecio.TabIndex = 11;
            this.lblPrecio.Text = "$";
            // 
            // autoLoteDataSet
            // 
            this.autoLoteDataSet.DataSetName = "AutoLoteDataSet";
            this.autoLoteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "Marca";
            this.marcaBindingSource.DataSource = this.autoLoteDataSet;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 667);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.listBoxAños);
            this.Controls.Add(this.listBoxModelos);
            this.Controls.Add(this.listBoxMarcas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoLoteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMarcas;
        private System.Windows.Forms.ListBox listBoxModelos;
        private System.Windows.Forms.ListBox listBoxAños;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecio;
        private AutoLoteDataSet autoLoteDataSet;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private AutoLoteDataSetTableAdapters.MarcaTableAdapter marcaTableAdapter;
    }
}

