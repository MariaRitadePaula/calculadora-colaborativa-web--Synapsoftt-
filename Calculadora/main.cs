using System;

    class Program
    {
      static float a = 0;
        static float b =0;
        static float resultado =0;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu primeiro valor:");
            a = float.Parse(Console.ReadLine());  
            
            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int operação = int.Parse(Console.ReadLine()):

            Console.WriteLine("Digite seu primeiro valor:");
            b = float.Parse(Console.ReadLine());
        }

        if(operação == 1)
            {
            Adição();
            Console.WriteLine(resultado);
            }
        
        else if(operação == 2)
        {
         Subtração();
            Console.WriteLine(resultado);
        }
        
        else if(operação == 3)
        {
            Multiplicação();
            Console.WriteLine(resultado)
        }

           else if(operação == 4)
        {
            Divisão();
            Console.WriteLine(resultado)
        }

        else {
            Console.WriteLine("Operação invalida");
            return;
        }
        
        static void Adição();
        {
        }
        static void Subtração();
        {
        }
        static void Multiplicação();
        {
        }
        static void Divisão();
        {
        }
        
        
    }
