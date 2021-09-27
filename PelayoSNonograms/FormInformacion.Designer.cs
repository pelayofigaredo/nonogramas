using System.Drawing;

namespace NonogramasDePelayo
{
    partial class FormInformacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformacion));
            this.btnVolver = new System.Windows.Forms.Button();
            this.tBExplicacion = new System.Windows.Forms.TextBox();
            this.tBExplicacion2 = new System.Windows.Forms.TextBox();
            this.tbExpliacion3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Castellar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(327, 402);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(130, 36);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tBExplicacion
            // 
            this.tBExplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.tBExplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBExplicacion.Location = new System.Drawing.Point(12, 72);
            this.tBExplicacion.Multiline = true;
            this.tBExplicacion.Name = "tBExplicacion";
            this.tBExplicacion.ReadOnly = true;
            this.tBExplicacion.Size = new System.Drawing.Size(785, 158);
            this.tBExplicacion.TabIndex = 8;
            this.tBExplicacion.Text = resources.GetString("tBExplicacion.Text");
            // 
            // tBExplicacion2
            // 
            this.tBExplicacion2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.tBExplicacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBExplicacion2.Location = new System.Drawing.Point(12, 236);
            this.tBExplicacion2.Multiline = true;
            this.tBExplicacion2.Name = "tBExplicacion2";
            this.tBExplicacion2.ReadOnly = true;
            this.tBExplicacion2.Size = new System.Drawing.Size(785, 104);
            this.tBExplicacion2.TabIndex = 9;
            this.tBExplicacion2.Text = resources.GetString("tBExplicacion2.Text");
            // 
            // tbExpliacion3
            // 
            this.tbExpliacion3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(108)))), ((int)(((byte)(32)))));
            this.tbExpliacion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExpliacion3.Location = new System.Drawing.Point(125, 372);
            this.tbExpliacion3.Multiline = true;
            this.tbExpliacion3.Name = "tbExpliacion3";
            this.tbExpliacion3.ReadOnly = true;
            this.tbExpliacion3.Size = new System.Drawing.Size(558, 24);
            this.tbExpliacion3.TabIndex = 10;
            this.tbExpliacion3.Text = "Esta aplicación ha sido desarrollada por Pelayo Figaredo García para la asignatur" +
    "a Programación II\r\n";
            // 
            // FormInformacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbExpliacion3);
            this.Controls.Add(this.tBExplicacion2);
            this.Controls.Add(this.tBExplicacion);
            this.Controls.Add(this.btnVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformacion";
            this.Text = "FormInformacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox tBExplicacion;
        private System.Windows.Forms.TextBox tBExplicacion2;
        private System.Windows.Forms.TextBox tbExpliacion3;
    }
}