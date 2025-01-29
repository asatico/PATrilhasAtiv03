using System;

namespace ALEM_DE_PRETO_E_SURDO
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escreva um número:");
			double num1 = double.Parse(Console.ReadLine());
			
		
			
			
			if (num1 % 2 ==0) {
				Console.WriteLine("O número " +num1+ " e par.");
			}else{
				Console.WriteLine("O nùmero "+num1+ " e impar.");
			}
			
			
			
			
			
			Console.Write("PRESSIONE ALGO PARA FECHAR . . . ");
			Console.ReadKey(true);
		}
	}
}
