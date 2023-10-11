string nome1;
int idade1;
string nome2;
int idade2;
string nome3;
int idade3;

try
{

Console.WriteLine("Digite o nome da pessoa :");

nome1 = Console.ReadLine();

Console.WriteLine("Digite a idade dessa pessoa :");

idade1 = int.Parse(Console.ReadLine());



Console.WriteLine("Escreva mais um nome :");

nome2 = Console.ReadLine();

Console.WriteLine("Digite a idade dessa pessoa: ");

idade2 = int.Parse(Console.ReadLine());



    Console.WriteLine("Escreva um terceiro nome: ");

nome3 = Console.ReadLine();

Console.WriteLine("Digite a idade dessa pessoa: ");

idade3 = int.Parse(Console.ReadLine());


    if(idade1 > 18 & idade2 > 18 & idade3 > 18)
    {
        Console.WriteLine("Todos são maiores de 18");
    }
    else
    {
        Console.WriteLine("Nem todos são maiores de 18 anos !!");
    }
}
catch
{
    Console.WriteLine("Valor invalido");
}