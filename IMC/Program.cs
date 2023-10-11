double altura;
string sexo;


try { 
Console.WriteLine("Qual o seu sexo ?");

sexo = Console.ReadLine();


Console.WriteLine("Qual a sua altura ?");

altura = double.Parse(Console.ReadLine());

    if (sexo == "masculino")
{
        double valorm1 = 72.7;
        double valorm2 = 58;
        double valorm3 = (valorm1 * altura); 
        double valorm4 = (valorm3 - valorm2);

        Console.WriteLine("Para o seu sexo masculino o seu peso ideal é de : " + valorm4 + " KG" );
}
    if (sexo == "feminino")
{

        double valorf1 = 62.1;
        double valorf2 = -44.7;
        double massaf1 = (valorf1 * altura) - valorf2;

        Console.WriteLine("Para o seu sexo feminino o seu peso ideal é de : " + massaf1 + " KG");
}
 }
catch
{
    Console.WriteLine("ESTOY LOCO");
}