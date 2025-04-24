/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 21:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of PorDNI.
	/// </summary> //EJERCICIO 1 Práctica 2
	public class PorDNI : PoliticaComparacion
	{
		public bool sosIgual(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getDNI().GetValor() == comparable2.getDNI().GetValor();
		}
		public bool sosMenor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getDNI().GetValor() < comparable2.getDNI().GetValor();
		}
		public bool sosMayor(Alumno comparable1, Alumno comparable2)
		{
			return comparable1.getDNI().GetValor() > comparable2.getDNI().GetValor();
		}
	}
}
