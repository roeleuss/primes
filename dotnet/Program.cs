class Program {

    static int IsPrime(int n)
    {
        for (int i = 2; i <= n / i; i++)
        {
            if ((n % i) == 0) return 0;
        }
        return 1;
    }

    static void Main() {
        DateTime ini = DateTime.Now;
        int primes = 1;
        int max = 10000000;

        for (int i = 2; i <= max; i++)
        {
            primes += IsPrime(i);
        }

        Console.WriteLine(primes);
        DateTime end = DateTime.Now;
        Console.WriteLine($"{(end - ini).TotalSeconds}");
    }

}
