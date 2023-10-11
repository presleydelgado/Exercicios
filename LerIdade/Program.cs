try { 
Console.WriteLine("Digite o nome de uma pessoa :");

string nome1 = Console.ReadLine();

Console.WriteLine(nome1 + " Agora digite a idade dessa pessoa :");

int idade1 = int.Parse(Console.ReadLine());

Console.WriteLine(nome1 + " Tem " + idade1 + " anos");



Console.WriteLine("Digite um segundo nome de uma pessoa :");

string nome2 = Console.ReadLine();

Console.WriteLine(nome2 + " Agora digite a idade dessa pessoa novamente :");

int idade2 = int.Parse(Console.ReadLine());

Console.WriteLine(nome2 + " Tem " + idade2 + " anos");


Console.WriteLine("Digite um terceiro nome de uma pessoa :");

string nome3 = Console.ReadLine();

Console.WriteLine(nome3 + " Agora digite novamente a idade dessa pessoa :");

int idade3 = int.Parse(Console.ReadLine());

Console.WriteLine(nome3 + " Tem " + idade3 + " anos");

if (idade1 > 18)
{
    Console.WriteLine(nome1 + " é maior que 18 anos");
}
else
{
    Console.WriteLine(nome1 + " é de menor");
}

if (idade2 > 18)
{
    Console.WriteLine(nome2 + " é maior que 18 anos");
}
else
{
    Console.WriteLine(nome2 + " é de menor");
}

if (idade3 > 18)
{
    Console.WriteLine(nome3 + " é maior que 18 anos");
}
else
{
    Console.WriteLine(nome3 + " é de menor");
}
}

catch
{
    Console.WriteLine("Valor invalido");
}




