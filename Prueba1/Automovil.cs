using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    class Automovil : Vehiculo
    {
        private string _marca;
        private int _ano;
        private float _kilometraje;

        public Automovil(Estanque estanque, Mezclador mezclador, Motor motor, ArrayList ruedas, string marca, int ano, float kilometraje) : base(estanque, mezclador, motor, ruedas)
        {
            _marca = marca;
            _ano = ano;
            _kilometraje = kilometraje;
        }

        public string Marca { get => _marca; set => _marca = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public float Kilometraje { get => _kilometraje; set => _kilometraje = value; }
    }
}
