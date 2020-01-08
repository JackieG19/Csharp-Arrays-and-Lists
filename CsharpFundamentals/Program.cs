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
		var number = new[] {3, 7, 9, 2, 14, 6};
		
		// Clear() method
		Array.Clear(numbers, 0, 2);
		// (array, starting index of the range of elements)
			
		Console.WriteLine("Effect of Clear()");
			
		foreach (var n in number)
			Console.WriteLine(n);
        }
    }
}
