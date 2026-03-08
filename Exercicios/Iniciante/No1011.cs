namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1011 : ExercicioBase
{
    public override void Executar()
    {
        double raio = double.Parse(Console.ReadLine());
        
        double volume = (4.0 / 3.0) * 3.14159 * Math.Pow(raio, 3);
        
        Console.WriteLine($"VOLUME = {volume:F3}");
    }
}