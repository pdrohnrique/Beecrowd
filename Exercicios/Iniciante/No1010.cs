namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1010 : ExercicioBase
{
    public override void Executar()
    {
        string linha1 = Console.ReadLine();
        string linha2 = Console.ReadLine();
        
        string[] dadosPeca1 = linha1.Split(' ');
        string[] dadosPeca2 = linha2.Split(' ');
        
        double valorTotal = int.Parse(dadosPeca1[1]) * double.Parse(dadosPeca1[2]) + int.Parse(dadosPeca2[1]) * double.Parse(dadosPeca2[2]);
        
        Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal:F2}");
    }
}