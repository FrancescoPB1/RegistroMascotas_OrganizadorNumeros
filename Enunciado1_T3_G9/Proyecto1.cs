using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado1_T3_G9
{
    
    public partial class Proyecto1 : Form
    {
        public Proyecto1()
        {
            InitializeComponent();
        }
        //Creamos la lista para los dueños de las mascotas
        List<G9_Dueño> listG9_Dueño = new List<G9_Dueño>();
        private void btn_registrardueño_Click(object sender, EventArgs e)
        {
            txt_listadueños.ReadOnly = true;
            try
            {
                //Si no se ingresan los datos del dueño, se pedirá que los ingrese
                if (string.IsNullOrWhiteSpace(txt_nombredueño.Text) || string.IsNullOrWhiteSpace(txt_direccion.Text) || string.IsNullOrWhiteSpace(txt_telefono.Text))
                {
                    throw new Exception("Por favor, ingresa todos los valores requeridos.");
                }
                //Realiza el registro del dueño de la mascota
                G9_Dueño G9_nuevoDueño = new G9_Dueño { Nombre = txt_nombredueño.Text, Dirección = txt_direccion.Text, Teléfono = txt_telefono.Text };
                if (!listG9_Dueño.Any(d => d.Nombre == G9_nuevoDueño.Nombre && d.Dirección == G9_nuevoDueño.Dirección && d.Teléfono == G9_nuevoDueño.Teléfono))
                {
                    listG9_Dueño.Add(G9_nuevoDueño);
                    txt_listadueños.Clear();
                    txt_listadueños.Text += "       NOMBRE      " + "       TELEFONO       " + "       DIRECCION    " + "\r\n";
                    foreach (G9_Dueño G9_p in listG9_Dueño)
                    {
                        txt_listadueños.Text += G9_p.Nombre + "             -      " + G9_p.Teléfono + "            -    " + G9_p.Dirección + "         \r\n";
                        G9_Persona = G9_p.Nombre + " - " + G9_p.Teléfono; //Se almacena el nombre y celular del dueño dentro de la variable
                    }
                    txt_nombredueño.Text = "";
                    txt_direccion.Text = "";
                    txt_telefono.Text = "";
                }
                // Verifica si el dueño ya existe en la lista
                else
                {
                    throw new Exception("El dueño ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        string G9_Persona; //Variable creada para almacenar el nombre y celular del dueño
        string G9_M; //Variable creada para almacenar los datos de la mascota a registrar
        
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se llama a la variable G9_Persona para que muestre los datos ingresados dentro del combobox
                if (!cmb_dueño.Items.Contains(G9_Persona))
                cmb_dueño.Items.Add(G9_Persona);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Primero registre al dueño de la mascota."+ex.Message);
            }
        }
        //Creamos la lista para las mascotas
        List<G9_Mascota> listG9_Mascota = new List<G9_Mascota>(); 
        private void Proyecto1_Load(object sender, EventArgs e)
        {
            //Ajustamos el tamaño del formulario para una mejor visibilidad del usuario
            Size = new Size(1000, 500);
            //Configuramos los nombres de las columnas del datagridview
            dgv_Mascota.Columns.Add("Name", "Nombre");
            dgv_Mascota.Columns.Add("Age", "Edad");
            dgv_Mascota.Columns.Add("Race", "Raza");
            dgv_Mascota.Columns.Add("Owner", "Dueño");
            dgv_Mascota.Rows.Clear();
        }
        public void btn_registrarmascota_Click(object sender, EventArgs e)
        {
            try
            {
                //Si no se ingresa ningún valor en los textbox le pedirá que ingrese los que se indican.
                if (string.IsNullOrWhiteSpace(txt_nombremascota.Text) || string.IsNullOrWhiteSpace(txt_edad.Text) || string.IsNullOrWhiteSpace(txt_raza.Text) || string.IsNullOrWhiteSpace(cmb_dueño.Text))
                {
                    throw new Exception("Por favor, ingresa todos los valores requeridos.");
                }
                //Realiza el registro de la mascota en la lista
                G9_Mascota G9_nuevaMascota = new G9_Mascota();
                G9_nuevaMascota.G9_Nombre = txt_nombremascota.Text;
                G9_nuevaMascota.G9_Edad = txt_edad.Text;
                G9_nuevaMascota.G9_Raza = txt_raza.Text;
                G9_nuevaMascota.G9_Dueño = cmb_dueño.Text;

                // Verifica si la mascota ya existe en la lista
                if (!listG9_Mascota.Any(m => m.G9_Nombre == G9_nuevaMascota.G9_Nombre && m.G9_Edad == G9_nuevaMascota.G9_Edad && m.G9_Raza == G9_nuevaMascota.G9_Raza && m.G9_Dueño == G9_nuevaMascota.G9_Dueño))
                {
                    listG9_Mascota.Add(G9_nuevaMascota);
                    G9_M = G9_nuevaMascota.G9_Nombre; //Se almacena el nombre de la mascota en la variable G9_M
                    txt_nombremascota.Text = "";
                    txt_edad.Text = "";
                    txt_raza.Text = "";
                    cmb_dueño.Text = "";
                    MostrarLista();
                }
                else
                {
                    throw new Exception("La mascota ya existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        //Muestra los datos ingresados en el datagridview
        private void MostrarLista()
        {
            dgv_Mascota.Rows.Clear();
            foreach (G9_Mascota item in listG9_Mascota)
            {
                dgv_Mascota.Rows.Add(item.getData());
            }
        }
        //Se encarga de realizar la búsqueda de la mascota registrada
        public void btn_buscar_Click(object sender, EventArgs e)
        {
            Boolean G9_Encontrado = false;
            if (txt_buscarmascota.Text != " ")
            {
                //Realiza la búsqueda de la mascota
                foreach (G9_Mascota item in listG9_Mascota)
                {
                    //Se llama a la variable G9_M para mostrar si la mascota fue registrada
                    if (G9_M.IndexOf(txt_buscarmascota.Text) == 0 )
                    {
                        string G9_ValorEncontrado = string.Format("Mascota encontrada: "+ G9_M);
                        MessageBox.Show(G9_ValorEncontrado);
                        G9_Encontrado = true;
                    }
                }
            }
            //Si se ingresa datos de una mascota que no esta registrada, saldrá el mensaje indicándolo
            if (G9_Encontrado == false) MessageBox.Show("Mascota NO Encontrada");
        }
    }
}
