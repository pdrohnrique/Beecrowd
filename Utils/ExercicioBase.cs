namespace Beecrowd.Utils;

public abstract class ExercicioBase
{
    public abstract void Executar();
    
    public virtual void Exibir()
    {
        Console.WriteLine($"\n=== {GetType().Name} ===");
        Executar();
    }
}