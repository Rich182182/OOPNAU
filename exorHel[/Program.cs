using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.GetCultureInfo("uk-UA");

        double epsilon1 = 1e-4;
        double epsilon2 = 1e-5;
        double epsilon3 = 1e-6;

        Console.WriteLine("Метод бісекції:");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon1}: {BisectionMethod(0, 2, epsilon1)}");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon2}: {BisectionMethod(0, 2, epsilon2)}");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon3}: {BisectionMethod(0, 2, epsilon3)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon1}: {BisectionMethodG(0, 2, epsilon1)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon2}: {BisectionMethodG(0, 2, epsilon2)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon3}: {BisectionMethodG(0, 2, epsilon3)}");

        Console.WriteLine("\nМетод хорд:");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon1}: {ChordMethod(0, 2, epsilon1)}");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon2}: {ChordMethod(0, 2, epsilon2)}");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon3}: {ChordMethod(0, 2, epsilon3)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon1}: {ChordMethodG(0, 2, epsilon1)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon2}: {ChordMethodG(0, 2, epsilon2)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon3}: {ChordMethodG(0, 2, epsilon3)}");

        Console.WriteLine("\nМетод січних:");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon1}: {SecantMethod(0, 2, epsilon1)}");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon2}: {SecantMethod(0, 2, epsilon2)}");
        Console.WriteLine($"Корінь f(x) з точністю {epsilon3}: {SecantMethod(0, 2, epsilon3)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon1}: {SecantMethodG(0, 2, epsilon1)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon2}: {SecantMethodG(0, 2, epsilon2)}");
        Console.WriteLine($"Корінь g(x) з точністю {epsilon3}: {SecantMethodG(0, 2, epsilon3)}");
    }

    static double f(double x)
    {
        return Math.Pow(Math.Cos(x), 2) + 0.5 * Math.Cos(x) + 1.0 / 18;
    }

    static double g(double x)
    {
        return Math.Pow(Math.Cos(x), 2) + 1.0 / 3 * Math.Cos(x) + 1.0 / 36;
    }

    static double BisectionMethod(double a, double b, double epsilon)
    {
        double c;
        while ((b - a) / 2 > epsilon)
        {
            c = (a + b) / 2;
            if (f(c) == 0)
                break;
            else if (f(c) * f(a) < 0)
                b = c;
            else
                a = c;
        }
        return (a + b) / 2;
    }

    static double BisectionMethodG(double a, double b, double epsilon)
    {
        double c;
        while ((b - a) / 2 > epsilon)
        {
            c = (a + b) / 2;
            if (g(c) == 0)
                break;
            else if (g(c) * g(a) < 0)
                b = c;
            else
                a = c;
        }
        return (a + b) / 2;
    }

    static double ChordMethod(double a, double b, double epsilon)
    {
        double x = a;
        while (Math.Abs(f(x)) > epsilon)
        {
            x = a - f(a) * (b - a) / (f(b) - f(a));
            if (f(x) * f(a) < 0)
                b = x;
            else
                a = x;
        }
        return x;
    }

    static double ChordMethodG(double a, double b, double epsilon)
    {
        double x = a;
        while (Math.Abs(g(x)) > epsilon)
        {
            x = a - g(a) * (b - a) / (g(b) - g(a));
            if (g(x) * g(a) < 0)
                b = x;
            else
                a = x;
        }
        return x;
    }

    static double SecantMethod(double a, double b, double epsilon)
    {
        double x0 = a;
        double x1 = b;
        double x2;
        while (Math.Abs(f(x1)) > epsilon)
        {
            x2 = x1 - f(x1) * (x1 - x0) / (f(x1) - f(x0));
            x0 = x1;
            x1 = x2;
        }
        return x1;
    }

    static double SecantMethodG(double a, double b, double epsilon)
    {
        double x0 = a;
        double x1 = b;
        double x2;
        while (Math.Abs(g(x1)) > epsilon)
        {
            x2 = x1 - g(x1) * (x1 - x0) / (g(x1) - g(x0));
            x0 = x1;
            x1 = x2;
        }
        return x1;
    }
}