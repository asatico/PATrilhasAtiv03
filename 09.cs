using System;

namespace ALEM_DE_PRETO_E_SURDO
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escreva um número:");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Escreva um número:");
			int num2 = int.Parse(Console.ReadLine());
		
			int diferenca = Math.Abs(num1 - num2);
			
			if (diferenca <= 10) {
				Console.WriteLine("A diferença entre " +num1+ " e " +num2+ " é de: " +diferenca+ " sendo menor ou igual a 10.");
			}else {
				Console.WriteLine("A diferença entre " +num1+ " e " +num2+ " é de: " +diferenca+ " sendo maior a 10.");
			}
			
			Console.Write("PRESSIONE ALGO PARA FECHAR . . . ");
			Console.ReadKey(true);
		}
	}
}
