using System.Text.Json;

namespace fibo {
    class Program {
        public static int Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }

        public static void Main() {
            Console.WriteLine(Fib(42));
        }
    }
}
