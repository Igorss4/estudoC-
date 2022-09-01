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
// string[] names = { "Fred", "Maria", "Igor" };

//         if (string.Equals(names[0], "fred", StringComparison.OrdinalIgnoreCase))//metodo que ignora o CaseSensitive
//         {
//             Console.WriteLine("Igual");
//         }

//         foreach (string name in names)
//         {
//             Console.WriteLine(name);
//         }
// string name = "Fred";
// string[] names = {"Fred", "Machado"};
// Console.WriteLine(name.Length);//imprime a quantidade de caracteres da string
// Console.WriteLine(name.EndsWith("ed"));//verifica se a string termina com o valor setado e retorna boolean
// Console.WriteLine(name.StartsWith("Fr"));//verifica se a string inicia com o valor setado e retorna boolean
// Console.WriteLine(name.Contains("e"));//verifica se a string contem com o valor setado e retorna boolean
// Console.WriteLine(name.IndexOf("r"));//retorna o indice do array da string(primeiro indice)(retorna -1 se nao existe)
// Console.WriteLine(string.IsNullOrEmpty(name));//verifica se a string é nula ou vazia e retorna boolean
// Console.WriteLine(string.IsNullOrWhiteSpace(name));//verifica se a string é nula ou é espaço em branco e retorna boolean
// Console.WriteLine(string.Join(' ', names));//junta as strings de uma array ( primeiro parametro é o que aciona a junção, segundo o array)
// int i = 10;
// if (int.TryParse("asds", out int x))//tenta a conversao de string a int, retornando verdadeiro atribui o valor a variavel
// {
//     Console.WriteLine("Sucesso!");
// } else {
//     Console.WriteLine("Erro!");
// }
// Console.WriteLine(x);
// int i = 10;
// long l = 10;

// l = i;//long é maior por isso é possivel atribuir o valor de int em long mas nao o contrario
// i = (int)l;//conversão explicita de int pra long(mas pode ser perdido dados por nao ter espaço no int)

// string s = l.ToString();//metodo que converte outro tipo em variavel

class Program
{
    static void Main()
    {
        int i = 10;
        int i2 = i;
        i2 = 20;

        Test t = new Test();
        t.x = 12;

        Test t2 = t;
        t2.x = 22;

        Console.WriteLine(t.x);
    }
}


class Test
{
    public int x;
}