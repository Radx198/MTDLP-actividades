/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/4/2025
 * Time: 13:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
namespace Practica_5
{
	/// <summary>
	/// Description of GeneradorDeDatosAleatorios.
	/// </summary> EJERCICIO 2 Práctica 3
	public class GeneradorDeDatosAleatorios
	{
		private static Random rnd = new Random();
		public int numeroAleatorio(int max)
		{
			return rnd.Next(max+1);
		}
		public string stringAleatorio(int cant)
		{
			string abecedario = "abcdefghijklmnñopqrstuvwxyz";
			StringBuilder resutado = new StringBuilder();
			
			for(int i=0; i<cant; i++)
			{
				resutado.Append(abecedario[rnd.Next(27)]);
			}
			
			return resutado.ToString();
		}
	}
}
