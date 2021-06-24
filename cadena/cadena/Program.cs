using System;

namespace cadena
{
    class Program
    {
        class cadena
        {
            string CadenaS;
            public void nombre()
            {
                Console.WriteLine("introduce una palabra :");
                CadenaS = Convert.ToString(Console.ReadLine());
                char[] cArray = CadenaS.ToCharArray();
                string Reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    Reverse += cArray[i];
                }
                Console.WriteLine("la palabra alreves es :" + Reverse);
                Console.ReadKey();
            }

            public void Mayus()
            {
                Console.WriteLine("la cadena en mayusculas es: {0}", CadenaS.ToUpper());
                Console.ReadKey();
                Console.WriteLine("la cadena Nueva es: {0}", CadenaS.Replace("a", "4").Replace("i", "1").Replace("s", "5").Replace("b", "8").Replace("e", "3").Replace("t", "7"));
                Console.ReadKey();
            }
          
           
        }
        static void Main(string[] args)
        {
            cadena objcade = new cadena();
            objcade.nombre();
            cadena objcadesa = new cadena();
            objcade.Mayus();
            

        }
    }
}
