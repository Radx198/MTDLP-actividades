/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of PorLegajo.
	/// </summary> //EJERCICIO 1 Práctica 2
	public class PorLegajo : PoliticaComparacion
	{
		public bool sosIgual(IAlumno comparable1, IAlumno comparable2)
		{
			return comparable1.getLegajo().GetValor() == comparable2.getLegajo ().GetValor();
		}
		public bool sosMenor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getLegajo().GetValor() < comparable2.getLegajo().GetValor();
		}
		public bool sosMayor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getLegajo().GetValor() > comparable2.getLegajo().GetValor();
		}
	}
}
