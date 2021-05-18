using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Campo
    {
        public enum Tipo
        {
            Pastoreo,
            Engorde
        }
        private int alimentoDisponilble;
        private List<Animal> animales;
        private static Tipo servicio;

        public static Tipo TipoServicio
        {
            set
            {
                Campo.servicio = value;
            }
        }

        static Campo()
        {
            servicio = Tipo.Engorde;
        }
        private Campo()
        {
            animales = new List<Animal>();

        }

        public Campo(int alimento):this()
        {
            this.alimentoDisponilble = alimento;
        }

        private int AlimentoCompormetido()
        {
            int auxAcum = 0;

            foreach (Animal miAnimal in animales)
            {
                auxAcum += miAnimal.KilosAlimento;
            }
            return auxAcum;
        }

        private int AlimentoCompormetido(Animal animal)
        {
            return this.AlimentoCompormetido() + animal.KilosAlimento;
        }

        public static bool operator + (Campo campo, Animal animal)
        {
            if(campo.alimentoDisponilble >= campo.AlimentoCompormetido(animal))
            {
                campo.animales.Add(animal);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("Servicio del campo: PASTOREO/ENGORDE {0}", Campo.servicio));
            sb.AppendLine(String.Format("Alimento comprometido{0}", this.AlimentoCompormetido()));
            sb.AppendLine("LISTA DE ANIMALES:");
            sb.AppendLine("-----------------\n");
            foreach (Animal animalesEnCampo in animales)
            {
                sb.AppendLine(String.Format("{0}", animalesEnCampo.Datos()));
            }
            

            return sb.ToString();
        }

       

    }
}
