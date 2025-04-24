/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/3/2025
 * Time: 22:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Alumno.
	/// </summary> EJERCICIO 12 Práctica 1
	public class Alumno : Persona
	{
		private Numero legajo;
		private Numero promedio;
		private PoliticaComparacion comparacion;
		public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
		{
			legajo = l;
			promedio = p;
			comparacion = new PorNombre();
		}
		public Numero getLegajo(){return legajo;}
		
		public Numero getPromedio(){return promedio;}
		
		public void setComparacion(PoliticaComparacion nuevaPolitica) {comparacion = nuevaPolitica;}
		
		public override string ToString(){return getNombre() + " " + legajo.ToString() + " " + promedio + " " + getDNI() + "\n";}
		
		
		
		
		
		//EJERCICIO 15 Práctica 1
		//métodos implementados por la interfaz Comparable
		
		public override bool sosIgual(Comparable comparable){
//			return legajo.GetValor() == (((Alumno)comparable).getLegajo()).GetValor();
			return comparacion.sosIgual(this,(Alumno)comparable);
		}
		
		public override bool sosMenor(Comparable comparable)
		{
//			return legajo.GetValor() < (((Alumno)comparable).getLegajo()).GetValor();
			return comparacion.sosMenor(this,(Alumno)comparable);
		}
		
		public override bool sosMayor(Comparable comparable)
		{
//			return legajo.GetValor() > (((Alumno)comparable).getLegajo()).GetValor();
			return comparacion.sosMayor(this,(Alumno)comparable);
		}
		
		
		
	}
}
