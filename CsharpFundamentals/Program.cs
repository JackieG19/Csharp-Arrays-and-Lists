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
		var number = new List<int>() {1, 2, 3, 4};
		numbers.Add(1);
			
		foreach (var number in number			
		{
			if (number == 1)
			numbers.Remove(number); // this is modifying the collection
		}
			
		foreach (var number in numbers)
			Console.WriteLine(number);
		
		// application cashed - error: unhandled exception,
		// not allowed to modify the collection inside a foreach loop
	}
    }
}
