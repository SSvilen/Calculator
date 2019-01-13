using System;
namespace Math {
    class Addition {
        public static void Main(string[] args) {
            int sum =0;
            foreach (string arg in args) {
                sum += Int32.Parse(arg) ;
            }
            Console.WriteLine("Result is: " + sum);
        }
    }
}