// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um valor:");
float valorum = float.Parse (Console.ReadLine());
Console.WriteLine("Digite outro valor:");
float valordois = float.Parse (Console.ReadLine());

float resto =  valorum % valordois;

if(resto == 0)
{
    Console.WriteLine("É divisivel");
}
else
{
    Console.WriteLine("Não é divisivel");
}

