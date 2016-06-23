namespace GeneradorQR
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.pcQr1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSeleccionarFichero = new System.Windows.Forms.Button();
            this.lblFichero = new System.Windows.Forms.Label();
            this.lblTRutaFichero = new System.Windows.Forms.Label();
            this.lblGenerarQR = new System.Windows.Forms.Label();
            this.lblMuestra = new System.Windows.Forms.Label();
            this.lblRutaFichero = new System.Windows.Forms.Label();
            this.lblConteo = new System.Windows.Forms.Label();
            this.lblTConteo = new System.Windows.Forms.Label();
            this.chbSaltarCabecera = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcQr1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGenerar.Location = new System.Drawing.Point(230, 389);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // pcQr1
            // 
            this.pcQr1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcQr1.Location = new System.Drawing.Point(122, 168);
            this.pcQr1.Name = "pcQr1";
            this.pcQr1.Size = new System.Drawing.Size(210, 191);
            this.pcQr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcQr1.TabIndex = 1;
            this.pcQr1.TabStop = false;
            // 
            // btnSeleccionarFichero
            // 
            this.btnSeleccionarFichero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSeleccionarFichero.Location = new System.Drawing.Point(230, 114);
            this.btnSeleccionarFichero.Name = "btnSeleccionarFichero";
            this.btnSeleccionarFichero.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarFichero.TabIndex = 2;
            this.btnSeleccionarFichero.Text = "Seleccionar Fichero";
            this.btnSeleccionarFichero.UseVisualStyleBackColor = true;
            this.btnSeleccionarFichero.Click += new System.EventHandler(this.btnSeleccionarFichero_Click);
            // 
            // lblFichero
            // 
            this.lblFichero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFichero.AutoSize = true;
            this.lblFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichero.Location = new System.Drawing.Point(64, 9);
            this.lblFichero.Name = "lblFichero";
            this.lblFichero.Size = new System.Drawing.Size(241, 25);
            this.lblFichero.TabIndex = 3;
            this.lblFichero.Text = "Seleccion de Fichero:";
            // 
            // lblTRutaFichero
            // 
            this.lblTRutaFichero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTRutaFichero.AutoSize = true;
            this.lblTRutaFichero.Location = new System.Drawing.Point(152, 48);
            this.lblTRutaFichero.Name = "lblTRutaFichero";
            this.lblTRutaFichero.Size = new System.Drawing.Size(142, 13);
            this.lblTRutaFichero.TabIndex = 4;
            this.lblTRutaFichero.Text = "No hay fichero seleccionado";
            // 
            // lblGenerarQR
            // 
            this.lblGenerarQR.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGenerarQR.AutoSize = true;
            this.lblGenerarQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarQR.Location = new System.Drawing.Point(64, 140);
            this.lblGenerarQR.Name = "lblGenerarQR";
            this.lblGenerarQR.Size = new System.Drawing.Size(306, 25);
            this.lblGenerarQR.TabIndex = 5;
            this.lblGenerarQR.Text = "Generación de Códigos QR:";
            // 
            // lblMuestra
            // 
            this.lblMuestra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMuestra.AutoSize = true;
            this.lblMuestra.Location = new System.Drawing.Point(144, 362);
            this.lblMuestra.Name = "lblMuestra";
            this.lblMuestra.Size = new System.Drawing.Size(161, 13);
            this.lblMuestra.TabIndex = 6;
            this.lblMuestra.Text = "Muestra de fichero seleccionado";
            // 
            // lblRutaFichero
            // 
            this.lblRutaFichero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRutaFichero.AutoSize = true;
            this.lblRutaFichero.Location = new System.Drawing.Point(66, 48);
            this.lblRutaFichero.Name = "lblRutaFichero";
            this.lblRutaFichero.Size = new System.Drawing.Size(68, 13);
            this.lblRutaFichero.TabIndex = 7;
            this.lblRutaFichero.Text = "Ruta fichero:";
            // 
            // lblConteo
            // 
            this.lblConteo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConteo.AutoSize = true;
            this.lblConteo.Location = new System.Drawing.Point(5, 72);
            this.lblConteo.Name = "lblConteo";
            this.lblConteo.Size = new System.Drawing.Size(129, 13);
            this.lblConteo.TabIndex = 8;
            this.lblConteo.Text = "Nº de lineas encontradas:";
            // 
            // lblTConteo
            // 
            this.lblTConteo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTConteo.AutoSize = true;
            this.lblTConteo.Location = new System.Drawing.Point(152, 72);
            this.lblTConteo.Name = "lblTConteo";
            this.lblTConteo.Size = new System.Drawing.Size(142, 13);
            this.lblTConteo.TabIndex = 9;
            this.lblTConteo.Text = "No hay fichero seleccionado";
            // 
            // chbSaltarCabecera
            // 
            this.chbSaltarCabecera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chbSaltarCabecera.AutoSize = true;
            this.chbSaltarCabecera.Location = new System.Drawing.Point(243, 91);
            this.chbSaltarCabecera.Name = "chbSaltarCabecera";
            this.chbSaltarCabecera.Size = new System.Drawing.Size(101, 17);
            this.chbSaltarCabecera.TabIndex = 10;
            this.chbSaltarCabecera.Text = "Saltar cabecera";
            this.chbSaltarCabecera.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Selecciona la carpeta de destino de los codigos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 421);
            this.Controls.Add(this.chbSaltarCabecera);
            this.Controls.Add(this.lblTConteo);
            this.Controls.Add(this.lblConteo);
            this.Controls.Add(this.lblRutaFichero);
            this.Controls.Add(this.lblMuestra);
            this.Controls.Add(this.lblGenerarQR);
            this.Controls.Add(this.lblTRutaFichero);
            this.Controls.Add(this.lblFichero);
            this.Controls.Add(this.btnSeleccionarFichero);
            this.Controls.Add(this.pcQr1);
            this.Controls.Add(this.btnGenerar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Generador de codigos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcQr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.PictureBox pcQr1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSeleccionarFichero;
        private System.Windows.Forms.Label lblFichero;
        private System.Windows.Forms.Label lblTRutaFichero;
        private System.Windows.Forms.Label lblGenerarQR;
        private System.Windows.Forms.Label lblMuestra;
        private System.Windows.Forms.Label lblRutaFichero;
        private System.Windows.Forms.Label lblConteo;
        private System.Windows.Forms.Label lblTConteo;
        private System.Windows.Forms.CheckBox chbSaltarCabecera;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

