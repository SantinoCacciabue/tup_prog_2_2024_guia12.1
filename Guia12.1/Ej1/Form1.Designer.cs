namespace Ej1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBdni = new System.Windows.Forms.TextBox();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBdir = new System.Windows.Forms.TextBox();
            this.bRecibir = new System.Windows.Forms.Button();
            this.lBpaquetesAlmacen = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bIniciar = new System.Windows.Forms.Button();
            this.bEntregar = new System.Windows.Forms.Button();
            this.lBlistadoEntrega = new System.Windows.Forms.ListBox();
            this.tBdirEntrega = new System.Windows.Forms.TextBox();
            this.tBnombreEntrega = new System.Windows.Forms.TextBox();
            this.tBdniEntrega = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bRecibir);
            this.groupBox1.Controls.Add(this.tBdir);
            this.groupBox1.Controls.Add(this.tBnombre);
            this.groupBox1.Controls.Add(this.tBdni);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atención al cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(191, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 250);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lBpaquetesAlmacen);
            this.groupBox3.Location = new System.Drawing.Point(209, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 250);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Paquetes en sector de embarque";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lBlistadoEntrega);
            this.groupBox4.Controls.Add(this.bEntregar);
            this.groupBox4.Controls.Add(this.bIniciar);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(479, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 250);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Reparto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección";
            // 
            // tBdni
            // 
            this.tBdni.Location = new System.Drawing.Point(58, 19);
            this.tBdni.Name = "tBdni";
            this.tBdni.Size = new System.Drawing.Size(121, 20);
            this.tBdni.TabIndex = 5;
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(58, 49);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(121, 20);
            this.tBnombre.TabIndex = 6;
            // 
            // tBdir
            // 
            this.tBdir.Location = new System.Drawing.Point(58, 79);
            this.tBdir.Multiline = true;
            this.tBdir.Name = "tBdir";
            this.tBdir.Size = new System.Drawing.Size(121, 76);
            this.tBdir.TabIndex = 7;
            // 
            // bRecibir
            // 
            this.bRecibir.Location = new System.Drawing.Point(44, 178);
            this.bRecibir.Name = "bRecibir";
            this.bRecibir.Size = new System.Drawing.Size(97, 50);
            this.bRecibir.TabIndex = 0;
            this.bRecibir.Text = "Recibir correspondencia";
            this.bRecibir.UseVisualStyleBackColor = true;
            this.bRecibir.Click += new System.EventHandler(this.bRecibir_Click);
            // 
            // lBpaquetesAlmacen
            // 
            this.lBpaquetesAlmacen.FormattingEnabled = true;
            this.lBpaquetesAlmacen.Location = new System.Drawing.Point(6, 19);
            this.lBpaquetesAlmacen.Name = "lBpaquetesAlmacen";
            this.lBpaquetesAlmacen.Size = new System.Drawing.Size(252, 173);
            this.lBpaquetesAlmacen.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Preparar camión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tBdirEntrega);
            this.groupBox5.Controls.Add(this.tBnombreEntrega);
            this.groupBox5.Controls.Add(this.tBdniEntrega);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 100);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Próxima entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // bIniciar
            // 
            this.bIniciar.Location = new System.Drawing.Point(6, 125);
            this.bIniciar.Name = "bIniciar";
            this.bIniciar.Size = new System.Drawing.Size(97, 34);
            this.bIniciar.TabIndex = 9;
            this.bIniciar.Text = "Iniciar Reparto";
            this.bIniciar.UseVisualStyleBackColor = true;
            this.bIniciar.Click += new System.EventHandler(this.bIniciar_Click);
            // 
            // bEntregar
            // 
            this.bEntregar.Location = new System.Drawing.Point(141, 125);
            this.bEntregar.Name = "bEntregar";
            this.bEntregar.Size = new System.Drawing.Size(97, 34);
            this.bEntregar.TabIndex = 9;
            this.bEntregar.Text = "Entregar Paquete";
            this.bEntregar.UseVisualStyleBackColor = true;
            this.bEntregar.Click += new System.EventHandler(this.bEntregar_Click);
            // 
            // lBlistadoEntrega
            // 
            this.lBlistadoEntrega.FormattingEnabled = true;
            this.lBlistadoEntrega.Location = new System.Drawing.Point(6, 168);
            this.lBlistadoEntrega.Name = "lBlistadoEntrega";
            this.lBlistadoEntrega.Size = new System.Drawing.Size(252, 69);
            this.lBlistadoEntrega.TabIndex = 9;
            // 
            // tBdirEntrega
            // 
            this.tBdirEntrega.Enabled = false;
            this.tBdirEntrega.Location = new System.Drawing.Point(64, 72);
            this.tBdirEntrega.Name = "tBdirEntrega";
            this.tBdirEntrega.Size = new System.Drawing.Size(182, 20);
            this.tBdirEntrega.TabIndex = 8;
            // 
            // tBnombreEntrega
            // 
            this.tBnombreEntrega.Enabled = false;
            this.tBnombreEntrega.Location = new System.Drawing.Point(64, 47);
            this.tBnombreEntrega.Name = "tBnombreEntrega";
            this.tBnombreEntrega.Size = new System.Drawing.Size(121, 20);
            this.tBnombreEntrega.TabIndex = 9;
            // 
            // tBdniEntrega
            // 
            this.tBdniEntrega.Enabled = false;
            this.tBdniEntrega.Location = new System.Drawing.Point(64, 24);
            this.tBdniEntrega.Name = "tBdniEntrega";
            this.tBdniEntrega.Size = new System.Drawing.Size(121, 20);
            this.tBdniEntrega.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 278);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bRecibir;
        private System.Windows.Forms.TextBox tBdir;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.TextBox tBdni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lBpaquetesAlmacen;
        private System.Windows.Forms.ListBox lBlistadoEntrega;
        private System.Windows.Forms.Button bEntregar;
        private System.Windows.Forms.Button bIniciar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tBdirEntrega;
        private System.Windows.Forms.TextBox tBnombreEntrega;
        private System.Windows.Forms.TextBox tBdniEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

