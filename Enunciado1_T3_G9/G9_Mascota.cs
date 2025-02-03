using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enunciado1_T3_G9
{
    class G9_Mascota
    {
        public string G9_Nombre;
        public string G9_Edad;
        public string G9_Raza;
        public string G9_Dueño;
        public G9_Mascota()
        {
        }

        public G9_Mascota(string G9_nombre, string G9_edad, string G9_raza)
        {
            this.G9_Nombre = G9_nombre;
            this.G9_Edad = G9_edad;
            this.G9_Raza = G9_raza;
        }
        public string[] getData()
        {
            string[] G9_data = new string[4];
            G9_data[0] = G9_Nombre;
            G9_data[1] = G9_Edad;
            G9_data[2] = G9_Raza;
            G9_data[3] = G9_Dueño;
            return G9_data;
        }
    }
}
