/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of PorNombre. 
	/// </summary> //EJERCICIO 1 Práctica 2
	public class PorNombre : PoliticaComparacion  
	{
		public bool sosIgual(IAlumno comparable1, IAlumno comparable2)
		{
			Console.WriteLine(comparable1.getNombre());
			Console.WriteLine();
//			Console.WriteLine(comparable2.getNombre());
//			return comparable1.getNombre() == comparable2.getNombre();
			return true;
		}
		public bool sosMenor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getNombre()[0] < comparable2.getNombre()[0];
		}
		public bool sosMayor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getNombre()[0] > comparable2.getNombre()[0];
		}
		
	}
}
