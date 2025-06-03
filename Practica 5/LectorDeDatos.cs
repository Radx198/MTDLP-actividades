/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/4/2025
 * Time: 14:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of LectorDeDatos.
	/// </summary> EJERCICIO 3 Práctica 3
	public class LectorDeDatos
	{
		public int numeroPorTeclado()
		{
			string input;
			int output;
			
			do 
			{
				Console.Write("\nIngrese un numero: ");
				input = Console.ReadLine();
			} while(!int.TryParse(input, out output));

			return output;
		}
		
		public string stringPorTeclado()
		{
			return Console.ReadLine();
		} 
	}
}
