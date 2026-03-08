namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1004 : ExercicioBase
{
    public override void Executar()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        int produto = a * b;
        
        Console.WriteLine($"PROD = {produto}");
    }
}