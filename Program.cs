using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5A7s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Fruits = new ArrayList();
            Console.WriteLine("How many Fruits you want to enter inside the fruits list");
            var nof=int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter {nof}  fruits inside the list");
            for (int i = 0; i < nof; i++)
            {
                Fruits.Add(Console.ReadLine());
            }
            
            Console.WriteLine(Fruits.Count);
            Console.WriteLine("Enter fruit you want to search");
            var item = Fruits.IndexOf(Console.ReadLine());
            if (item == -1)
            {
                Console.WriteLine("fruit not found in list");

            }
            else
            {
                Console.WriteLine($"fruit is in the list at {item} position");
            }
            Console.WriteLine("Add value at index 2");
            Fruits[2] = Console.ReadLine();
            Console.WriteLine("After Adding value at index 2");
            foreach (var newval in Fruits)
            {
                Console.WriteLine(newval);
            }
            Console.WriteLine("Enter fruit you want to delete from the list");
          var rmv= Console.ReadLine();
            Fruits.Remove(rmv);
            
            foreach (var newval in Fruits)
            {
                Console.WriteLine(newval);
            }
            Console.ReadKey();
        }
    }
}

          
        
