double SalarioPedro = 0;
Console.WriteLine("Digite o valor do salario de Pedro: ");
SalarioPedro = double.Parse(Console.ReadLine());

double SalarioAna = 0;
Console.WriteLine("Digite o valor do salario de Ana: ");
SalarioAna = double.Parse(Console.ReadLine());

double SalarioJorge = 0;
Console.WriteLine("Digite o valor do salario de Jorge: ");
SalarioJorge = double.Parse(Console.ReadLine());



double SalarioReajustado = 0;

if (SalarioPedro >= 300)
{
    SalarioReajustado = (SalarioPedro * 1.3);
    Console.WriteLine("O salário reajustado de Pedro é: R$ " + SalarioReajustado);
}
else
{
    SalarioReajustado = (SalarioPedro * 1.5);
    Console.WriteLine("O salário reajustado de Pedro é: R$ " + SalarioReajustado);

}

if (SalarioAna >= 300)
{
    SalarioReajustado = (SalarioAna * 1.3);
    Console.WriteLine("O salário reajustado de Ana é: R$ " + SalarioReajustado);
}
else
{
    SalarioReajustado = (SalarioAna * 1.5);
    Console.WriteLine("O salário reajustado de Ana é: R$ " + SalarioReajustado);

}

if (SalarioJorge >= 300)
{
    SalarioReajustado = (SalarioJorge * 1.3);
    Console.WriteLine("O salário reajustado de Jorge é: R$ " + SalarioReajustado);
}
else
{
    SalarioReajustado = (SalarioJorge * 1.5);
    Console.WriteLine("O salário reajustado de Jorge é: R$ " + SalarioReajustado);

}
