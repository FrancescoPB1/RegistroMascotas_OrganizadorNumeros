namespace Enunciado1_T3_G9
{
    partial class INICIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INICIO));
            this.btn_Proyect1 = new System.Windows.Forms.Button();
            this.btn_Proyect2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Proyect1
            // 
            this.btn_Proyect1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Proyect1.Location = new System.Drawing.Point(212, 508);
            this.btn_Proyect1.Name = "btn_Proyect1";
            this.btn_Proyect1.Size = new System.Drawing.Size(252, 107);
            this.btn_Proyect1.TabIndex = 0;
            this.btn_Proyect1.Text = "PROYECTO 1";
            this.btn_Proyect1.UseVisualStyleBackColor = false;
            this.btn_Proyect1.Click += new System.EventHandler(this.btn_Proyect1_Click);
            // 
            // btn_Proyect2
            // 
            this.btn_Proyect2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Proyect2.Location = new System.Drawing.Point(796, 505);
            this.btn_Proyect2.Name = "btn_Proyect2";
            this.btn_Proyect2.Size = new System.Drawing.Size(276, 107);
            this.btn_Proyect2.TabIndex = 1;
            this.btn_Proyect2.Text = "PROYECTO 2";
            this.btn_Proyect2.UseVisualStyleBackColor = false;
            this.btn_Proyect2.Click += new System.EventHandler(this.btn_Proyect2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(994, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Proyectos del Grupo 9 para T3 de FP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(65, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1113, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bienvenido, porfavor haz clic sobre uno de los botones para dirigirte a uno de lo" +
    "s proyectos mostrados.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 649);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(396, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Registro de mascotas con su dueño";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 649);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Registro de números";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(735, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 199);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 776);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Proyect2);
            this.Controls.Add(this.btn_Proyect1);
            this.Name = "INICIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Proyect1;
        private System.Windows.Forms.Button btn_Proyect2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

