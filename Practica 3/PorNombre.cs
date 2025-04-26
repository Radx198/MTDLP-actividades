/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_3
{
	/// <summary>
	/// Description of PorNombre. 
	/// </summary> //EJERCICIO 1 Práctica 2
	public class PorNombre : PoliticaComparacion  
	{
		public bool sosIgual(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getNombre() == comparable2.getNombre();
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
