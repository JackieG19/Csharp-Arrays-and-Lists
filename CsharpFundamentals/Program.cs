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
			
		for(var i = 0; i < numbers.Count; i++)
		{	
		// number[i] because there isn't a local variable called numbers,
		// so we can access the current element in the list using an index
				
			if (number[i] == 1)
			numbers.Remove(numbers[i]);
				
			// removes all elements from the list
			number.Clear();
			Console.WriteLine("Count: " + numbers.Count); // 0
		}
	}
    }
}
