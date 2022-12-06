# C

```sh
sudo apt install gcc
```

```sh
cd c
gcc primes.c -o primes
time ./primes
```


# .NET

```sh
sudo apt install dotnet -y
```

```sh
cd dotnet
dotnet build -c Release
time dotnet ./bin/Release/net6.0/dotnet.dll
```


# Java

```sh
sudo apt install default-jdk -y
```

```sh
cd java
javac Program.java
time java Program
```
