var masculino = "true" ;
var feminino = "false";
double altura = 0;


/* calculo  masculino */

double valorm1 = 72.7;
double valorm2 = -58;
double massam1 = (valorm1 * altura) - valorm2;

/* calculo feminino */

double valorf1 = 62.1;
double valorf2 = -44.7;
double massaf1 = (valorf1 * altura) - valorf2;

try { 
Console.WriteLine("Qual o seu sexo ?");

masculino = Console.ReadLine();


Console.WriteLine("Qual a sua altura ?");

altura = double.Parse(Console.ReadLine());

    if (true)
{
    Console.WriteLine("Para o seu sexo masculino o seu peso ideal é de : " + massam1 + " KG" );
}
    if (false)
{
    Console.WriteLine("Para o seu sexo feminino o seu peso ideal é de : " + massaf1 + " KG");
}
 }
catch
{
    Console.WriteLine("ESTOY LOCO");
}