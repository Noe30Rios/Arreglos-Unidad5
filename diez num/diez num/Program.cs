using System;

namespace diez_num
{
    class Program
    {
        class NUMEROS10
        {
            public int Num1, Num2, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num3, suma, promedio;

            public void SUMA()
            {
                //A
                Console.WriteLine("Insertar el numero 1");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 2");
                Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 3");
                Num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 4");
                Num4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 5");
                Num5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 6");
                Num6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 7");
                Num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 8");
                Num8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 9");
                Num9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 10");
                Num10 = Convert.ToInt32(Console.ReadLine());

                suma = Num1 + Num2 + Num3 + Num4 + Num5 + Num6 + Num7 + Num8 + Num9 + Num10;
                Console.WriteLine("A) Suma de los  digitos  " + suma);

            }
            public void PROMEDIO()
            {
                promedio = suma / 10;
                Console.WriteLine("B) Promedio de los digitos " + promedio);
            }

            public void NumeroMasGrande()
            {
                if (Num1 > Num2 && Num1 > Num3 && Num1 > Num4 && Num1 > Num5 && Num1 > Num6 && Num1 > Num7 && Num1 > Num8 && Num1 > Num9 && Num1 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor es el " + Num1);
                }
                if (Num2 > Num1 && Num2 > Num3 && Num2 > Num4 && Num2 > Num5 && Num2 > Num6 && Num2 > Num7 && Num2 > Num8 && Num2 > Num9 && Num2 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor  es el " + Num2);
                }
                if (Num3 > Num1 && Num3 > Num2 && Num3 > Num4 && Num3 > Num5 && Num3 > Num6 && Num3 > Num7 && Num3 > Num8 && Num3 > Num9 && Num3 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor  es el " + Num3);
                }
                if (Num4 > Num1 && Num4 > Num2 && Num4 > Num3 && Num4 > Num5 && Num4 > Num6 && Num4 > Num7 && Num4 > Num8 && Num4 > Num9 && Num4 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor  es el " + Num4);
                }
                if (Num5 > Num1 && Num5 > Num2 && Num5 > Num3 && Num5 > Num4 && Num5 > Num6 && Num5 > Num7 && Num5 > Num8 && Num5 > Num9 && Num5 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor  es el " + Num5);
                }
                if (Num6 > Num1 && Num6 > Num2 && Num6 > Num3 && Num6 > Num4 && Num6 > Num5 && Num6 > Num7 && Num6 > Num8 && Num6 > Num9 && Num6 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor  es el " + Num6);
                }
                if (Num7 > Num1 && Num7 > Num2 && Num7 > Num3 && Num7 > Num4 && Num7 > Num5 && Num7 > Num6 && Num7 > Num8 && Num7 > Num9 && Num5 + 7 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor s es el " + Num7);
                }
                if (Num8 > Num1 && Num8 > Num2 && Num8 > Num3 && Num8 > Num4 && Num8 > Num5 && Num8 > Num6 && Num8 > Num7 && Num8 > Num9 && Num8 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor  es el " + Num8);
                }
                if (Num9 > Num1 && Num9 > Num2 && Num9 > Num3 && Num9 > Num4 && Num9 > Num5 && Num9 > Num6 && Num9 > Num7 && Num9 > Num8 && Num9 > Num10)
                {
                    Console.WriteLine(" C) El numero mayor  es el " + Num9);
                }
                if (Num10 > Num1 && Num10 > Num2 && Num10 > Num3 && Num10 > Num4 && Num10 > Num5 && Num10 > Num6 && Num10 > Num7 && Num10 > Num8 && Num10 > Num9)
                {
                    Console.WriteLine(" C) El numero mayor d es el " + Num10);
                }

            }

            public void NumeroMENOR()
            {
                if (Num1 < Num2 && Num1 < Num3 && Num1 < Num4 && Num1 < Num5 && Num1 < Num6 && Num1 < Num7 && Num1 < Num8 && Num1 < Num9 && Num1 < Num10)
                {
                    Console.WriteLine(" D) El numero menor de los digitos es el " + Num1);
                }
                if (Num2 < Num1 && Num2 < Num3 && Num2 < Num4 && Num2 < Num5 && Num2 < Num6 && Num2 < Num7 && Num2 < Num8 && Num2 < Num9 && Num2 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num2);
                }
                if (Num3 < Num1 && Num3 < Num2 && Num3 < Num4 && Num3 < Num5 && Num3 < Num6 && Num3 < Num7 && Num3 < Num8 && Num3 < Num9 && Num3 < Num10)
                {
                    Console.WriteLine(" D) El numero menor de los digitos es el " + Num3);
                }
                if (Num4 < Num1 && Num4 < Num2 && Num4 < Num3 && Num4 < Num5 && Num4 < Num6 && Num4 < Num7 && Num4 < Num8 && Num4 < Num9 && Num4 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num4);
                }
                if (Num5 < Num1 && Num5 < Num2 && Num5 < Num3 && Num5 < Num4 && Num5 < Num6 && Num5 < Num7 && Num5 < Num8 && Num5 < Num9 && Num5 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num5);
                }
                if (Num6 < Num1 && Num6 < Num2 && Num6 < Num3 && Num6 < Num4 && Num6 < Num5 && Num6 < Num7 && Num6 < Num8 && Num6 < Num9 && Num6 < Num10)
                {
                    Console.WriteLine(" D) El numero menor de los digitos es el " + Num6);
                }
                if (Num7 < Num1 && Num7 < Num2 && Num7 < Num3 && Num7 < Num4 && Num7 < Num5 && Num7 < Num6 && Num7 < Num8 && Num7 < Num9 && Num7 < Num10)
                {
                    Console.WriteLine(" D) El numero menor de los digitos es el " + Num7);
                }
                if (Num8 < Num1 && Num8 < Num2 && Num8 < Num3 && Num8 < Num4 && Num8 < Num5 && Num8 < Num6 && Num8 < Num7 && Num8 < Num9 && Num8 < Num10)
                {
                    Console.WriteLine(" D) El numero menor de los digitos es el " + Num8);
                }
                if (Num9 < Num1 && Num9 < Num2 && Num9 < Num3 && Num9 < Num4 && Num9 < Num5 && Num9 < Num6 && Num9 < Num7 && Num9 < Num8 && Num9 < Num10)
                {
                    Console.WriteLine(" D) El numero menor de los digitos es el " + Num9);
                }
                if (Num10 < Num1 && Num10 < Num2 && Num10 < Num3 && Num10 < Num4 && Num10 < Num5 && Num10 < Num6 && Num10 < Num7 && Num10 < Num8 && Num10 < Num9)
                {
                    Console.WriteLine(" D) El numero menor de los digitos es el " + Num10);
                }

            }




        }



        static void Main(string[] args)
        {
            NUMEROS10 ObjNUM = new NUMEROS10();
            ObjNUM.SUMA();
            NUMEROS10 ObjNUMP = new NUMEROS10();
            ObjNUM.PROMEDIO();
            NUMEROS10 ObjNUMM = new NUMEROS10();
            ObjNUM.NumeroMasGrande();
            NUMEROS10 ObjNUMMENOR = new NUMEROS10();
            ObjNUM.NumeroMENOR();
        }
    }
}

