namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1017 : ExercicioBase
{
    public override void Executar()
    {
        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());
        
        double litros = (tempo * velocidade) / 12.0;
        
        Console.WriteLine($"{litros:F3}");
    }
}