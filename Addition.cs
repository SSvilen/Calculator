using System;
namespace Math {
    class Addition {
        public void Main(string[] args) {
            int sum;
            foreach (string arg in args) {
                sum += (int)arg;
            }
            Console.WriteLine("Result is: " + sum);
        }
    }
}