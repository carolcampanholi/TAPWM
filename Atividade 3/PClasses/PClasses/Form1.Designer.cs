﻿namespace PClasses
{
    partial class Form1
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
            this.btnHorista = new System.Windows.Forms.Button();
            this.btnMensalista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHorista
            // 
            this.btnHorista.Location = new System.Drawing.Point(181, 190);
            this.btnHorista.Name = "btnHorista";
            this.btnHorista.Size = new System.Drawing.Size(130, 63);
            this.btnHorista.TabIndex = 0;
            this.btnHorista.Text = "Horista";
            this.btnHorista.UseVisualStyleBackColor = true;
            this.btnHorista.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnMensalista
            // 
            this.btnMensalista.Location = new System.Drawing.Point(500, 190);
            this.btnMensalista.Name = "btnMensalista";
            this.btnMensalista.Size = new System.Drawing.Size(130, 63);
            this.btnMensalista.TabIndex = 1;
            this.btnMensalista.Text = "Mensalista";
            this.btnMensalista.UseVisualStyleBackColor = true;
            this.btnMensalista.Click += new System.EventHandler(this.BtnMensalista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 458);
            this.Controls.Add(this.btnMensalista);
            this.Controls.Add(this.btnHorista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHorista;
        private System.Windows.Forms.Button btnMensalista;
    }
}

