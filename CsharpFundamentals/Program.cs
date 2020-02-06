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
		// creating a list of integers(initialize/store objects)
		var number = new List<int>() {1, 2, 3, 4};
		
		foreach (var number in numbers)
			Console.WriteLine(numbper); // 1,2,3,4,1,5,6,7
		
		Console.WriteLine(); // separate from the console above
		
		numbers.Remove(1); // removes an int/char/str from the specified position of a list/array
		foreach (var number in numbers)
			Console.WriteLine(number); // 2,3,4,1,5,6,7
        }
    }
}
