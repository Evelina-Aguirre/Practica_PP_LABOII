using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evelina.Aguirre._2D.PP2020_Receta
{
    public class Receta
    {
        public enum Tipo
        {
            Clasica,
            Especial
        }

        private int capacidadDelContenedor;
        List<Ingrediente> ingredientes;
        private static Tipo preparacion;

        public Tipo TipoDePreparacion
        {
            set
            {
                preparacion = value;
            }

        }

        public Receta()
        {
            ingredientes = new List<Ingrediente>();
        }
        static Receta()
        {
            preparacion = Tipo.Clasica;
        }
        public Receta(int capacidad) : this()
        {
            this.capacidadDelContenedor = capacidad;
        }

        public int capacidadLibre()
        {
            int aux=0;
            foreach (Ingrediente item in ingredientes)
            {
                aux += item.Cantidad;
            }

            if (this.capacidadDelContenedor >= aux)
                return this.capacidadDelContenedor - aux;
            else
                return 0;

        }
        public int capacidadLibre(Ingrediente ingrediente)
        {
            
            return this.capacidadLibre() - ingrediente.Cantidad;
        }

        public static bool operator + (Receta receta, Ingrediente ingrediente)
        {
            if(receta.capacidadDelContenedor >= receta.capacidadLibre())
            {
                receta.ingredientes.Add(ingrediente);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine((String.Format("Receta: {0}", Receta.preparacion)));
            sb.AppendLine((String.Format("Capacidad libre: {0}", this.capacidadLibre())));
            sb.AppendLine((String.Format("Capacidad total: {0}", this.capacidadDelContenedor)));
            sb.AppendLine("LISTA DE INGREDIENTES: " );
            foreach (Ingrediente item in ingredientes)
            {
                sb.AppendLine((String.Format("{0}", item.Informacion())));
                sb.AppendLine("-------------------------");
            }

            return sb.ToString();
        }

        /*Receta: CLASICA/ESPECIAL
Capacidad libre XXX
Capacidad total XXX
LISTA DE INGREDIENTES*/
    }
}
