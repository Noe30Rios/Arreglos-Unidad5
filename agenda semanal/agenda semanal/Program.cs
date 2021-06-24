using System;

namespace agenda_semanal
{
    class Program
    {
        class agenda
        {
            
            double opcion_menu;
          char tecla;
            String em1, emp2, emp3, dia1, dia2, dia3, h1, h2, h3;
            string respuesta,respuesta2;
            public void casos()
            {
               
                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 0);
                    Console.WriteLine("***NOE RIOS ***");
                    Console.SetCursorPosition(13, 1);
                    Console.WriteLine("***BIENVENIDO A MI AGENDA EMPRESARIAL***");
                    do
                    {
                        Console.SetCursorPosition(1, 2);
                        if (opcion_menu == 1)
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("sala 1");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(30, 2);
                        if (opcion_menu == 2)
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("sala 2");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(60, 2);
                        if (opcion_menu == 3)
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("sala 3");

                        Console.ForegroundColor = ConsoleColor.White;
                        tecla = (char)Console.ReadKey().Key;
                        switch (tecla)
                        {
                            case (char)ConsoleKey.LeftArrow:
                                if (opcion_menu == 1) opcion_menu = 3; else opcion_menu--;
                                break;
                            case (char)ConsoleKey.RightArrow:
                                if (opcion_menu == 3) opcion_menu = 1; else opcion_menu++;
                                break;
                        }
                    } while (tecla != (char)ConsoleKey.Escape && tecla != (char)ConsoleKey.Enter);
                    if (tecla == (char)ConsoleKey.Escape)
                        opcion_menu = 0;
                    Console.WriteLine("" + opcion_menu);

                    if (opcion_menu == 1)
                    {
                        Console.WriteLine("***esta es la sala 1***");
                        Console.WriteLine("NOMBRE DE LA EMPRESA: ");
                        em1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("HORA DE SU CITA: ");
                        h1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("DIA DE SU CITA: ");
                        dia1 = Convert.ToString(Console.ReadLine());
                        if (dia1 == "domingo")
                        {
                            Console.WriteLine("“La sala excede del horario de servicio");
                        }
                        Console.WriteLine("SI DECEA SABER EL REPORTE DE LAS CITAS INTRODUZCA -repote-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "reporte")
                        {
                            Console.WriteLine(" ------------------------------------------------------------------");
                            Console.WriteLine(" sala 1 agenda");
                            Console.WriteLine("EMPRESA :" + em1);
                            Console.WriteLine("HORA :" + h1);
                            Console.WriteLine("DIA :" + dia1);
                            Console.WriteLine(" ------------------------------------------------------------------");
                        }
                        Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                        respuesta2 = Convert.ToString(Console.ReadLine());
                    }
                  else  if (opcion_menu == 2)
                    {
                        Console.WriteLine("***esta es la sala 2***");
                        Console.WriteLine("NOMBRE DE LA EMPRESA: ");
                        emp2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("HORA DE SU CITA: ");
                        h2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("DIA DE SU CITA: ");
                        dia2 = Convert.ToString(Console.ReadLine());
                        if (dia2 == "domingo")
                        {
                            Console.WriteLine("“La sala excede del horario de servicio");
                        }
                        Console.WriteLine("SI DECEA SABER EL REPORTE DE LAS CITAS INTRODUZCA -repote-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "reporte")
                        {
                            Console.WriteLine(" ------------------------------------------------------------------");
                            Console.WriteLine(" sala 2 agenda");
                            Console.WriteLine("EMPRESA :" + emp2);
                            Console.WriteLine("HORA :" + h2);
                            Console.WriteLine("DIA :" + dia2);
                            Console.WriteLine(" ------------------------------------------------------------------");
                        }
                        Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                        respuesta2 = Convert.ToString(Console.ReadLine());
                    }

                    else
                    {
                        Console.WriteLine("***esta es la sala 3***");
                        Console.WriteLine("NOMBRE DE LA EMPRESA: ");
                        emp3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("HORA DE SU CITA: ");
                        h3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("DIA DE SU CITA: ");
                        dia3 = Convert.ToString(Console.ReadLine());
                        if (dia3 == "domingo" )
                        {
                            Console.WriteLine("“La sala excede del horario de servicio");
                        }
                        Console.WriteLine("SI DECEA SABER EL REPORTE DE LAS CITAS INTRODUZCA -repote-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "reporte")
                        {
                            Console.WriteLine(" ------------------------------------------------------------------");
                            Console.WriteLine(" sala 1 agenda");
                            Console.WriteLine("EMPRESA :" + emp3);
                            Console.WriteLine("HORA :" + h3);
                            Console.WriteLine("DIA :" + dia3);
                            Console.WriteLine(" ------------------------------------------------------------------");
                        }
                        Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                        respuesta2 = Convert.ToString(Console.ReadLine());
                    }
                    

                    

                } while (respuesta2 == "si");
                
            }
        }
        static void Main(string[] args)
        {
            agenda objcasos = new agenda();
            objcasos.casos();
        }
    }
}
