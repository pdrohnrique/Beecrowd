namespace Beecrowd;

using Exercicios.Iniciante;
using Utils;

class Program
{
    static void Main(string[] args)
    {
        var exercicios = new Dictionary<string, ExercicioBase>
        {
            ["1000"] = new No1000(),
            ["1001"] = new No1001(),
            ["1002"] = new No1002(),
            ["1003"] = new No1003(),
            ["1004"] = new No1004(),
            ["1005"] = new No1005(),
            ["1006"] = new No1006(),
            ["1007"] = new No1007(),
            ["1008"] = new No1008(),
            ["1009"] = new No1009(),
            ["1010"] = new No1010(),
            ["1011"] = new No1011(),
            ["1012"] = new No1012(),
            ["1013"] = new No1013(),
            ["1014"] = new No1014(),
            ["1015"] = new No1015(),
            ["1016"] = new No1016(),
            ["1017"] = new No1017(),
            ["1018"] = new No1018(),
            ["1019"] = new No1019(),
            ["1020"] = new No1020(),
            ["1021"] = new No1021(),
            // ... adicione mais conforme faz
        };

        while (true)
        {
            Console.WriteLine("\n=== Beecrowd Exercícios ===");
            Console.WriteLine("Digite o número do exercício (ou 'sair'):");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair") break;

            if (exercicios.TryGetValue(input, out var exercicio))
            {
                exercicio.Exibir();
            }
            else
            {
                Console.WriteLine("Exercício não encontrado.");
            }
        }
    }
}