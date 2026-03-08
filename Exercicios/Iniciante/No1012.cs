namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1012 : ExercicioBase
{
    public override void Executar()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        
        double a = double.Parse(entrada[0]);
        double b = double.Parse(entrada[1]);
        double c = double.Parse(entrada[2]);
        
        double areaTriangulo = (a * c) / 2;
        double areaCirculo = 3.14159 * Math.Pow(c, 2);
        double areaTrapezio = ((a + b) * c) / 2;
        double areaQuadrado = Math.Pow(b, 2);
        double areaRetangulo = a * b;
        
        Console.WriteLine($"TRIANGULO: {areaTriangulo:F3}");
        Console.WriteLine($"CIRCULO: {areaCirculo:F3}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio:F3}");
        Console.WriteLine($"QUADRADO: {areaQuadrado:F3}");
        Console.WriteLine($"RETANGULO: {areaRetangulo:F3}");
    }
}