namespace PClasses
{
    partial class frmHorista
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblDataEntrada = new System.Windows.Forms.Label();
            this.lblSalarioHr = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.txtSalarioHr = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Inspecionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bttSim = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttNão = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Georgia", 8F);
            this.lblMatricula.Location = new System.Drawing.Point(89, 62);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(76, 18);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            this.lblMatricula.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblDataEntrada
            // 
            this.lblDataEntrada.AutoSize = true;
            this.lblDataEntrada.Font = new System.Drawing.Font("Georgia", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntrada.Location = new System.Drawing.Point(89, 272);
            this.lblDataEntrada.Name = "lblDataEntrada";
            this.lblDataEntrada.Size = new System.Drawing.Size(190, 18);
            this.lblDataEntrada.TabIndex = 2;
            this.lblDataEntrada.Text = "Data Entrada na Empresa";
            this.lblDataEntrada.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lblSalarioHr
            // 
            this.lblSalarioHr.AutoSize = true;
            this.lblSalarioHr.Font = new System.Drawing.Font("Georgia", 8F);
            this.lblSalarioHr.Location = new System.Drawing.Point(89, 200);
            this.lblSalarioHr.Name = "lblSalarioHr";
            this.lblSalarioHr.Size = new System.Drawing.Size(95, 18);
            this.lblSalarioHr.TabIndex = 3;
            this.lblSalarioHr.Text = "Salário Hora";
            this.lblSalarioHr.Click += new System.EventHandler(this.Label4_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Georgia", 8F);
            this.lblNome.Location = new System.Drawing.Point(89, 128);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.Label5_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(316, 59);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(285, 26);
            this.txtMatricula.TabIndex = 5;
            this.txtMatricula.TextChanged += new System.EventHandler(this.TxtMatricula_TextChanged);
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Location = new System.Drawing.Point(316, 266);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(285, 26);
            this.txtDataEntrada.TabIndex = 6;
            this.txtDataEntrada.TextChanged += new System.EventHandler(this.TxtDataEntrada_TextChanged);
            // 
            // txtSalarioHr
            // 
            this.txtSalarioHr.Location = new System.Drawing.Point(316, 194);
            this.txtSalarioHr.Name = "txtSalarioHr";
            this.txtSalarioHr.Size = new System.Drawing.Size(285, 26);
            this.txtSalarioHr.TabIndex = 7;
            this.txtSalarioHr.TextChanged += new System.EventHandler(this.TxtSalarioHr_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(316, 122);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(285, 26);
            this.txtNome.TabIndex = 8;
            this.txtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // Inspecionar
            // 
            this.Inspecionar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Inspecionar.Location = new System.Drawing.Point(92, 429);
            this.Inspecionar.Name = "Inspecionar";
            this.Inspecionar.Size = new System.Drawing.Size(172, 120);
            this.Inspecionar.TabIndex = 9;
            this.Inspecionar.Text = "Inspecionar Matrícula";
            this.Inspecionar.UseVisualStyleBackColor = false;
            this.Inspecionar.Click += new System.EventHandler(this.Inspecionar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(429, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 120);
            this.button2.TabIndex = 10;
            this.button2.Text = "Inspencionar Matrícula passando parametros";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // bttSim
            // 
            this.bttSim.AutoSize = true;
            this.bttSim.Location = new System.Drawing.Point(25, 66);
            this.bttSim.Name = "bttSim";
            this.bttSim.Size = new System.Drawing.Size(61, 24);
            this.bttSim.TabIndex = 12;
            this.bttSim.TabStop = true;
            this.bttSim.Text = "Sim";
            this.bttSim.UseVisualStyleBackColor = true;
            this.bttSim.CheckedChanged += new System.EventHandler(this.BttSim_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttNão);
            this.groupBox1.Controls.Add(this.bttSim);
            this.groupBox1.Location = new System.Drawing.Point(715, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 156);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabalha em Home Office";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // bttNão
            // 
            this.bttNão.AutoSize = true;
            this.bttNão.Location = new System.Drawing.Point(25, 108);
            this.bttNão.Name = "bttNão";
            this.bttNão.Size = new System.Drawing.Size(63, 24);
            this.bttNão.TabIndex = 13;
            this.bttNão.TabStop = true;
            this.bttNão.Text = "Não";
            this.bttNão.UseVisualStyleBackColor = true;
            this.bttNão.CheckedChanged += new System.EventHandler(this.BttNão_CheckedChanged);
            // 
            // frmHorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 623);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Inspecionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtSalarioHr);
            this.Controls.Add(this.txtDataEntrada);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblSalarioHr);
            this.Controls.Add(this.lblDataEntrada);
            this.Controls.Add(this.lblMatricula);
            this.Name = "frmHorista";
            this.Text = "frmHorista";
            this.Load += new System.EventHandler(this.FrmHorista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblDataEntrada;
        private System.Windows.Forms.Label lblSalarioHr;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.TextBox txtSalarioHr;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button Inspecionar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton bttSim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton bttNão;
    }
}