using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeSistemaDeRefrescos
{
    public class Refresco : Componente
    {
        int _cantidad;
        public Refresco(string nombre, int cantidad) : base(nombre)
            //utilizamos el constructor de componente
        {
            _cantidad = cantidad;
        }
        public int Cantidad { get { return _cantidad; } }
        public override void AgregarHijo(Componente c)
        {
        }

        public override IList<Componente> ObtenerHijos()
        {
            return null;
        }

        public override int ObtenerCantidad
        {
            get
            {
                return _cantidad;
            }
        }
    }
}

