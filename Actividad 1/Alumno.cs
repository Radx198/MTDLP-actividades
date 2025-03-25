/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/3/2025
 * Time: 22:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary> EJERCICIO 12
	public class Alumno : Persona
	{
		private Numero legajo;
		private Numero promedio;
		public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
		{
			legajo = l;
			promedio = p;
		}
		public Numero getLegajo(){return legajo;}
		
		public Numero getPromedio(){return promedio;}
		
		
		//EJERCICIO 15
		//métodos implementados por la interfaz Comparable
		
		public override bool sosIgual(Comparable comparable){
			return legajo.GetValor() == (((Alumno)comparable).getLegajo()).GetValor();
		}
		
		public override bool sosMenor(Comparable comparable)
		{
			return legajo.GetValor() < (((Alumno)comparable).getLegajo()).GetValor();
		}
		
		public override bool sosMayor(Comparable comparable)
		{
			return legajo.GetValor() > (((Alumno)comparable).getLegajo()).GetValor();
		}
		
		
		
	}
}
