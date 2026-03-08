namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1003 : ExercicioBase
{
    public override void Executar()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        int soma = a + b;
        
        Console.WriteLine($"SOMA = {soma}");
    }
}