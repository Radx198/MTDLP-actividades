/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/4/2025
 * Time: 15:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_5
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>   EJERCICIO 8 Práctica 3
	public class Profesor : Persona, IObservado, IObservador
	{
		private Numero antiguedad;
		private List<IObservador> observadores;
		public Profesor(string n, Numero d, Numero a) : base(n ,d)
		{
			antiguedad = a;
			observadores = new List<IObservador>();
		}
		public Numero getAntiguedad()
		{
			return antiguedad;
		}
		public void hablarALaClase()
		{
			Console.WriteLine("Hablando de algún tema...");
			notificar("hablar");
		}
		public void escribirEnElPizarron()
		{
			Console.WriteLine("Escribiendo en el pizarrón...");
			notificar("escribir");
		}
		
		//EJERCICIO 9 Práctica 3
		//métodos implementados por la interfaz Comparable
		public override bool sosIgual(Comparable comparable)
		{
			return antiguedad.GetValor() == ((Profesor)comparable).getAntiguedad().GetValor();
		}
		public override bool sosMenor(Comparable comparable)
		{
			return antiguedad.GetValor() < ((Profesor)comparable).getAntiguedad().GetValor();
		}
		public override bool sosMayor(Comparable comparable)
		{
			return antiguedad.GetValor() > ((Profesor)comparable).getAntiguedad().GetValor();
		}
		
		
		//EJERCICIO 12 Práctica 3
		//métodos implementados por la interfaz IObservador
		public void agregarObservador(IObservador o)
		{
			observadores.Add(o);
		}
		public void quitarObservador(IObservador o)
		{
			observadores.Remove(o);
		}
		public void notificar(string accion)
		{
			foreach(IObservador o in observadores)
				o.actualizar(accion); // Notifica tanto a los alumnos como a su favorito
		}
		
		
		
		//EJERCICIO 15 Práctica 3
		public void hacerSilencio()
		{
			Console.WriteLine("Silencio, no se distraigan.");
		}
		
		//métodos implementados por la interfaz IObservador
		public void actualizar(string accion)//El alumno favorito le avisa si sus compañeros lanzan aviones de papel
		{
			hacerSilencio();
		}
	}
}
