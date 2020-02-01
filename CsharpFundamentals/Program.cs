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
		
		int[] another = new int[3];  
		Array.Copy(numbers, another, 3);
			
		Console.WriteLine("Effect of Copy()");
		foreach (var n in another)
			Console.WriteLine(n);
        }
    }
}
