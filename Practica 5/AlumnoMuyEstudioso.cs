/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 13/5/2025
 * Time: 14:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_5
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary> EJERCICIO 2 Práctica 4
	public class AlumnoMuyEstudioso : Alumno
	{
		public AlumnoMuyEstudioso(string n, Numero d, Numero l, Numero p) : base (n,d,l,p)
		{
			comparacion = new PorLegajo();
			observadorAlumnoFavorito = new List<IObservador>();
		}
		
		public override int responderPregunta(int pregunta)
		{
			return pregunta%3;
		}
		
	}
}
