// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i;
int i2 = i = 10;

//se o valor de "i2" for o mesmo que 42 é true(saida 10) se for false saida 20.
i = i2 == 42 ? 10 : 20;

Console.WriteLine(i2);