namespace NonogramasDePelayo
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbnonogramaSeleccionado = new System.Windows.Forms.ComboBox();
            this.btnJugarAleatorio = new System.Windows.Forms.Button();
            this.btnInformacion = new System.Windows.Forms.Button();
            this.picFondoMenu = new System.Windows.Forms.PictureBox();
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnMute = new System.Windows.Forms.Button();
            this.tmrMusica = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFondoMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Transparent;
            this.btnJugar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJugar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(105, 223);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(137, 32);
            this.btnJugar.TabIndex = 1;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(647, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(150, 34);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(497, 341);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(300, 37);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Resetear progreso";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbnonogramaSeleccionado
            // 
            this.cbnonogramaSeleccionado.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbnonogramaSeleccionado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbnonogramaSeleccionado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbnonogramaSeleccionado.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnonogramaSeleccionado.FormattingEnabled = true;
            this.cbnonogramaSeleccionado.Location = new System.Drawing.Point(248, 223);
            this.cbnonogramaSeleccionado.Name = "cbnonogramaSeleccionado";
            this.cbnonogramaSeleccionado.Size = new System.Drawing.Size(422, 31);
            this.cbnonogramaSeleccionado.TabIndex = 4;
            this.cbnonogramaSeleccionado.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbnonogramaSeleccionado_DrawItem);
            this.cbnonogramaSeleccionado.SelectedIndexChanged += new System.EventHandler(this.cbnonogramaSeleccionado_SelectedIndexChanged);
            this.cbnonogramaSeleccionado.Click += new System.EventHandler(this.cbnonogramaSeleccionado_Click);
            // 
            // btnJugarAleatorio
            // 
            this.btnJugarAleatorio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJugarAleatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnJugarAleatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugarAleatorio.Font = new System.Drawing.Font("Castellar", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugarAleatorio.Location = new System.Drawing.Point(105, 281);
            this.btnJugarAleatorio.Name = "btnJugarAleatorio";
            this.btnJugarAleatorio.Size = new System.Drawing.Size(210, 62);
            this.btnJugarAleatorio.TabIndex = 5;
            this.btnJugarAleatorio.Text = "Jugar a puzle aleatorio";
            this.btnJugarAleatorio.UseVisualStyleBackColor = true;
            this.btnJugarAleatorio.Click += new System.EventHandler(this.btnJugarAleatorio_Click);
            // 
            // btnInformacion
            // 
            this.btnInformacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformacion.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformacion.Location = new System.Drawing.Point(12, 376);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(230, 36);
            this.btnInformacion.TabIndex = 6;
            this.btnInformacion.Text = "Información";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // picFondoMenu
            // 
            this.picFondoMenu.Image = ((System.Drawing.Image)(resources.GetObject("picFondoMenu.Image")));
            this.picFondoMenu.Location = new System.Drawing.Point(0, 0);
            this.picFondoMenu.Name = "picFondoMenu";
            this.picFondoMenu.Size = new System.Drawing.Size(825, 470);
            this.picFondoMenu.TabIndex = 7;
            this.picFondoMenu.TabStop = false;
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(0, 0);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(75, 23);
            this.wmp.TabIndex = 8;
            this.wmp.Visible = false;
            this.wmp.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmp_PlayStateChange);
            // 
            // btnMute
            // 
            this.btnMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.Location = new System.Drawing.Point(737, 276);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(60, 60);
            this.btnMute.TabIndex = 9;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // tmrMusica
            // 
            this.tmrMusica.Enabled = true;
            this.tmrMusica.Tick += new System.EventHandler(this.tmrMusica_Tick);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 431);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnJugarAleatorio);
            this.Controls.Add(this.cbnonogramaSeleccionado);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.picFondoMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Nonogramas de Pelayo";
            ((System.ComponentModel.ISupportInitialize)(this.picFondoMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbnonogramaSeleccionado;
        private System.Windows.Forms.Button btnJugarAleatorio;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.PictureBox picFondoMenu;
        public AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Timer tmrMusica;
    }
}

