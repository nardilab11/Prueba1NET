using System;
using System.Collections;
using System.IO;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Bienvenido a la aplicación\n-Ingreso de Vehículos-");
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Usuario: admin");
            Console.Write("Ingrese la contraseña: ");
            try 
            {
            string contraseña = Console.ReadLine();
            while (!contraseña.Equals("abc123"))
            {
                Console.Write("Contraseña incorrecta. Ingrese la contraseña otra vez: ");
                contraseña = Console.ReadLine();
            }
            Console.WriteLine("Inicio de sesión exitoso.");
            ArrayList vehiculos = new ArrayList();
            int opc = 0;
            
                do
                {
                    Console.WriteLine("\n1. Ingreso de vehículos.");
                    Console.WriteLine("2. Listado de vehículos.");
                    Console.WriteLine("0. Salir.");
                    Console.Write("Ingrese una opción: ");
                    opc = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------------------------");
                    switch (opc)
                    {
                        case 1:
                            Automovil a;
                            Estanque e;
                            Mezclador me;
                            Motor mo;
                            ArrayList ruedas = new ArrayList();
                            Console.WriteLine("Nota: Para valores decimales, separarlos con una coma, no con punto.");

                            //Creación estanque
                            Console.WriteLine("--------------------------------");
                            Console.Write("Ingrese el estado del estanque (0,0 a 100,0): ");
                            float estadoE = float.Parse(Console.ReadLine());
                            while(estadoE < 0.0f | estadoE > 100.0f)
                            {
                                Console.Write("Valor incorrecto. Ingrese el estado del estanque (0,0 a 100,0): ");
                                estadoE = float.Parse(Console.ReadLine());
                            }
                            Console.Write("Ingrese la capacidad del estanque: ");
                            float capacidadE = float.Parse(Console.ReadLine());
                            Console.Write("Ingrese los litros del estanque: ");
                            float litrosE = float.Parse(Console.ReadLine());
                            Console.WriteLine("--------------------------------");
                            e = new Estanque(estadoE, capacidadE, litrosE);

                            //Creación mezclador
                            Console.WriteLine("--------------------------------");
                            Console.Write("Ingrese el estado del mezclador (0,0 a 100,0): ");
                            float estadoMe = float.Parse(Console.ReadLine());
                            while (estadoMe < 0.0f | estadoMe > 100.0f)
                            {
                                Console.Write("Valor incorrecto. Ingrese el estado del mezclador (0,0 a 100,0): ");
                                estadoMe = float.Parse(Console.ReadLine());
                            }
                            Console.Write("Ingrese el tipo del mezclador (CARBURADOR o INYECTOR): ");
                            string tipoMe = Console.ReadLine();
                            while(!(tipoMe.Equals("CARBURADOR") | tipoMe.Equals("INYECTOR")))
                            {
                                Console.Write("Valor incorrecto. Ingrese exactamente como se muestra (CARBURADOR o INYECTOR): ");
                                tipoMe = Console.ReadLine();
                            }
                            Console.WriteLine("--------------------------------");
                            me = new Mezclador(estadoMe, tipoMe);

                            //Creación motor
                            Console.WriteLine("--------------------------------");
                            Console.Write("Ingrese el estado del motor (0,0 a 100,0): ");
                            float estadoMo = float.Parse(Console.ReadLine());
                            while (estadoMo < 0.0f | estadoMo > 100.0f)
                            {
                                Console.Write("Valor incorrecto. Ingrese el estado del motor (0,0 a 100,0): ");
                                estadoMo = float.Parse(Console.ReadLine());
                            }
                            Console.Write("Ingrese el ID del motor: ");
                            string idMo = Console.ReadLine();
                            Console.Write("Ingrese el tipo del motor: ");
                            string tipoMo = Console.ReadLine();
                            Console.Write("Ingrese la cilindrada del motor: ");
                            float cilindradaMo = float.Parse(Console.ReadLine());
                            Console.Write("Ingrese los tiempos del motor (DOS_TIEMPOS o CUATRO_TIEMPOS): ");
                            string tiemposMo = Console.ReadLine();
                            while (!(tiemposMo.Equals("DOS_TIEMPOS") | tiemposMo.Equals("CUATRO_TIEMPOS")))
                            {
                                Console.Write("Valor incorrecto. Ingrese exactamente como se muestra (DOS_TIEMPOS o CUATRO_TIEMPOS): ");
                                tiemposMo = Console.ReadLine();
                            }
                            Console.WriteLine("--------------------------------");
                            mo = new Motor(estadoMo, idMo, tipoMo, cilindradaMo, tiemposMo);

                            //Creación ruedas
                            Console.WriteLine("--------------------------------");
                            Console.Write("¿Cuántas ruedas va a ingresar? ");
                            int cantRuedas = int.Parse(Console.ReadLine());
                            for (int i = 0; i < cantRuedas; i++)
                            {
                                Console.WriteLine("--------------------------------");
                                Console.Write("Rueda ");
                                Console.WriteLine(i + 1);
                                Console.WriteLine("--------------------------------");
                                Console.Write("Ingrese el estado de la rueda (0,0 a 100,0): ");
                                float estadoR = float.Parse(Console.ReadLine());
                                while (estadoR < 0.0f | estadoR > 100.0f)
                                {
                                    Console.Write("Valor incorrecto. Ingrese el estado de la rueda (0,0 a 100,0): ");
                                    estadoR = float.Parse(Console.ReadLine());
                                }
                                Console.Write("Ingrese el recubrimiento de la rueda (FENOL, HULE o POLIUTERANO): ");
                                string recubrimientoR = Console.ReadLine();
                                while (!(recubrimientoR.Equals("FENOL") | recubrimientoR.Equals("HULE") | recubrimientoR.Equals("POLIUTERANO")))
                                {
                                    Console.Write("Valor incorrecto. Ingrese exactamente como se muestra (FENOL, HULE o POLIUTERANO): ");
                                    recubrimientoR = Console.ReadLine();
                                }
                                Console.Write("Ingrese el primer número del rango del durómetro: ");
                                int durometro1R = int.Parse(Console.ReadLine());
                                Console.Write("Ingrese el segundo número del rango del durómetro: ");
                                int durometro2R = int.Parse(Console.ReadLine());
                                Console.WriteLine("--------------------------------");
                                Rueda r = new Rueda(estadoR, recubrimientoR, durometro1R, durometro2R);
                                ruedas.Add(r);
                            }

                            //Creación automóvil
                            Console.WriteLine("--------------------------------");
                            Console.Write("Ingrese la marca del automóvil: ");
                            string marca = Console.ReadLine();
                            Console.Write("Ingrese el año del automóvil: ");
                            int ano = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el kilometraje del automóvil: ");
                            float kilometraje = float.Parse(Console.ReadLine());
                            Console.WriteLine("--------------------------------");
                            a = new Automovil(e, me, mo, ruedas, marca, ano, kilometraje);
                            vehiculos.Add(a);
                            Console.WriteLine("Automóvil añadido exitosamente.\n");
                            break;
                        case 2:
                            int cantVehiculos = 0;
                            foreach (Object item in vehiculos)
                            {
                                cantVehiculos++;
                                Automovil auto = (Automovil)item;
                                Console.WriteLine("Automóvil " + cantVehiculos + ":");
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Estado del estanque: " + auto.Estanque.EstadoComponente);
                                Console.WriteLine("Capacidad del estanque: " + auto.Estanque.Capacidad);
                                Console.WriteLine("Litros del estanque: " + auto.Estanque.Litros);
                                if (auto.Estanque.MitadCombustible())
                                {
                                    Console.WriteLine("Los litros están entre el 10.5% y el 50% de la capacidad.");
                                }
                                else if (auto.Estanque.BajoCombustible())
                                {
                                    Console.WriteLine("Los litros son o están por debajo del 10.5% de la capacidad.");
                                }
                                else
                                {
                                    Console.WriteLine("Los litros están por encima del 50% de la capacidad.");
                                }

                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Estado del mezclador: " + auto.Mezclador.EstadoComponente);
                                Console.WriteLine("Tipo de mezclador: " + auto.Mezclador.Tipo);
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Estado del motor: " + auto.Motor.EstadoComponente);
                                Console.WriteLine("ID del motor: " + auto.Motor.Id);
                                Console.WriteLine("Tipo de motor: " + auto.Motor.Tipo);
                                Console.WriteLine("Cilindrada del motor: " + auto.Motor.Cilindrada);
                                Console.WriteLine("Tipo de tiempos del motor: " + auto.Motor.Tiempos);
                                int contRuedas = 0;
                                foreach (Object o in auto.Ruedas)
                                {
                                    contRuedas++;
                                    Rueda w = (Rueda)o;
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Rueda " + contRuedas + ":");
                                    Console.WriteLine("--------------------------------");
                                    Console.WriteLine("Estado de la rueda: " + w.EstadoComponente);
                                    Console.WriteLine("Recubrimiento de la rueda: " + w.Recubrimiento);
                                    Console.WriteLine("Durómetro de la rueda: " + w.MinDurometro + " - " + w.MaxDurometro);
                                }
                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Marca del automóvil: " + auto.Marca);
                                Console.WriteLine("Año del automóvil: " + auto.Ano);
                                Console.WriteLine("Kilometraje del automóvil: " + auto.Kilometraje);
                                Console.WriteLine("--------------------------------");
                            }
                            break;

                        case 0:
                            Console.WriteLine("Sesión cerrada exitosamente.");
                            break;

                        default:
                            Console.WriteLine("Opción no valida. Intente otra vez.");
                            break;
                    }

                } while (!(opc == 0));

            }catch(Exception ex)
            {
                Console.WriteLine("Error. Valor incorrecto. " + ex.Message);
            }
        }
    }
}
