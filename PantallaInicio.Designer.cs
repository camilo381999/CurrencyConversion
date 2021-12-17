
namespace AppCurrencyConversion
{
    partial class PantallaInicio
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
            this.ObjetivoMoneda = new System.Windows.Forms.ComboBox();
            this.OrigenMoneda = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConvertirBoton = new System.Windows.Forms.Button();
            this.ObjetivoValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorOrigen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ObjetivoMoneda
            // 
            this.ObjetivoMoneda.FormattingEnabled = true;
            this.ObjetivoMoneda.Location = new System.Drawing.Point(250, 53);
            this.ObjetivoMoneda.Name = "ObjetivoMoneda";
            this.ObjetivoMoneda.Size = new System.Drawing.Size(121, 21);
            this.ObjetivoMoneda.TabIndex = 0;
            this.ObjetivoMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // OrigenMoneda
            // 
            this.OrigenMoneda.FormattingEnabled = true;
            this.OrigenMoneda.Items.AddRange(new object[] {
            "NA",
            "EU",
            "YN",
            "COL"});
            this.OrigenMoneda.Location = new System.Drawing.Point(85, 53);
            this.OrigenMoneda.Name = "OrigenMoneda";
            this.OrigenMoneda.Size = new System.Drawing.Size(121, 21);
            this.OrigenMoneda.TabIndex = 1;
            this.OrigenMoneda.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Convertir de:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "a:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Conversion de divisas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ConvertirBoton
            // 
            this.ConvertirBoton.Location = new System.Drawing.Point(169, 107);
            this.ConvertirBoton.Name = "ConvertirBoton";
            this.ConvertirBoton.Size = new System.Drawing.Size(75, 23);
            this.ConvertirBoton.TabIndex = 5;
            this.ConvertirBoton.Text = "Convertir";
            this.ConvertirBoton.UseVisualStyleBackColor = true;
            this.ConvertirBoton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ObjetivoValor
            // 
            this.ObjetivoValor.Location = new System.Drawing.Point(250, 151);
            this.ObjetivoValor.Name = "ObjetivoValor";
            this.ObjetivoValor.Size = new System.Drawing.Size(114, 20);
            this.ObjetivoValor.TabIndex = 6;
            this.ObjetivoValor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultado:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ValorOrigen
            // 
            this.ValorOrigen.Location = new System.Drawing.Point(66, 151);
            this.ValorOrigen.Name = "ValorOrigen";
            this.ValorOrigen.Size = new System.Drawing.Size(114, 20);
            this.ValorOrigen.TabIndex = 8;
            this.ValorOrigen.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "De:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PantallaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 206);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValorOrigen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ObjetivoValor);
            this.Controls.Add(this.ConvertirBoton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrigenMoneda);
            this.Controls.Add(this.ObjetivoMoneda);
            this.Name = "PantallaInicio";
            this.Text = "PantallaInicio";
            this.Load += new System.EventHandler(this.PantallaInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ObjetivoMoneda;
        private System.Windows.Forms.ComboBox OrigenMoneda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ConvertirBoton;
        private System.Windows.Forms.TextBox ObjetivoValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValorOrigen;
        private System.Windows.Forms.Label label5;
    }
}