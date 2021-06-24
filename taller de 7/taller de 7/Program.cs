using System;

namespace taller_de_7
{
    class Automovil
    {
        string placas, dueño, respuesta,respuestas;
        int capadidadTaller, vacio;
        double tarifa, tarifaTotal;
        string[] PlacaAuto;
        string[] NombreDueño;
        double[] Cobro;
        public double Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        public double TarifaTotal
        {
            get { return tarifaTotal; }
            set { tarifaTotal = value; }
        }
        public string Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }
        public string Placas
        {
            get { return placas; }
            set { placas = value; }
        }
        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
        public string RespuestaS
        {
            get { return respuestas; }
            set { respuestas = value; }
        }
        public int CapacidadTaller
        {
            get { return capadidadTaller; }
            set { capadidadTaller = value; }
        }
        public int Vacio
        {
            get { return vacio; }
            set { vacio = value; }
        }
        public void Entrada()
        {
            Console.SetCursorPosition(30, 1);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("TALLER MECANICO CACHANILLA");
            Console.WriteLine("Programa que captura, almacena y muestra los autos atendidos del taller EN UNA JORNADA LABORAL");

            for (int i = 0; i < 7; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                tarifaTotal = -1;
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Introduce las placas: ");
                Placas = Console.ReadLine().ToString();
                Console.Write("Dueño / propietario: ");
                Dueño = Console.ReadLine().ToString();
                Console.Write("Tarifa a cobrar por la reparación: " + "$");
                Tarifa = double.Parse(Console.ReadLine());
                TarifaTotal = TarifaTotal + Tarifa;
                CapacidadTaller += 1;
                Vacio += 1;

            }
        }
        public void Salida()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Capacidad taller: " + CapacidadTaller);
            Console.WriteLine("El taller esta en su capacidad máxima. Espere por favor...");

            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("¿Sale un auto del taller? ");
                Respuesta = Console.ReadLine().ToLower();
                if (Respuesta == "si")
                {

                    Vacio -= 1;
                    TarifaTotal += Tarifa;
                    Console.Write("¿Ingresa un nuevo auto al taller? ");
                    Respuesta = Console.ReadLine().ToLower();
                    if (Respuesta == "si")
                    {
                        Console.WriteLine("---------------------------------------------------------");
                        Console.Write("Introduce las placas: ");
                        Placas = Console.ReadLine().ToString();
                        Console.Write("Dueño / propietario: ");
                        Dueño = Console.ReadLine().ToString();
                        Console.Write("Tarifa a cobrar por la reparación: " + "$");
                        Tarifa = double.Parse(Console.ReadLine());
                        CapacidadTaller = CapacidadTaller + 1;
                        Vacio = Vacio + 1;
                        Console.WriteLine("----------" + CapacidadTaller);
                        Console.WriteLine("----------" + Vacio);
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Siga esperando...");
                        Console.ReadLine();
                    }


                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Siga esperando...");
                    Console.ReadLine();
                }

            } while (Vacio > 0);


        }
        public void MeterAuto()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Total de autos atendidos en el dia: " + CapacidadTaller);
            PlacaAuto = new string[CapacidadTaller];
            NombreDueño = new string[CapacidadTaller];
            Cobro = new double[CapacidadTaller];
            for (int i = 0; i < CapacidadTaller; i++)
            {
                PlacaAuto[i] = Placas;
                NombreDueño[i] = Dueño;
                Cobro[i] = Tarifa;
            }
            Console.WriteLine("Ganancia al final del día: " + "$" + TarifaTotal);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Automovil taller = new Automovil();

            taller.Entrada();
            taller.Salida();
            taller.MeterAuto();

        }


    }
}
