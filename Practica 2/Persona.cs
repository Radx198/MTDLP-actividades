/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/3/2025
 * Time: 21:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_2
{
	/// <summary>
	/// Description of Persona.
	/// </summary> EJERCICIO 11 Práctica 1
	public abstract class Persona : Comparable
	{
		private string nombre;
		private Numero dni;
		public Persona(string n, Numero d)
		{
			nombre = n;
			dni = d;
		}
		public virtual string getNombre(){return nombre;}
	
		public Numero getDNI(){return dni;}
		
		//métodos implementados por la interfaz Comparable
		public virtual bool sosIgual(Comparable comparable){
			return dni.GetValor() == (((Persona)comparable).getDNI()).GetValor();
		}
		
		public virtual bool sosMenor(Comparable comparable)
		{
			return dni.GetValor() < (((Persona)comparable).getDNI()).GetValor();
		}
		
		public virtual bool sosMayor(Comparable comparable)
		{
			return dni.GetValor() > (((Persona)comparable).getDNI()).GetValor();
		}
		
		
	}
}
