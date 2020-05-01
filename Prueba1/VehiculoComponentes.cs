using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    abstract class VehiculoComponentes
    {
        private float _estadoComponente;

        protected VehiculoComponentes(float estadoComponente)
        {
            _estadoComponente = estadoComponente;
        }

        public float EstadoComponente { get => _estadoComponente; set => _estadoComponente = value; }
    }

}
