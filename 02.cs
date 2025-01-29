/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 24/01/2025
 * Time: 10:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
			
			
			if (num1 > num2 ) {
				Console.WriteLine("O " +num1+ " e maior que o " + num2);
			} else {
				Console.WriteLine("O " +num2+ " e menor  que o " +num1);
			}
			
			
			
			
			Console.Write("PRESSIONE ALGO PARA FECHAR . . . ");
			Console.ReadKey(true);
		}
	}
}
