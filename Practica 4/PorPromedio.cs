/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of PorPromedio.
	/// </summary> //EJERCICIO 1 Práctica 2
	public class PorPromedio : PoliticaComparacion
	{
		public bool sosIgual(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getPromedio().GetValor() == comparable2.getPromedio().GetValor();
		}
		public bool sosMenor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getPromedio().GetValor() < comparable2.getPromedio().GetValor();
		}
		public bool sosMayor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getPromedio().GetValor() > comparable2.getPromedio().GetValor();
		}

	}
}
