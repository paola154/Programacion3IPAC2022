namespace BilkisPerdomo
{
    partial class Formulario1
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
            this.MostrarValoreslistBox = new System.Windows.Forms.ListBox();
            this.CalcularInteresebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SaldoInicialtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MostrarValoreslistBox
            // 
            this.MostrarValoreslistBox.FormattingEnabled = true;
            this.MostrarValoreslistBox.Location = new System.Drawing.Point(57, 95);
            this.MostrarValoreslistBox.Name = "MostrarValoreslistBox";
            this.MostrarValoreslistBox.Size = new System.Drawing.Size(316, 160);
            this.MostrarValoreslistBox.TabIndex = 0;
            // 
            // CalcularInteresebutton
            // 
            this.CalcularInteresebutton.Location = new System.Drawing.Point(379, 95);
            this.CalcularInteresebutton.Name = "CalcularInteresebutton";
            this.CalcularInteresebutton.Size = new System.Drawing.Size(99, 23);
            this.CalcularInteresebutton.TabIndex = 1;
            this.CalcularInteresebutton.Text = "Calcular Intereses";
            this.CalcularInteresebutton.UseVisualStyleBackColor = true;
            this.CalcularInteresebutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Saldo Inicial: ";
            // 
            // SaldoInicialtextBox
            // 
            this.SaldoInicialtextBox.Location = new System.Drawing.Point(130, 20);
            this.SaldoInicialtextBox.Name = "SaldoInicialtextBox";
            this.SaldoInicialtextBox.ReadOnly = true;
            this.SaldoInicialtextBox.Size = new System.Drawing.Size(100, 20);
            this.SaldoInicialtextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tasa de interes 2.5% mensual";
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 271);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaldoInicialtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalcularInteresebutton);
            this.Controls.Add(this.MostrarValoreslistBox);
            this.Name = "Formulario1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formulario1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MostrarValoreslistBox;
        private System.Windows.Forms.Button CalcularInteresebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SaldoInicialtextBox;
        private System.Windows.Forms.Label label2;
    }
}

