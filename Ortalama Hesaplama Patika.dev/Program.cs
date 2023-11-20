using Ortalama_Hesaplama_Patika.dev;

Console.Write("Lütfen Fibonacci değerini giriniz :");
int a = Convert.ToInt32(Console.ReadLine());
Fibonacci fibonacci = new Fibonacci();
fibonacci.OrtalamaHesapla(a);
