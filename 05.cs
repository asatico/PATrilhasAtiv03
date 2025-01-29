using System;

namespace ALEM_DE_PRETO_E_SURDO
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escreva um número:");
			double num1 = double.Parse(Console.ReadLine());
			Console.WriteLine("Escreva um número:");
			double num2 = double.Parse(Console.ReadLine());
		
			
			
			if (num1 >= num2 ) {
				Console.WriteLine("O " +num1+ " e maior ou igual a  " + num2);
			} 
			
			
			
			
			
			Console.Write("PRESSIONE ALGO PARA FECHAR . . . ");
			Console.ReadKey(true);
		}
	}
}
