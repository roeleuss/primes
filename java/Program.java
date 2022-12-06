public class Program {

    private static int isPrime(int n)
    {
        for (int i = 2; i <= n / i; i++) {
            if ((n % i) == 0) return 0;
        }
        return 1;
    }

    public static void main(String[] args) {
        long ini = System.currentTimeMillis();
        int primes = 1;
        int max = 10000000;

        for (int i = 2; i <= max; i++) {
            primes += isPrime(i);
        }

        System.out.println(primes);
        long end = System.currentTimeMillis();
        System.out.println((end - ini) / 1000d);
    }
}
