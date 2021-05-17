using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo,
            Arenozo
        }

        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo;


        private Jardin()
        {
            plantas = new List<Planta>();
        }

        static Jardin() 
        {
            suelo = Tipo.Terrozo;
        }

        public Jardin(int espacioTotal) : this ()
        {
            this.espacioTotal = espacioTotal;    
        }

        public  Tipo TipoSuelo
        {
            set
            {
                suelo = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Compocisión del Jardín : {0}", Jardin.suelo));
            sb.AppendLine(string.Format("Espacio Ocupado : {0} de {1}", this.EspacioOcupado(), this.espacioTotal));
            sb.AppendLine("LISTA DE PLANTAS : ");
            sb.AppendLine("-----------------");
           
            foreach (Planta item in plantas)
            {
                sb.AppendLine(item.ResumeDeDatos());
            }

            return sb.ToString();
        }

        private int EspacioOcupado()
        {
            int acumEspacioOcupado=0;

            foreach (Planta planta in plantas)
            {
                acumEspacioOcupado += planta.Tamanio;
            }

            return acumEspacioOcupado;
        }
        private int EspacioOcupado(Planta planta)
        {
            
            return EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator + (Jardin jardin, Planta planta)
        {
            if (jardin.EspacioOcupado(planta) <= jardin.espacioTotal)
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }



    }
}
