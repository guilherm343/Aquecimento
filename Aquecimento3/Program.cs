
public class programa
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome da pessoa: ");
        String Nome = Console.ReadLine();

        Console.Write("Digite a idade da pessoa: ");
        int Idade = int.Parse(Console.ReadLine());

        if (Idade < 16)
        {
            Console.WriteLine("Não Pode votar");
        }

        else if (Idade >= 16 && Idade < 18)
        {
            Console.WriteLine("Voto Opcional");
        }
        else { Console.WriteLine("Pode votar"); }
        }
    }

