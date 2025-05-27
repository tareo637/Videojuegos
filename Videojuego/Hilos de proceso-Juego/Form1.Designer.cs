namespace Hilos_de_proceso_Juego
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bebe1 = new System.Windows.Forms.PictureBox();
            this.Perro1 = new System.Windows.Forms.PictureBox();
            this.Cuchillo = new System.Windows.Forms.PictureBox();
            this.Abuela1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovimientoPista = new System.Windows.Forms.Timer(this.components);
            this.LadoDerecho = new System.Windows.Forms.Timer(this.components);
            this.LaodIzquierdo = new System.Windows.Forms.Timer(this.components);
            this.Abuela = new System.Windows.Forms.Timer(this.components);
            this.Bebe = new System.Windows.Forms.Timer(this.components);
            this.Perro = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bebe1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuchillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abuela1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(-1, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puntaje 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(241, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Velocidad: 0";
            // 
            // Bebe1
            // 
            this.Bebe1.Image = global::Hilos_de_proceso_Juego.Properties.Resources.bebe_removebg_preview;
            this.Bebe1.Location = new System.Drawing.Point(131, 19);
            this.Bebe1.Name = "Bebe1";
            this.Bebe1.Size = new System.Drawing.Size(55, 98);
            this.Bebe1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bebe1.TabIndex = 13;
            this.Bebe1.TabStop = false;
            // 
            // Perro1
            // 
            this.Perro1.Image = global::Hilos_de_proceso_Juego.Properties.Resources.perro_removebg_preview;
            this.Perro1.Location = new System.Drawing.Point(267, 114);
            this.Perro1.Name = "Perro1";
            this.Perro1.Size = new System.Drawing.Size(55, 98);
            this.Perro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Perro1.TabIndex = 12;
            this.Perro1.TabStop = false;
            // 
            // Cuchillo
            // 
            this.Cuchillo.Image = global::Hilos_de_proceso_Juego.Properties.Resources.cuchillo_removebg_preview;
            this.Cuchillo.Location = new System.Drawing.Point(131, 351);
            this.Cuchillo.Name = "Cuchillo";
            this.Cuchillo.Size = new System.Drawing.Size(43, 82);
            this.Cuchillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cuchillo.TabIndex = 11;
            this.Cuchillo.TabStop = false;
            // 
            // Abuela1
            // 
            this.Abuela1.Image = global::Hilos_de_proceso_Juego.Properties.Resources.abuela_removebg_preview;
            this.Abuela1.Location = new System.Drawing.Point(4, 114);
            this.Abuela1.Name = "Abuela1";
            this.Abuela1.Size = new System.Drawing.Size(55, 98);
            this.Abuela1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Abuela1.TabIndex = 10;
            this.Abuela1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox8.Location = new System.Drawing.Point(221, 378);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(14, 116);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox7.Location = new System.Drawing.Point(74, 378);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(14, 116);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(222, -57);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(14, 116);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(74, 86);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(14, 116);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(221, 225);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 116);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(74, 234);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(14, 116);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(222, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 116);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(74, -57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MovimientoPista
            // 
            this.MovimientoPista.Enabled = true;
            this.MovimientoPista.Interval = 10;
            this.MovimientoPista.Tick += new System.EventHandler(this.MovimientoPista_Tick);
            // 
            // LadoDerecho
            // 
            this.LadoDerecho.Interval = 10;
            this.LadoDerecho.Tick += new System.EventHandler(this.LadoDerecho_Tick);
            // 
            // LaodIzquierdo
            // 
            this.LaodIzquierdo.Interval = 10;
            this.LaodIzquierdo.Tick += new System.EventHandler(this.LaodIzquierdo_Tick);
            // 
            // Abuela
            // 
            this.Abuela.Enabled = true;
            this.Abuela.Interval = 10;
            this.Abuela.Tick += new System.EventHandler(this.Abuela_Tick);
            // 
            // Bebe
            // 
            this.Bebe.Enabled = true;
            this.Bebe.Interval = 10;
            this.Bebe.Tick += new System.EventHandler(this.Bebe_Tick);
            // 
            // Perro
            // 
            this.Perro.Enabled = true;
            this.Perro.Interval = 10;
            this.Perro.Tick += new System.EventHandler(this.Perro_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(67, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fin Del Juego";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Location = new System.Drawing.Point(113, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Repetir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Bebe1);
            this.Controls.Add(this.Perro1);
            this.Controls.Add(this.Cuchillo);
            this.Controls.Add(this.Abuela1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "Form1";
            this.Text = "Autopista enFuga 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Bebe1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cuchillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abuela1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Abuela1;
        private System.Windows.Forms.PictureBox Cuchillo;
        private System.Windows.Forms.PictureBox Perro1;
        private System.Windows.Forms.PictureBox Bebe1;
        private System.Windows.Forms.Timer MovimientoPista;
        private System.Windows.Forms.Timer LadoDerecho;
        private System.Windows.Forms.Timer LaodIzquierdo;
        private System.Windows.Forms.Timer Abuela;
        private System.Windows.Forms.Timer Bebe;
        private System.Windows.Forms.Timer Perro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

