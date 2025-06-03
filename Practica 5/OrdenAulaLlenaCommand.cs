/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 3/6/2025
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of OrdenAulaLlenaCommand.
	/// </summary> EJERCICIO 5 Práctica 5
	public class OrdenAulaLlenaCommand : OrdenAula1
	{
		private Aula aula;
		public OrdenAulaLlenaCommand(Aula a)
		{
			aula = a;
		}
		public void ejecutar()
		{
			Console.WriteLine("Mensaje llena.");
		}
	}
}
