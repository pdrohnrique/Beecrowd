namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1002 : ExercicioBase
{
    public override void Executar()
    {
        double r = double.Parse(Console.ReadLine());
        double area = 3.14159 * r * r;
        
        Console.WriteLine($"A={area:F4}");
    }
}