namespace Beecrowd.Exercicios.Iniciante;

using Utils;

public class No1020 : ExercicioBase
{
    public override void Executar()
    {
        int idadeDias = int.Parse(Console.ReadLine());
        
        int anos = idadeDias / 365;
        int meses = (idadeDias % 365) / 30;
        int dias = (idadeDias % 365) % 30;
        
        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}