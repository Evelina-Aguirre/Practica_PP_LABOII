using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicación
{
    public abstract class Publicacion
    {
        #region Atributos

        protected float importe;
        protected string nombre;
        protected int stock;

        #endregion

        protected abstract bool EsColor
        {
            get;
        }

        public virtual bool HayStock //Virtual porque solo lo utiliza en una de sus derivadas
        {
            get 
            { 
                if(Stock > 0 && Importe >0) //En mayúscula, hace referencia a la propiedad
                {
                return true;
                }
            return false;
            }
        }

        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if(value >= 0)
                this.stock = value;
            }
        }

        #region Constructores 

        public Publicacion (string nombre)
        {
            this.nombre=nombre;
        }

        public Publicacion(string nombre, int stock):this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe):this(nombre,stock)
        {
            this.importe = importe;

        }

        #endregion

        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre : {0}\n", this.nombre);
            sb.AppendLine(string.Format("Stock : {0}", this.stock));
            if(EsColor)
            {
                sb.Append($"Color: Si\n");
            }
            else
            {
                sb.Append($"Color: No\n");
            }
            sb.AppendLine($"Importe : { this.importe}");

            return sb.ToString();
           
        }

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
