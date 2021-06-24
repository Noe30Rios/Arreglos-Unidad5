using System;

namespace _20_num
{
    class Program
    {
        class me_ma
        {
            int Num1, Num2, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num3, Num11, Num12, Num14, Num15, Num16, Num17, Num18, Num19, Num20, Num13;

            public void M_Y_M()
            {
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
                Console.WriteLine("Insertar el numero 11");
                Num11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 12");
                Num12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 13");
                Num13 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 14");
                Num14 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 15");
                Num15 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 16");
                Num16 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 17");
                Num17 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 18");
                Num18 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 19");
                Num19 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 20");
                Num20 = Convert.ToInt32(Console.ReadLine());
                //arreglo con números en desorden
                int[] numeros = { Num1, Num2, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num3, Num11, Num12, Num14, Num15, Num16, Num17, Num18, Num19, Num20, Num13 };
                //la siguiente instrucción ordena el arreglo numeros demenor a mayor
                //su sintaxis es array.Sort(nombredelarreglo);
                Array.Reverse(numeros);
                //la siguiente sintaxis invierte el orden del arreglo, comoestaba de
                //menor a mayor ahora estará de mayor a menor
                //su sintaxis es array.Reverse(nombredelarreglo);
                Array.Sort(numeros);
                Console.WriteLine("Ordenados de menor a mayor");
                //se imprime en pantalla el arreglo con un ciclo for
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Numero: " + numeros[i].ToString());
                }
                Console.ReadLine();//sedetiene pantalla
            }
        }
        static void Main(string[] args)
        {
            me_ma OBJMYM = new me_ma();
            OBJMYM.M_Y_M();
        }
    }
}
