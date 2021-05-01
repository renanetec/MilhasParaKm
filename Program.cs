using System;

namespace milhasparakm
{
    class Program
    {
        static void Main(string[] args)
        {
          
         Console.Clear(); 
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.WriteLine("conversor de milhas em km");
         Console.WriteLine();
         Console.ForegroundColor = ConsoleColor.Red;

         double milhas = 2;
         //escolha 1 numero para milhas 
         //salve usando o comando CTRL + S no teclado
         double km = 1.609;
         //lembrando que 1 milha é igual a 1.609 km 
         double doublemutiplicacao = milhas * km;

         Console.WriteLine($"{milhas} * {km} = {doublemutiplicacao} km\n");
         Console.ResetColor();
         //no terminal use o comando dotnet run



        }
    }
}
