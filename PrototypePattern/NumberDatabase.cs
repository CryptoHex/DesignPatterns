using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class NumberDatabase : IPrototype
    {
        private List<int> numbers;

        public NumberDatabase()
        {
        }

        public NumberDatabase(List<int> numbers)
        {
            this.numbers = numbers;
        }

        public IPrototype Clone()
        {
            return new NumberDatabase(numbers);
        }

        // time costly operation
        public void GenerateRandomNumbers()
        {
            int longNumber = 300000000;
            Random random = new Random();
            numbers = new List<int>();
            for(int i = 0; i < longNumber; i++)
            {             
                numbers.Add(random.Next(1, 11));
            }
            
        }
            
    }
}
