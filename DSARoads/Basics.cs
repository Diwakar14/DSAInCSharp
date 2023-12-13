using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSARoads
{
    internal class Basics
    {
        public int name { get; set; }
        
        
        
        public Basics()
        {

        }

        public async Task PrepareBreakFast()
        {
            Console.WriteLine($"Starting to prepare the breakfast.");
            await Task.Delay(1000);
            Console.WriteLine($"Done");
        }

        public void PrepareLunch(ref int numberOfPeople, out int afterCooked)
        {

            numberOfPeople = 0;
            Console.WriteLine($"Starting to prepare the lunch for {numberOfPeople} peoples.");

            afterCooked = 45;

        }

        public async Task PrepareDinner(int numberOfPeople)
        {
            Console.WriteLine($"Starting to prepare the dinner for {numberOfPeople} peoples.");
            await Task.Delay(2000);
        }
    }
}
