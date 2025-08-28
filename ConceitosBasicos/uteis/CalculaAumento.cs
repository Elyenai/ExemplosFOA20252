using System;

namespace ConceitosBasicos.uteis
{
	public class CalculaAumento
		{
			public decimal Calcular(decimal salario, decimal percentual)
			{
				return salario + (salario * (decimal)percentual / 100);
			}
		}
}