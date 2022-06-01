string operacao = args[0];
double n1 = Convert.ToDouble (args[1]);
double n2 = Convert.ToDouble (args[2]);

//dotnet run -- Somar 1,3 2,5
if(operacao == "Somar")
{
    Console.WriteLine(n1+n2);
}
