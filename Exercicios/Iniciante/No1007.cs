namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1007 : ExercicioBase
{
    public override void Executar()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        
        int diferenca = a * b - c * d;
        
        Console.WriteLine($"DIFERENCA = {diferenca}");
    }
}