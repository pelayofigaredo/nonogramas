using System;
using System.Drawing;
using System.Windows.Forms;

namespace NonogramasDePelayo
{
    partial class FormNonograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNonograma));
            this.pnlNonograma = new System.Windows.Forms.Panel();
            this.pnlBloquesFilas = new System.Windows.Forms.Panel();
            this.pnlBloquesColumnas = new System.Windows.Forms.Panel();
            this.lblVida = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlNonograma
            // 
            this.pnlNonograma.Location = new System.Drawing.Point(197, 123);
            this.pnlNonograma.Name = "pnlNonograma";
            this.pnlNonograma.Size = new System.Drawing.Size(200, 100);
            this.pnlNonograma.TabIndex = 0;
            // 
            // pnlBloquesFilas
            // 
            this.pnlBloquesFilas.Location = new System.Drawing.Point(12, 144);
            this.pnlBloquesFilas.Name = "pnlBloquesFilas";
            this.pnlBloquesFilas.Size = new System.Drawing.Size(112, 79);
            this.pnlBloquesFilas.TabIndex = 1;
            // 
            // pnlBloquesColumnas
            // 
            this.pnlBloquesColumnas.Location = new System.Drawing.Point(197, 17);
            this.pnlBloquesColumnas.Name = "pnlBloquesColumnas";
            this.pnlBloquesColumnas.Size = new System.Drawing.Size(200, 100);
            this.pnlBloquesColumnas.TabIndex = 1;
            // 
            // lblVida
            // 
            this.lblVida.Font = new System.Drawing.Font("Castellar", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.lblVida.Location = new System.Drawing.Point(78, 78);
            this.lblVida.Name = "lblVida";
            this.lblVida.Size = new System.Drawing.Size(60, 60);
            this.lblVida.TabIndex = 22;
            this.lblVida.Text = "0";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Font = new System.Drawing.Font("Castellar", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.Location = new System.Drawing.Point(12, 12);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(60, 60);
            this.btnZoomIn.TabIndex = 23;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Font = new System.Drawing.Font("Castellar", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.Location = new System.Drawing.Point(12, 78);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(60, 60);
            this.btnZoomOut.TabIndex = 24;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnMute
            // 
            this.btnMute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMute.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.Image = ((System.Drawing.Image)(resources.GetObject("btnMute.Image")));
            this.btnMute.Location = new System.Drawing.Point(78, 12);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(60, 60);
            this.btnMute.TabIndex = 25;
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // FormNonograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(404, 229);
            this.Controls.Add(this.btnMute);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.pnlNonograma);
            this.Controls.Add(this.pnlBloquesFilas);
            this.Controls.Add(this.pnlBloquesColumnas);
            this.Controls.Add(this.lblVida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNonograma";
            this.Text = "FormAuto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNonograma_FormClosing);
            this.ResumeLayout(false);

        }
        #endregion
        private Button[,] botones;
        private Button[,] btnBloquesFilas;
        private Button[,] btnBloquesColumnas;
        private Panel pnlBloquesFilas;
        private Panel pnlBloquesColumnas;
        private Panel pnlNonograma;

        private Label lblVida;
        private Button btnZoomIn;
        private Button btnZoomOut;
        private Button btnMute;
    }
}