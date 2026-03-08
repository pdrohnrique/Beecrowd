namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1005 : ExercicioBase
{
    public override void Executar()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        
        double media = (a * 3.5 + b * 7.5) / 11;
        
        Console.WriteLine($"MEDIA = {media:F5}");
    }
}