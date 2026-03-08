namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1013 : ExercicioBase
{
    public override void Executar()
    {
        string[] entrada = Console.ReadLine().Split(' ');
        
        int a = int.Parse(entrada[0]);
        int b = int.Parse(entrada[1]);
        int c = int.Parse(entrada[2]);
        
        int maiorAB = ((a + b + Math.Abs(a - b)) / 2);
        int maiorABC = ((maiorAB + c + Math.Abs(maiorAB - c)) / 2);
        
        Console.WriteLine($"{maiorABC} eh o maior");
    }
}