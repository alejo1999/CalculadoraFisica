namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sombra_izquierda = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.segunda_Ley1 = new Calculadora.Segunda_Ley();
            this.primera_Ley1 = new Calculadora.Primera_Ley();
            this.dilatacion_Tiempo1 = new Calculadora.Dilatacion_Tiempo();
            this.pitagoras1 = new Calculadora.Pitagoras();
            this.graviacion_Universal1 = new Calculadora.Graviacion_Universal();
            this.relatividad1 = new Calculadora.Relatividad();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(239)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 5);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.sombra_izquierda);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 614);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 569);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sombra_izquierda
            // 
            this.sombra_izquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(186)))), ((int)(((byte)(239)))));
            this.sombra_izquierda.Location = new System.Drawing.Point(2, 71);
            this.sombra_izquierda.Name = "sombra_izquierda";
            this.sombra_izquierda.Size = new System.Drawing.Size(8, 56);
            this.sombra_izquierda.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(10, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 56);
            this.button6.TabIndex = 3;
            this.button6.Text = "Segunda Ley de Newton";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(10, 319);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 56);
            this.button5.TabIndex = 3;
            this.button5.Text = "Primera Ley de Newton";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(10, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 56);
            this.button4.TabIndex = 3;
            this.button4.Text = "Dilatacion del tiempo por velocidad";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(10, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 56);
            this.button3.TabIndex = 3;
            this.button3.Text = "Teorema de Pitágoras";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ley de gravitación Universal de Newton";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "T. de la Relatividad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(41)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.button7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 32);
            this.panel3.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1064, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(32, 25);
            this.button7.TabIndex = 3;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // segunda_Ley1
            // 
            this.segunda_Ley1.BackColor = System.Drawing.Color.CadetBlue;
            this.segunda_Ley1.Location = new System.Drawing.Point(715, 356);
            this.segunda_Ley1.Name = "segunda_Ley1";
            this.segunda_Ley1.Size = new System.Drawing.Size(387, 126);
            this.segunda_Ley1.TabIndex = 8;
            // 
            // primera_Ley1
            // 
            this.primera_Ley1.BackColor = System.Drawing.Color.CadetBlue;
            this.primera_Ley1.Location = new System.Drawing.Point(342, 505);
            this.primera_Ley1.Name = "primera_Ley1";
            this.primera_Ley1.Size = new System.Drawing.Size(492, 109);
            this.primera_Ley1.TabIndex = 7;
            // 
            // dilatacion_Tiempo1
            // 
            this.dilatacion_Tiempo1.BackColor = System.Drawing.Color.CadetBlue;
            this.dilatacion_Tiempo1.Location = new System.Drawing.Point(277, 388);
            this.dilatacion_Tiempo1.Name = "dilatacion_Tiempo1";
            this.dilatacion_Tiempo1.Size = new System.Drawing.Size(430, 111);
            this.dilatacion_Tiempo1.TabIndex = 6;
            // 
            // pitagoras1
            // 
            this.pitagoras1.BackColor = System.Drawing.Color.CadetBlue;
            this.pitagoras1.Location = new System.Drawing.Point(246, 268);
            this.pitagoras1.Name = "pitagoras1";
            this.pitagoras1.Size = new System.Drawing.Size(442, 114);
            this.pitagoras1.TabIndex = 5;
            // 
            // graviacion_Universal1
            // 
            this.graviacion_Universal1.BackColor = System.Drawing.Color.CadetBlue;
            this.graviacion_Universal1.Location = new System.Drawing.Point(312, 138);
            this.graviacion_Universal1.Name = "graviacion_Universal1";
            this.graviacion_Universal1.Size = new System.Drawing.Size(468, 124);
            this.graviacion_Universal1.TabIndex = 4;
            // 
            // relatividad1
            // 
            this.relatividad1.BackColor = System.Drawing.Color.Chocolate;
            this.relatividad1.Location = new System.Drawing.Point(249, 43);
            this.relatividad1.Name = "relatividad1";
            this.relatividad1.Size = new System.Drawing.Size(688, 105);
            this.relatividad1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 638);
            this.Controls.Add(this.segunda_Ley1);
            this.Controls.Add(this.primera_Ley1);
            this.Controls.Add(this.dilatacion_Tiempo1);
            this.Controls.Add(this.pitagoras1);
            this.Controls.Add(this.graviacion_Universal1);
            this.Controls.Add(this.relatividad1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sombra_izquierda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        private Relatividad relatividad1;
        private Graviacion_Universal graviacion_Universal1;
        private Pitagoras pitagoras1;
        private Dilatacion_Tiempo dilatacion_Tiempo1;
        private Primera_Ley primera_Ley1;
        private Segunda_Ley segunda_Ley1;
    }
}

