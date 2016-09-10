using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1567SMS
{
    class Program
    {
        static void Main(string[] args)
        {
            String TemplateStr = "abcdefghijklmnopqrstuvwxyz@.,! ";
            String InputStr = Console.ReadLine();

            Int16 SMSCost = 0;

            for (int i = 0; i < InputStr.Length; ++i)
                for (int j = 0; j < TemplateStr.Length; ++j)
                    if (InputStr[i] == TemplateStr[j]) {

                        if ((j+1) % 3 == 0)
                            SMSCost += 3;
                        else 
                            if ((j+1) % 3 == 2)
                                SMSCost += 2;
                            else
                                SMSCost += 1;
                    }

                        Console.WriteLine(SMSCost);
        }
    }
}
