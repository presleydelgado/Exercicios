string nome1;
string nome2;

int ano1;
int ano2;

int diferenca = 2023;
try
{

    Console.WriteLine("Digite o nome da primeira pessoa:");

    nome1 = Console.ReadLine();

   
    Console.WriteLine("Agora digite o ano em que essa pessoa nasceu:");

    ano1 = int.Parse(Console.ReadLine());

    /* pessoa 2 */


    Console.WriteLine("Digite o nome da segunda pessoa:");

    nome2 = Console.ReadLine();

    Console.WriteLine("Agora digite o ano em que essa pessoa nasceu:");

    ano2 = int.Parse(Console.ReadLine());

    /* calculo */

    if (ano1 < ano2)
    {
        Console.WriteLine(nome2 + " É mais novo que " + nome1 + " e tem " + (diferenca - ano2) + " anos.");
    }
    if (ano1 > ano2)
    {
        Console.WriteLine(nome2 + " É mais velho que " + nome1 + " e tem " + (diferenca - ano2) + " anos.");
    }

}

catch
{
    Console.WriteLine("Valor invalido");
}
