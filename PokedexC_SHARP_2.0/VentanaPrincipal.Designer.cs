namespace PokedexC_SHARP_2._0
{
    partial class VentanaPrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.izq = new System.Windows.Forms.Button();
            this.der = new System.Windows.Forms.Button();
            this.nombrePokemon = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.habitat = new System.Windows.Forms.Label();
            this.tipo1 = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.movimiento3 = new System.Windows.Forms.Label();
            this.movimiento1 = new System.Windows.Forms.Label();
            this.movimiento2 = new System.Windows.Forms.Label();
            this.habilidad = new System.Windows.Forms.Label();
            this.movimiento4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // izq
            // 
            this.izq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izq.Location = new System.Drawing.Point(12, 280);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(105, 50);
            this.izq.TabIndex = 1;
            this.izq.Text = "<";
            this.izq.UseVisualStyleBackColor = true;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // der
            // 
            this.der.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.der.Location = new System.Drawing.Point(167, 280);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(105, 50);
            this.der.TabIndex = 2;
            this.der.Text = ">";
            this.der.UseVisualStyleBackColor = true;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // nombrePokemon
            // 
            this.nombrePokemon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nombrePokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePokemon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nombrePokemon.Location = new System.Drawing.Point(92, 231);
            this.nombrePokemon.Name = "nombrePokemon";
            this.nombrePokemon.Size = new System.Drawing.Size(100, 23);
            this.nombrePokemon.TabIndex = 3;
            this.nombrePokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peso
            // 
            this.peso.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.peso.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.peso.Location = new System.Drawing.Point(355, 45);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(100, 23);
            this.peso.TabIndex = 4;
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // altura
            // 
            this.altura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.altura.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.altura.Location = new System.Drawing.Point(355, 12);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 23);
            this.altura.TabIndex = 5;
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.habitat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.habitat.Location = new System.Drawing.Point(355, 113);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(100, 23);
            this.habitat.TabIndex = 8;
            this.habitat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo1
            // 
            this.tipo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tipo1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tipo1.Location = new System.Drawing.Point(355, 180);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(100, 23);
            this.tipo1.TabIndex = 7;
            this.tipo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.especie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.especie.Location = new System.Drawing.Point(355, 79);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(100, 23);
            this.especie.TabIndex = 6;
            this.especie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo2
            // 
            this.tipo2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tipo2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tipo2.Location = new System.Drawing.Point(355, 213);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(100, 23);
            this.tipo2.TabIndex = 9;
            this.tipo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento3
            // 
            this.movimiento3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movimiento3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.movimiento3.Location = new System.Drawing.Point(523, 79);
            this.movimiento3.Name = "movimiento3";
            this.movimiento3.Size = new System.Drawing.Size(100, 23);
            this.movimiento3.TabIndex = 13;
            this.movimiento3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento1
            // 
            this.movimiento1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movimiento1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.movimiento1.Location = new System.Drawing.Point(523, 45);
            this.movimiento1.Name = "movimiento1";
            this.movimiento1.Size = new System.Drawing.Size(100, 23);
            this.movimiento1.TabIndex = 12;
            this.movimiento1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento2
            // 
            this.movimiento2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movimiento2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.movimiento2.Location = new System.Drawing.Point(629, 45);
            this.movimiento2.Name = "movimiento2";
            this.movimiento2.Size = new System.Drawing.Size(100, 23);
            this.movimiento2.TabIndex = 11;
            this.movimiento2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habilidad
            // 
            this.habilidad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.habilidad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.habilidad.Location = new System.Drawing.Point(355, 146);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(100, 23);
            this.habilidad.TabIndex = 10;
            this.habilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento4
            // 
            this.movimiento4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movimiento4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.movimiento4.Location = new System.Drawing.Point(629, 79);
            this.movimiento4.Name = "movimiento4";
            this.movimiento4.Size = new System.Drawing.Size(100, 23);
            this.movimiento4.TabIndex = 14;
            this.movimiento4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "Altura";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(278, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "Peso";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(278, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "Habitat";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 82);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(71, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Especie";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(278, 216);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(71, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Tipo 2";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(278, 183);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(71, 20);
            this.textBox6.TabIndex = 20;
            this.textBox6.Text = "Tipo 1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(278, 149);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(71, 20);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "Habilidad";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(523, 15);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(71, 20);
            this.textBox8.TabIndex = 22;
            this.textBox8.Text = "Movimientos";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.descripcion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.descripcion.Location = new System.Drawing.Point(523, 146);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(206, 90);
            this.descripcion.TabIndex = 23;
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(523, 115);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(71, 20);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "Descripción";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 50);
            this.button1.TabIndex = 25;
            this.button1.Text = "Buscador de Pokemons";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.movimiento4);
            this.Controls.Add(this.movimiento3);
            this.Controls.Add(this.movimiento1);
            this.Controls.Add(this.movimiento2);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.nombrePokemon);
            this.Controls.Add(this.der);
            this.Controls.Add(this.izq);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.Label nombrePokemon;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Label movimiento3;
        private System.Windows.Forms.Label movimiento1;
        private System.Windows.Forms.Label movimiento2;
        private System.Windows.Forms.Label habilidad;
        private System.Windows.Forms.Label movimiento4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button1;
    }
}

