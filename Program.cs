// int i;
// int i2 = i = 10;
// //se o valor de "i2" for o mesmo que 42 é true(saida 10) se for false saida 20.
// i = i2 == 42 ? 10 : 20;
// Console.WriteLine(i2);
// Console.WriteLine("Digite seu nome: ");
// string name = Console.ReadLine();
// Console.WriteLine($"Ola {name}!");
// Console.WriteLine("Digite o ano do seu nascimento: ");
// int year = int.Parse(Console.ReadLine());
// int age = 2022 - year;
// Console.WriteLine($"Você tem {age} anos.");

// if (age >= 17)
// {
//     Console.WriteLine("Você é maior de idade!");
// }
// else if (age == 12)
// {
//     Console.WriteLine("Você tem 12 anos!");
// }
// else
// {
//     Console.WriteLine("Você é menor de idade!");
// }
class Program
{
    static void Main()
    {
        string[] names = { "Fred", "Maria", "Igor" };

        if (string.Equals(names[0], "fred", StringComparison.OrdinalIgnoreCase))//metodo que ignora o CaseSensitive
        {
            Console.WriteLine("Igual");
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
