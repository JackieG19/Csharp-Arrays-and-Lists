using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*using statement*/

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {		
			// creating an array of integers, {initialize objects}
			// int[] numbers = new int[] {3, 7, 9, 2, 14, 6};
            
			// can make the line aove shorter
			var number = new[] {3, 7, 9, 2, 14, 6};
			
			// Length property - size of the array
			Console.WriteLine("Length: " + numbers.Length); // 6
        }
    }
}
