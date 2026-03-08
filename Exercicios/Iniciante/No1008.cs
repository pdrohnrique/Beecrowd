namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1008 : ExercicioBase
{
    public override void Executar()
    {
        int numero = int.Parse(Console.ReadLine());
        int horas = int.Parse(Console.ReadLine());
        double valor = double.Parse(Console.ReadLine());
        
        double salario = horas * valor;
        
        Console.WriteLine($"NUMBER = {numero}");
        Console.WriteLine($"SALARY = U$ {salario:F2}");
    }
}