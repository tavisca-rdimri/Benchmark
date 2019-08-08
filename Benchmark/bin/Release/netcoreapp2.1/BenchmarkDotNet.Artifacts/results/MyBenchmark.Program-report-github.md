``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.829 (1803/April2018Update/Redstone4)
Intel Core i7-6600U CPU 2.60GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
Frequency=2742188 Hz, Resolution=364.6723 ns, Timer=TSC
.NET Core SDK=2.1.508
  [Host]     : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.12 (CoreCLR 4.6.27817.01, CoreFX 4.6.27818.01), 64bit RyuJIT


```
|                 Method |     Mean |     Error |    StdDev |
|----------------------- |---------:|----------:|----------:|
|        StringBenchmark | 6.715 us | 0.0535 us | 0.0474 us |
| StringBuilderBenchmark | 3.536 us | 0.0254 us | 0.0238 us |
