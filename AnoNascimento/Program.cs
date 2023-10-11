string nome1;
string nome2;

int dia1;
int mes1;
int ano1;

int dia2;
int mes2;
int ano2;

try{

Console.WriteLine("Digite o nome da primeira pessoa:");

nome1 = Console.ReadLine();

Console.WriteLine("Digite o dia em que essa pessoa nasceu:");

dia1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o mes em que essa pessoa nasceu em número:");

mes1 = int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o ano em que essa pessoa nasceu:");

ano1 = int.Parse(Console.ReadLine());

    /* pessoa 2 */


Console.WriteLine("Digite o nome da segunda pessoa:");

nome2 = Console.ReadLine();

Console.WriteLine("Digite o dia em que essa pessoa nasceu:");

dia2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o mes em que essa pessoa nasceu em número:");

mes2 = int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o ano em que essa pessoa nasceu:");

ano2 = int.Parse(Console.ReadLine());

/* calculo  cago tudo  */

if(ano1 <= ano2)
    {
        Console.WriteLine(nome1 + " É mais novo que " + nome2);
    }
    else
    {
        Console.WriteLine(nome2 + " É mais velho que " + nome1);
    }

}

catch
{
    Console.WriteLine("Valor invalido");
}
