#include <stdio.h>
#include <time.h>

int isPrime(int n) {
    for (int i = 2; i <= n / i; i++) {
        if (!(n % i)) return 0;
    }
    return 1;
}

int main() {
    clock_t ini = clock();
    int primes = 1;
    int max = 10000000;

    for (int i = 2; i <= max; i++) {
        primes += isPrime(i);
    }

    printf("%d\n", primes);
    clock_t end = clock();
    printf("%f\n", ((double)(end - ini) / CLOCKS_PER_SEC));
    return 0;
}