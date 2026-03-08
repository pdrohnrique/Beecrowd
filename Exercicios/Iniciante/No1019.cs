namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1019 : ExercicioBase
{
    public override void Executar()
    {
        int segundos = int.Parse(Console.ReadLine());
        
        int horas = segundos / 3600;
        segundos %= 3600;
        int minutos = segundos / 60;
        segundos %= 60;
        
        Console.WriteLine($"{horas}:{minutos}:{segundos}");
    }
}