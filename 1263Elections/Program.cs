using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1263Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] InputStr = Console.ReadLine().Trim().Split(' ');

            int CandidatesCount = Convert.ToInt32(InputStr[0]);
            int ElectorateCount = Convert.ToInt32(InputStr[1]);

            int[] Vote = new int[CandidatesCount];

            for (int i = 0; i < CandidatesCount; ++i)
                Vote[i] = 0;

            for (int i = 0; i < ElectorateCount; ++i) {

                int TempVote = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < CandidatesCount; ++j) 
                    if (TempVote == j + 1)
                        Vote[j]++;
                
            }


            for (int i = 0; i < CandidatesCount; ++i) {

                Console.WriteLine(String.Format("{0:0.00}", Math.Round((Convert.ToDouble(Vote[i]) / Convert.ToDouble(ElectorateCount) * 100), 2)) + "%");
            }
                  
        }
    }
}
