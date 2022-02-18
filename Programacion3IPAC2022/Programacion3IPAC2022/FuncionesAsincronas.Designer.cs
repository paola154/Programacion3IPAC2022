namespace Programacion3IPAC2022
{
    partial class FuncionesAsincronas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Hornearbutton = new System.Windows.Forms.Button();
            this.otrasTareasbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Sumarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Hornearbutton
            // 
            this.Hornearbutton.Location = new System.Drawing.Point(63, 39);
            this.Hornearbutton.Name = "Hornearbutton";
            this.Hornearbutton.Size = new System.Drawing.Size(96, 23);
            this.Hornearbutton.TabIndex = 1;
            this.Hornearbutton.Text = "Hornear Pizza";
            this.Hornearbutton.UseVisualStyleBackColor = true;
            this.Hornearbutton.Click += new System.EventHandler(this.Hornearbutton_Click);
            // 
            // otrasTareasbutton
            // 
            this.otrasTareasbutton.Location = new System.Drawing.Point(185, 39);
            this.otrasTareasbutton.Name = "otrasTareasbutton";
            this.otrasTareasbutton.Size = new System.Drawing.Size(75, 23);
            this.otrasTareasbutton.TabIndex = 2;
            this.otrasTareasbutton.Text = "Otras Tareas";
            this.otrasTareasbutton.UseVisualStyleBackColor = true;
            this.otrasTareasbutton.Click += new System.EventHandler(this.otrasTareasbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 208);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Sumarbutton
            // 
            this.Sumarbutton.Location = new System.Drawing.Point(202, 164);
            this.Sumarbutton.Name = "Sumarbutton";
            this.Sumarbutton.Size = new System.Drawing.Size(75, 23);
            this.Sumarbutton.TabIndex = 5;
            this.Sumarbutton.Text = "Sumar";
            this.Sumarbutton.UseVisualStyleBackColor = true;
            this.Sumarbutton.Click += new System.EventHandler(this.Sumarbutton_Click);
            // 
            // FuncionesAsincronas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 303);
            this.Controls.Add(this.Sumarbutton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.otrasTareasbutton);
            this.Controls.Add(this.Hornearbutton);
            this.Controls.Add(this.label1);
            this.Name = "FuncionesAsincronas";
            this.Text = "FuncionesAsincronas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Hornearbutton;
        private System.Windows.Forms.Button otrasTareasbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Sumarbutton;
    }
}