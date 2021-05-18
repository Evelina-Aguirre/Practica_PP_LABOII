using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evelina.Aguirre._2D.PP2020_Receta
{
    public abstract class Ingrediente
    {
        private int cantidad;
        private string descripcion;

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }


        public abstract string Proceso
        {
            get;
        }
        public abstract string UnidadDeMedida
        {
            get;
        }

        public Ingrediente(string descripcion, int cantidad)
        {
            this.descripcion = descripcion;
            this.cantidad = cantidad;
        }
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((String.Format("{0} en una cantidad de {1}", this.descripcion, this.UnidadDeMedida)));
            sb.AppendLine((String.Format("Pocesar : {0}", this.Proceso)));

            return sb.ToString();

        }
    }
  
}
