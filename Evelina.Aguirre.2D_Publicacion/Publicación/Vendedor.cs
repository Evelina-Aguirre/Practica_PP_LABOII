using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publicación
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }

        public Vendedor(string nombre) : this()
        {
            this.nombre = nombre;
        }



        public static bool operator +(Vendedor v, Publicacion p)
        {
            if (!(v is null) && !(p is null)) {
                if (p.HayStock)
                {
                    p.Stock--;
                    v.ventas.Add(p);
                    return true;
                }
            }
            return false;

        }
       
        

        public static string InformeDeVentas(Vendedor v)
        {
            double ganancia=0;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{v.nombre}");
            sb.AppendLine("--------------------------------------");

            foreach (Publicacion x in v.ventas)
            {
                sb.AppendLine(x.Informacion());
                ganancia = ganancia + x.Importe;
                sb.AppendLine("--------------------------------------");

            }
            sb.AppendLine($"Ganancia total : $ {ganancia}");


            return sb.ToString();
        }
    
    }
}
