using System;

namespace ALEM_DE_PRETO_E_SURDO
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escreva um número inteiro:");
			int num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Escreva um número inteiro:");
			int num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Escreva um número inteiro:");
			int num3 = int.Parse(Console.ReadLine());
			
			
			if (num1 < num2 ) {
				Console.WriteLine("O " +num1+ " e menor que " + num2);
			} else {
				Console.WriteLine("O " +num2+ " tem  que ser maior  que " +num1);
			}
			if (num1 > num3) {
				Console.WriteLine("O " +num1+ " e maior que " + num3);
			}else{
				Console.WriteLine("O " +num1+ " tem  que ser maior  que " +num3);
			
			}
			
			
			
			
			Console.Write("PRESSIONE ALGO PARA FECHAR . . . ");
			Console.ReadKey(true);
		}
	}
}
