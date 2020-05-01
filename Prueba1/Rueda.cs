using System;
using System.Collections.Generic;
using System.Text;

namespace Prueba1
{
    class Rueda : VehiculoComponentes
    {
        private string _recubrimiento;
        private int _minDurometro;
        private int _maxDurometro;

        public Rueda(float estadoComponente, string recubrimiento, int primerDurometro, int segundoDurometro) : base(estadoComponente)
        {
            _recubrimiento = recubrimiento;
            if (primerDurometro >= segundoDurometro)
            {
                _minDurometro = segundoDurometro;
                _maxDurometro = primerDurometro;
            }
            else
            {
                _minDurometro = primerDurometro;
                _maxDurometro = segundoDurometro;
            }
        }

        public string Recubrimiento { get => _recubrimiento; set => _recubrimiento = value; }
        public int MinDurometro { get => _minDurometro; set => _minDurometro = value; }
        public int MaxDurometro { get => _maxDurometro; set => _maxDurometro = value; }

    }
}
