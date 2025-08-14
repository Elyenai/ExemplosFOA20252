using System.ComponentModel.Design;

byte idade;
string nome;

Console.WriteLine("Digite seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Digite sua idade: ");
idade = Convert.ToByte(Console.ReadLine());

Console.WriteLine("Olá " + nome + ", a idade informada foi {0}", idade);

decimal salario;

//altere o programa para que solicite ao usuário informar o seu salário e ao final informe o desconto de IRPF de acordo com o salário informado, utilize a tabela oficial de desconto de IRPF do Brasil

Console.WriteLine("Digite o seu salário: ");
salario = Convert.ToDecimal(Console.ReadLine());

decimal salarioComDesconto = 0m;

if (salario < 3036m)
{
    salarioComDesconto = salario;
    Console.WriteLine($"Seu salário não terá desconto do IRPF e continuará: {salario}");
}
else { 
if (salario >= 3036m && salario < 3533.30m)
{
    salarioComDesconto = salario - ((salario * 0.075m) - 182.16m);
}

if (salario >= 3533.31m && salario < 4688.85m) 
{
    salarioComDesconto = salario - ((salario * 0.15m) - 394.16m);
        }

if (salario >= 4688.85m && salario < 5830.85m)
{
    salarioComDesconto = salario - ((salario * 0.225m) - 675.49m);
        }

if (salario >= 5830.85m)
{
    salarioComDesconto = salario - ((salario * 0.275m) - 908.73m);
}

Console.WriteLine($"O seu salário após o desconto do IRPF será: {salarioComDesconto}");}