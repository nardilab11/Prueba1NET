using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    class Motor : VehiculoComponentes
    {
        private string _id;
        private string _tipo;
        private float _cilindrada;
        private string _tiempos;

        public Motor(float estadoComponente, string id, string tipo, float cilindrada, string tiempos) : base(estadoComponente)
        {
            _id = id;
            _tipo = tipo;
            _cilindrada = cilindrada;
            _tiempos = tiempos;
        }

        public string Id { get => _id; set => _id = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public float Cilindrada { get => _cilindrada; set => _cilindrada = value; }
        public string Tiempos { get => _tiempos; set => _tiempos = value; }
    }
}
