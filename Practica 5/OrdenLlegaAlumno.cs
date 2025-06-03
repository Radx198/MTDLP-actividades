/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 3/6/2025
 * Time: 15:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary> EJERCICIO 7 Práctica 5
	public class OrdenLlegaAlumno : OrdenAula2
	{
		private Aula aula;
		public OrdenLlegaAlumno(Aula a)
		{
			aula = a;
		}
		public void ejecutar(Comparable c)
		{
			Console.WriteLine("Nuevo alumno...");
		}
	}
}
