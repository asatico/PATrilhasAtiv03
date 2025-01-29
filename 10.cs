using System;

namespace ALEM_DE_PRETO_E_SURDO
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Escreva um número:");
			double num1 = double.Parse(Console.ReadLine());
			
		
		    if (num1 == 0) {
				Console.WriteLine("O número e igual a 0");
			}else{ 
				Console.WriteLine("O número não igual a 0");
			}
			
			Console.Write("PRESSIONE ALGO PARA FECHAR . . . ");
			Console.ReadKey(true);
		}
	}
}
