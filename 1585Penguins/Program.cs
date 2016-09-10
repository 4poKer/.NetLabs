using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1585Penguins
{
    class Program
    {
        static void Main(string[] args)
        {

            int CountEmperorPenguins = 0; //счетчик Императорских пингвинов
            int CountLittlePenguins = 0; //счетчик Малых пингвинов
            int CountMacaroniPenguins = 0; //счетчик Пингвинов Макарони

           int n = Convert.ToInt32(Console.ReadLine()); //количество пингвинов

           for (int i = 0; i < n; ++i) {

               String TempInputStr = Console.ReadLine();

               if (TempInputStr == "Emperor Penguin")
                   CountEmperorPenguins++;
               else
                   if (TempInputStr == "Little Penguin")
                       CountLittlePenguins++;
                   else
                       CountMacaroniPenguins++;
           }
    

           int[] PenguinsCounts = new int[]{CountEmperorPenguins,CountLittlePenguins,CountMacaroniPenguins};

           int MaxCount = PenguinsCounts.Max();

           if (MaxCount == CountEmperorPenguins)
               Console.WriteLine("Emperor Penguin");
           else 
               if (MaxCount == CountLittlePenguins)
                   Console.WriteLine("Little Penguin");
               else
                   Console.WriteLine("Macaroni Penguin");

        }
    }
}
