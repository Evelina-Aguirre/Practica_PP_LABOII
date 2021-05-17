using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicación
{
    public class Biografia : Publicacion
    {
        #region Propiedades
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        public override bool HayStock
        {
            get
            {
                if (this.stock > 0)
                    return true;
                else
                    return false;
            }

        }
        #endregion

        #region Constructores

        public Biografia(string nombre) :base (nombre)
        {
            
        }

        public Biografia(string nombre, int stock) : base(nombre,stock)
        {
            
        }

        public Biografia(string nombre, int stock, float importe) : base(nombre, stock, importe)
        {
            

        }
        #endregion

        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);

        }








    }
}
