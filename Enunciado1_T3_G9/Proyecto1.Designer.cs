namespace Enunciado1_T3_G9
{
    partial class Proyecto1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_nombredueño = new System.Windows.Forms.TextBox();
            this.btn_registrardueño = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_registrarmascota = new System.Windows.Forms.Button();
            this.txt_raza = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_nombremascota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_dueño = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_listadueños = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_Mascota = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscarmascota = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascota)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(759, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de mascotas y dueños";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_nombredueño);
            this.groupBox1.Controls.Add(this.btn_registrardueño);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(96, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 359);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dueños de mascotas";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(222, 186);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(242, 35);
            this.txt_direccion.TabIndex = 6;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(222, 123);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(242, 35);
            this.txt_telefono.TabIndex = 5;
            // 
            // txt_nombredueño
            // 
            this.txt_nombredueño.Location = new System.Drawing.Point(222, 61);
            this.txt_nombredueño.Name = "txt_nombredueño";
            this.txt_nombredueño.Size = new System.Drawing.Size(242, 35);
            this.txt_nombredueño.TabIndex = 4;
            // 
            // btn_registrardueño
            // 
            this.btn_registrardueño.Location = new System.Drawing.Point(169, 257);
            this.btn_registrardueño.Name = "btn_registrardueño";
            this.btn_registrardueño.Size = new System.Drawing.Size(157, 67);
            this.btn_registrardueño.TabIndex = 3;
            this.btn_registrardueño.Text = "Registrar";
            this.btn_registrardueño.UseVisualStyleBackColor = true;
            this.btn_registrardueño.Click += new System.EventHandler(this.btn_registrardueño_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_actualizar);
            this.groupBox2.Controls.Add(this.btn_registrarmascota);
            this.groupBox2.Controls.Add(this.txt_raza);
            this.groupBox2.Controls.Add(this.txt_edad);
            this.groupBox2.Controls.Add(this.txt_nombremascota);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmb_dueño);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(1123, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(639, 359);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mascotas";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(487, 217);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(133, 54);
            this.btn_actualizar.TabIndex = 12;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_registrarmascota
            // 
            this.btn_registrarmascota.Location = new System.Drawing.Point(216, 286);
            this.btn_registrarmascota.Name = "btn_registrarmascota";
            this.btn_registrarmascota.Size = new System.Drawing.Size(169, 51);
            this.btn_registrarmascota.TabIndex = 11;
            this.btn_registrarmascota.Text = "Registrar";
            this.btn_registrarmascota.UseVisualStyleBackColor = true;
            this.btn_registrarmascota.Click += new System.EventHandler(this.btn_registrarmascota_Click);
            // 
            // txt_raza
            // 
            this.txt_raza.Location = new System.Drawing.Point(186, 168);
            this.txt_raza.Name = "txt_raza";
            this.txt_raza.Size = new System.Drawing.Size(291, 35);
            this.txt_raza.TabIndex = 10;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(186, 105);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(291, 35);
            this.txt_edad.TabIndex = 10;
            // 
            // txt_nombremascota
            // 
            this.txt_nombremascota.Location = new System.Drawing.Point(186, 46);
            this.txt_nombremascota.Name = "txt_nombremascota";
            this.txt_nombremascota.Size = new System.Drawing.Size(291, 35);
            this.txt_nombremascota.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "Dueño";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 29);
            this.label8.TabIndex = 7;
            this.label8.Text = "Raza";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Edad";
            // 
            // cmb_dueño
            // 
            this.cmb_dueño.FormattingEnabled = true;
            this.cmb_dueño.Location = new System.Drawing.Point(169, 227);
            this.cmb_dueño.Name = "cmb_dueño";
            this.cmb_dueño.Size = new System.Drawing.Size(291, 37);
            this.cmb_dueño.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nombre";
            // 
            // txt_listadueños
            // 
            this.txt_listadueños.Location = new System.Drawing.Point(32, 76);
            this.txt_listadueños.Multiline = true;
            this.txt_listadueños.Name = "txt_listadueños";
            this.txt_listadueños.Size = new System.Drawing.Size(798, 334);
            this.txt_listadueños.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_listadueños);
            this.groupBox3.Location = new System.Drawing.Point(35, 541);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(894, 436);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dueños registrados";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_Mascota);
            this.groupBox4.Location = new System.Drawing.Point(965, 541);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1231, 418);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mascotas Registradas";
            // 
            // dgv_Mascota
            // 
            this.dgv_Mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mascota.Location = new System.Drawing.Point(21, 70);
            this.dgv_Mascota.Name = "dgv_Mascota";
            this.dgv_Mascota.RowHeadersWidth = 102;
            this.dgv_Mascota.RowTemplate.Height = 40;
            this.dgv_Mascota.Size = new System.Drawing.Size(1205, 315);
            this.dgv_Mascota.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_buscar);
            this.groupBox5.Controls.Add(this.txt_buscarmascota);
            this.groupBox5.Location = new System.Drawing.Point(1828, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(293, 303);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar mascota";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(55, 173);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(172, 51);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscarmascota
            // 
            this.txt_buscarmascota.Location = new System.Drawing.Point(44, 85);
            this.txt_buscarmascota.Name = "txt_buscarmascota";
            this.txt_buscarmascota.Size = new System.Drawing.Size(196, 35);
            this.txt_buscarmascota.TabIndex = 0;
            // 
            // Proyecto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2278, 1068);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Proyecto1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto1";
            this.Load += new System.EventHandler(this.Proyecto1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mascota)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_nombredueño;
        private System.Windows.Forms.Button btn_registrardueño;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.ComboBox cmb_dueño;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_raza;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_nombremascota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_listadueños;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_registrarmascota;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridView dgv_Mascota;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscarmascota;
    }
}