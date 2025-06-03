/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 3/6/2025
 * Time: 12:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_5
{
	/// <summary>
	/// Description of AlumnoMuyEstudiosoProxy.
	/// </summary>
	public class AlumnoMuyEstudiosoProxy : AlumnoProxy
	{//EJERCICIO 1 Práctica 5
		private AlumnoMuyEstudioso al= null;
		public AlumnoMuyEstudiosoProxy(string n, Numero d, Numero l, Numero p) : base (n,d,l,p)
		{
			comparacion = new PorLegajo();
			observadorAlumnoFavorito = new List<IObservador>();
		}
		public override int responderPregunta(int pregunta)
		{
			if(al == null)
				al = new AlumnoMuyEstudioso(base.getNombre(), base.getDNI(), base.getLegajo(), base.getPromedio());
			return al.responderPregunta(pregunta);
		}


	}
}
