using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SFA.DAS.Technical.Test.Infrastructure;

namespace SFA.DAS.Technical.Test
{
    // Spend no more than 45 minutes on this task
    //
    // Please complete your implementation by cloning this repository on GitHub and submitting it back to us as a zip file, remember to include your randomly generated input.data file.
    //
    // Part 1 - Complete the Multiply method that can be found in the SFA.DAS.Technical.Test.Infrastructure.Math class so that it multiplies two positive integers together without using the multiplication operator
    //
    // For Example:
    // Given the two integers 6 and 3 the product would be 18
    
    // Part 2 - Complete the unit tests for the Multiply method that can be found in the SFA.DAS.Technical.Test.Tests.MathTests class and add any further tests you feel may be missing

    // Part 3 - Given an array containing an even number of integers, multiply each adjacent pair together using the Multiply method from part 1 then take the product of each multiplication and add them together to give a result. The data for this part of the task will be randomly generated for you.
    //
    // For Example:
    // Given the array [6,3,2,10]
    // Multiply 6 by 3 giving 18
    // Multiply 2 by 10 giving 20
    // Add 18 and 20 giving the answer 38

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
            // Add part 1 code here
        }

        public static async Task Part2()
        {
            // Add part 2 code here
            part2Input = await new Data().Generate();
        }
    }    
}