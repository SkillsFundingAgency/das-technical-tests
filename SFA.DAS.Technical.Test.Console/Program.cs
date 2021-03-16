using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFA.DAS.Technical.Test.Infrastructure;

namespace SFA.DAS.Technical.Test
{
    public class Program
    {   
        private static IEnumerable<int> part1Input;
        private static IEnumerable<int> part2Input;

        public static async Task Main(string[] args)
        {
            await Part1();
            await Part2();
        }

        public static async Task Part1()
        {
            part1Input = new int[] { 6, 3 };

            // Add you code here
        }

        public static async Task Part2()
        {
            part2Input = await new Data().Generate();

            // Add you code here
        }
    }    
}