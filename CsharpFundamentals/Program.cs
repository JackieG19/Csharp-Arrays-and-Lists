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

		Array.Reverse(numbers);
		Console.WriteLine("Effect of Reverse()");
			
		foreach (var n in number)
			Console.WriteLine(n);
        }
    }
}
