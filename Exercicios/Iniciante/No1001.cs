namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1001 : ExercicioBase
{
    public override void Executar()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int x = a + b;
        
        Console.WriteLine($"X = {x}");
    }
}