namespace Enunciado1_T3_G9
{
    partial class Proyecto2
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
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.txt_eliminar = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.txt_agregar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_descendente = new System.Windows.Forms.Button();
            this.btn_ascendente = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.listbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(73, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeros en Lista";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_mostrar);
            this.groupBox1.Controls.Add(this.btn_eliminar);
            this.groupBox1.Controls.Add(this.txt_eliminar);
            this.groupBox1.Controls.Add(this.btn_agregar);
            this.groupBox1.Controls.Add(this.txt_agregar);
            this.groupBox1.Location = new System.Drawing.Point(69, 660);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 320);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar o eliminar numero";
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(87, 245);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(315, 51);
            this.btn_mostrar.TabIndex = 4;
            this.btn_mostrar.Text = "ACTUALIZAR LISTA";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(302, 170);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(164, 52);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_eliminar
            // 
            this.txt_eliminar.Location = new System.Drawing.Point(42, 180);
            this.txt_eliminar.Name = "txt_eliminar";
            this.txt_eliminar.Size = new System.Drawing.Size(218, 35);
            this.txt_eliminar.TabIndex = 2;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(302, 62);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(164, 52);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // txt_agregar
            // 
            this.txt_agregar.Location = new System.Drawing.Point(42, 71);
            this.txt_agregar.Name = "txt_agregar";
            this.txt_agregar.Size = new System.Drawing.Size(218, 35);
            this.txt_agregar.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_descendente);
            this.groupBox2.Controls.Add(this.btn_ascendente);
            this.groupBox2.Location = new System.Drawing.Point(608, 713);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(499, 267);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenar numeros";
            // 
            // btn_descendente
            // 
            this.btn_descendente.Location = new System.Drawing.Point(142, 149);
            this.btn_descendente.Name = "btn_descendente";
            this.btn_descendente.Size = new System.Drawing.Size(215, 94);
            this.btn_descendente.TabIndex = 1;
            this.btn_descendente.Text = "FORMA DESCENDENTE";
            this.btn_descendente.UseVisualStyleBackColor = true;
            this.btn_descendente.Click += new System.EventHandler(this.btn_descendente_Click);
            // 
            // btn_ascendente
            // 
            this.btn_ascendente.Location = new System.Drawing.Point(142, 35);
            this.btn_ascendente.Name = "btn_ascendente";
            this.btn_ascendente.Size = new System.Drawing.Size(215, 91);
            this.btn_ascendente.TabIndex = 0;
            this.btn_ascendente.Text = "FORMA ASCENDENTE";
            this.btn_ascendente.UseVisualStyleBackColor = true;
            this.btn_ascendente.Click += new System.EventHandler(this.btn_ascendente_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_buscar);
            this.groupBox3.Controls.Add(this.txt_buscar);
            this.groupBox3.Location = new System.Drawing.Point(394, 1017);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 162);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar numero";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(242, 51);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(147, 64);
            this.btn_buscar.TabIndex = 1;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(32, 66);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(159, 35);
            this.txt_buscar.TabIndex = 0;
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 29;
            this.listbox.Location = new System.Drawing.Point(311, 179);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(502, 439);
            this.listbox.TabIndex = 5;
            // 
            // Proyecto2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 1241);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Proyecto2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto2";
            this.Load += new System.EventHandler(this.Proyecto2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.TextBox txt_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_agregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_descendente;
        private System.Windows.Forms.Button btn_ascendente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button btn_mostrar;
    }
}