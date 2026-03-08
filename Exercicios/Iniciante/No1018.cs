namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1018 : ExercicioBase
{
    public override void Executar()
    {
        int valorInicial = int.Parse(Console.ReadLine());
        int valor = valorInicial;
        
        int notas100 = valor / 100;
        valor %= 100;
        int notas50 = valor / 50;
        valor %= 50;
        int notas20 = valor / 20;
        valor %= 20;
        int notas10 = valor / 10;
        valor %= 10;
        int notas5 = valor / 5;
        valor %= 5;
        int notas2 = valor / 2;
        valor %= 2;
        
        Console.WriteLine(valorInicial);
        Console.WriteLine($"{notas100} nota(s) de R$ 100,00");
        Console.WriteLine($"{notas50} nota(s) de R$ 50,00");
        Console.WriteLine($"{notas20} nota(s) de R$ 20,00");
        Console.WriteLine($"{notas10} nota(s) de R$ 10,00");
        Console.WriteLine($"{notas5} nota(s) de R$ 5,00");
        Console.WriteLine($"{notas2} nota(s) de R$ 2,00");
        Console.WriteLine($"{valor} nota(s) de R$ 1,00");
    }
}