using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio;
        }

        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        public abstract bool TieneFlores
        {
            get;
        }

        public abstract bool TieneFruto
        {
            get;
        }

        public virtual string ResumeDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("{0} tiene un tamao {1}", this.nombre, this.Tamanio));
            
            if(this.TieneFlores)
            sb.AppendLine(String.Format($"Tiene Flores : SI"));
            else
            sb.AppendLine(String.Format($"Tiene Flores : NO"));


            if (this.TieneFruto)
                sb.AppendLine(String.Format($"Tiene Fruto : SI"));
            else
                sb.AppendLine(String.Format($"Tiene Fruto : NO"));
            
            return sb.ToString();
        }




        /*Completar las palabras en mayúscula con los datos de cada planta según corresponda:
NOMBRE tiene un tamaño de TAMANIO
Tiene flores SI/NO
Tiene fruto SI/NO
*/

    }
}
