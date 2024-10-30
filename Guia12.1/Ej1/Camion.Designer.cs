namespace Ej1
{
    partial class Camion
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
            this.nCapacidad = new System.Windows.Forms.NumericUpDown();
            this.Aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capacidad del camion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nCapacidad
            // 
            this.nCapacidad.Location = new System.Drawing.Point(140, 26);
            this.nCapacidad.Name = "nCapacidad";
            this.nCapacidad.Size = new System.Drawing.Size(73, 20);
            this.nCapacidad.TabIndex = 1;
            // 
            // Aceptar
            // 
            this.Aceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Aceptar.Location = new System.Drawing.Point(77, 65);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(91, 43);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            // 
            // Camion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 120);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.nCapacidad);
            this.Controls.Add(this.label1);
            this.Name = "Camion";
            this.Text = "Camion";
            ((System.ComponentModel.ISupportInitialize)(this.nCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown nCapacidad;
        private System.Windows.Forms.Button Aceptar;
    }
}