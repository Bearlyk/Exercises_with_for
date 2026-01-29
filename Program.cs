namespace Exercises
{
    
    class Program
    {
        static void Main(string[] args)
        {
           
            WriteFrom1To10();
            Numerospares();
            Numerosimpares();
            Multiplos_de_5();
            retro();
          

        }

        static void WriteFrom1To10()
        {
            for(int i = 1;i<=10;i++)
            {
                Console.WriteLine(+i);
            }
            Console.WriteLine("--------------------");
        }

        static void Numerospares()
        {
            for(int a = 2;a<=10;a=a+2)
            {
                Console.WriteLine(+a);
            }
            Console.WriteLine("--------------------");
        }
        static void Numerosimpares()
        {
            for(int b = 1;b<=10;b=b+2)
            {
                Console.WriteLine(+b);
            }
            Console.WriteLine("--------------------");
        }
        static void Multiplos_de_5()
        {
            int multiplo = 5;
            int resultado = 0;

            for(int c = 1;c<=10;c++)
            {
                resultado= multiplo * c;

                Console.WriteLine(resultado);
            }
            Console.WriteLine("--------------------");
        }
        static void retro()
        {
            for(int i = 10;i>=1;i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------");
        }

        
    }    
}
