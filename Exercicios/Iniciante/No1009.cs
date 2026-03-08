namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1009 : ExercicioBase
{
    public override void Executar()
    {
        string nome = Console.ReadLine();
        double salarioFixo = double.Parse(Console.ReadLine());
        double vendas = double.Parse(Console.ReadLine());
        
        double salario = salarioFixo + vendas * 0.15;
        
        Console.WriteLine($"TOTAL = R$ {salario:F2}");
    }
}