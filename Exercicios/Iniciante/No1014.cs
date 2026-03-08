namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1014 : ExercicioBase
{
    public override void Executar()
    {
        int distancia = int.Parse(Console.ReadLine());
        double combustivel = double.Parse(Console.ReadLine());
        
        double consumo = distancia / combustivel;
        
        Console.WriteLine($"{consumo:F3} km/l");
    }
}