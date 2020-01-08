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
		
		// IndexOf() method - to find the position of an element
		var index = Array.IndexOf(numbers, 9); 
		
		// (first parameter = array, second parameter = the object)
		Console.WriteLine("Index of 9: " + index); // 2
        }
    }
}
