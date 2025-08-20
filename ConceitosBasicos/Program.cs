using System.ComponentModel.Design;

byte idade;
string nome;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Olá " + nome + ", a idade informada foi {0}", idade);

//altere o programa para que solicite ao usuário informar o seu salário e ao final informe o desconto de IRPF de acordo com o salário informado, utilize a tabela oficial de desconto de IRPF do Brasil

try
{
    decimal salario;

    Console.WriteLine("Digite o seu salário: ");
    salario = Convert.ToDecimal(Console.ReadLine());

    decimal salarioComDesconto = 0m;

    if (salario < 3036m)
        salarioComDesconto = salario;
    else if (salario >= 3036m && salario < 3533.30m)
        salarioComDesconto = salario - ((salario * 0.075m) - 182.16m);
    else if (salario >= 3533.31m && salario < 4688.85m)
        salarioComDesconto = salario - ((salario * 0.15m) - 394.16m);
    else if (salario >= 4688.85m && salario < 5830.85m)
        salarioComDesconto = salario - ((salario * 0.225m) - 675.49m);
    else if (salario >= 5830.85m)
        salarioComDesconto = salario - ((salario * 0.275m) - 908.73m);

    Console.WriteLine($"O seu salário após o desconto do IRPF será: {salarioComDesconto:C2}");
}
catch (FormatException)
{
    Console.WriteLine("Digite apenas valores numéricos");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Entre em contato com o suporte técnico.");
    Console.WriteLine(e.ToString());
}
