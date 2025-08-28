/*using System.ComponentModel.Design;
*
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
}*/

using ConceitosBasicos.uteis;

string opcao = "";
while (opcao != "0")
{
    Console.WriteLine("O que você quer fazer ?");
    Console.WriteLine("[0] Sair");
    Console.WriteLine("[1] Somar dois números");
    Console.WriteLine("[2] Transformar metros em milímetros");
    Console.WriteLine("[3] Calcular aumento de salário");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "0":
            Console.WriteLine("Você saiu");
            break;
        case "1":
            Console.WriteLine("Você escolheu somar dois números");

            SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();

            Console.WriteLine("Digíte o primeiro número: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digíte o segundo número: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int result;
            result = somaDoisNumeros.Somar(n1, n2);
            Console.WriteLine($"A Soma de {n1} e {n2} é {result}");

            break;
        case "2":
            Console.WriteLine("Você escolheu transformar metros em milímetros");

            MetrosMilimetros metrosMilimetros = new MetrosMilimetros();

            Console.WriteLine("Digite o número em metros para que seja convertido mara milímetros: ");
            double metros = Convert.ToDouble(Console.ReadLine());
            double milimetros = MetrosMilimetros.Converter(metros);
            Console.WriteLine($"O resultado da conversão é {milimetros}");

            break;
        case "3":
            Console.WriteLine("Você escolheu a opção calcular o aumento do salário");

            CalculaAumento calculaAumento = new CalculaAumento();

            Console.Write("Informe seu salário: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Informe o percentual de aumento: ");
            decimal percentual = Convert.ToDecimal(Console.ReadLine());

            decimal salarioComAumento = calculaAumento.Calcular(salario, percentual);
            Console.WriteLine($"Para o salário {salario} e percentual {percentual}, o valor do salário com aumento será {salarioComAumento}");

            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}


Console.WriteLine("Programa finalizado");