using System;
using System.Collections;
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
    public partial class Proyecto2 : Form
    {
        public Proyecto2()
        {
            InitializeComponent();
        }
        //Se crea la lista donde serán almacenados los números (list_num)
        List<int> list_num = new List<int>();
        private void Proyecto2_Load(object sender, EventArgs e)
        {
            //Se ajusta el tamaño del formulario
            Size = new Size(500, 600);
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                int G9_A; //Se crea la variable donde se almacerá el número que el usuario desea agregar a la lista
                G9_A = int.Parse(txt_agregar.Text);//Convierte el dato ingresado a un número entero
                //Si el número ya existe, aparecerá que ya fue registrado en la lista
                if (list_num.Contains(G9_A))
                {
                    MessageBox.Show("El número ya existe en la lista.");
                }
                //Si el número no existe, se agrega a la lista
                else
                {
                    list_num.Add(G9_A);
                    txt_agregar.Clear();
                    txt_agregar.Focus();
                }
            }
            //Si el usuario ingresa algún dato que no sea un número, le mostrará un mensaje que ingrese solo números
            catch(FormatException)
            {
                MessageBox.Show("Ingresa solo numeros");
            }
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int G9_N; //Se crea la variable para que almacene el número que el usuario desea eliminar
            G9_N = int.Parse(txt_eliminar.Text); //Convierte el dato que ingresa el usuario a un número entero
            list_num.Remove(G9_N);
            txt_eliminar.Clear();
            txt_eliminar.Focus();
        }
        private void btn_ascendente_Click(object sender, EventArgs e)
        {
            try
            {
                if (list_num.Count == 0)
                {
                    throw new InvalidOperationException("Primero ingresa números a la lista.");
                }
                
                list_num.Sort();
                foreach (int G9_i in list_num)
                {
                    Console.WriteLine(G9_i);
                }
            }
            
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            int G9_i;
            listbox.Items.Clear();
            for (G9_i = 0; G9_i <= list_num.Count - 1; G9_i++)
            {
                listbox.Items.Add(list_num.ElementAt(G9_i));
            }
        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            int G9_numerobus;
            try
            {
                G9_numerobus=int.Parse(txt_buscar.Text);

                    // Busca el número en la lista
                    bool G9_encontrado = list_num.Contains(G9_numerobus);

                    if (G9_encontrado)
                    {
                        MessageBox.Show("Número encontrado: " + G9_numerobus);
                        txt_buscar.Clear();
                        txt_buscar.Focus();
                    }
                    else
                    {
                    MessageBox.Show("Numero no encontrado");
                    txt_buscar.Clear();
                    txt_buscar.Focus();
                    }      
            }
            catch(FormatException) 
            {
                MessageBox.Show("Ingresa un numero para hacer la busqueda...");
                txt_buscar.Clear();
                txt_buscar.Focus();
            }   
        }
        private void btn_descendente_Click(object sender, EventArgs e)
        {
            try
            {
                //Se verifica si se ingresó un número a la lista
                if (list_num.Count == 0)
                {
                    //Mensaje que le aparecerá al usuario si no hay números registrados
                    throw new InvalidOperationException("Primero ingresa números a la lista.");
                }
                //Ordena de forma ascendente la lista para luego invertirlo y ponerlo en forma descendente
                list_num.Sort();
                list_num.Reverse();
            }
            //Lanza el mensaje de error
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
