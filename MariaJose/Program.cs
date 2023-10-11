// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite um valor: ");
try
{
    int valor = int.Parse(Console.ReadLine());
    int valorfinal = (false) ? + 4 + valor : 3 - valor; 
    Console.WriteLine(valorfinal);
}
catch
{
    Console.WriteLine("Valor invalido !!");
}







