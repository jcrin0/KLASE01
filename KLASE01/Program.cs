using System;

using System;

class Trokut
{
    public double A, B, C;

    public Trokut(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
    }

    public double Opseg()
    {
        return A + B + C;
    }
    public double Povrsina()
    {
        double s = Opseg() / 2;
        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    }

}
class Porgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("Unesite duljine stranica trokuta: ");
        Console.Write("Stranica a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Stranica b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Stranica c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Trokut trokut = new Trokut(a, b, c);

        Console.WriteLine($"Opseg trokuta: {trokut.Opseg():F2}");
        Console.WriteLine($"Povrsina trokuta: {trokut.Povrsina():F2}"
        );

    }
}
