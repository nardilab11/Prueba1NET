using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    abstract class Vehiculo
    {
        private Estanque _estanque;
        private Mezclador _mezclador;
        private Motor _motor;
        private ArrayList _ruedas;

        protected Vehiculo(Estanque estanque, Mezclador mezclador, Motor motor, ArrayList ruedas)
        {
            _estanque = estanque;
            _mezclador = mezclador;
            _motor = motor;
            _ruedas = ruedas;
        }

        public ArrayList Ruedas { get => _ruedas; set => _ruedas = value; }
        internal Estanque Estanque { get => _estanque; set => _estanque = value; }
        internal Mezclador Mezclador { get => _mezclador; set => _mezclador = value; }
        internal Motor Motor { get => _motor; set => _motor = value; }
    }
}
