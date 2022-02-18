namespace Programacion3IPAC2022
{
    partial class Funciones
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
            this.Numero1textBox = new System.Windows.Forms.TextBox();
            this.Numero2textBox = new System.Windows.Forms.TextBox();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.Sumarbutton = new System.Windows.Forms.Button();
            this.MostrarMensajebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado:";
            // 
            // Numero1textBox
            // 
            this.Numero1textBox.Location = new System.Drawing.Point(133, 57);
            this.Numero1textBox.Name = "Numero1textBox";
            this.Numero1textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero1textBox.TabIndex = 3;
            // 
            // Numero2textBox
            // 
            this.Numero2textBox.Location = new System.Drawing.Point(133, 102);
            this.Numero2textBox.Name = "Numero2textBox";
            this.Numero2textBox.Size = new System.Drawing.Size(100, 20);
            this.Numero2textBox.TabIndex = 4;
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(133, 144);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadotextBox.TabIndex = 5;
            // 
            // Sumarbutton
            // 
            this.Sumarbutton.Location = new System.Drawing.Point(318, 57);
            this.Sumarbutton.Name = "Sumarbutton";
            this.Sumarbutton.Size = new System.Drawing.Size(75, 23);
            this.Sumarbutton.TabIndex = 6;
            this.Sumarbutton.Text = "Sumar";
            this.Sumarbutton.UseVisualStyleBackColor = true;
            this.Sumarbutton.Click += new System.EventHandler(this.Sumarbutton_Click);
            // 
            // MostrarMensajebutton
            // 
            this.MostrarMensajebutton.Location = new System.Drawing.Point(318, 102);
            this.MostrarMensajebutton.Name = "MostrarMensajebutton";
            this.MostrarMensajebutton.Size = new System.Drawing.Size(75, 23);
            this.MostrarMensajebutton.TabIndex = 7;
            this.MostrarMensajebutton.Text = "Mostrar Mensaje";
            this.MostrarMensajebutton.UseVisualStyleBackColor = true;
            this.MostrarMensajebutton.Click += new System.EventHandler(this.MostrarMensajebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 298);
            this.Controls.Add(this.MostrarMensajebutton);
            this.Controls.Add(this.Sumarbutton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.Numero2textBox);
            this.Controls.Add(this.Numero1textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operacion Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Numero1textBox;
        private System.Windows.Forms.TextBox Numero2textBox;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button Sumarbutton;
        private System.Windows.Forms.Button MostrarMensajebutton;
    }
}

