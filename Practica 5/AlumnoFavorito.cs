/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 26/4/2025
 * Time: 17:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_5
{
	/// <summary>
	/// Description of AlumnoFavorito.
	/// </summary> EJERCICIO 15 Práctica 3
	public class AlumnoFavorito : Alumno, IObservador, IObservado
	{
		public List<IObservador> profesor;
		public AlumnoFavorito(string n, Numero d, Numero l, Numero p) : base (n,d,l,p)
		{
			profesor = new List<IObservador>();
		}
		public override void distraerse()
		{
			Console.WriteLine("Yo nunca me distraigo, siempre presto atención.");
		}
		
		//métodos implementados por la interfaz IObservador
		public override void actualizar(string accion) // Recibe tanto acciones del profesor(escribir o hablar) como acciones de sus compañeros(avion de papel)
		{
			if (accion == "escribir")
				distraerse();
			else if(accion == "AvionDePapel")
				notificar(accion);
			else prestarAtencion();
			
		}
		
		
		//métodos implementados por la interfaz IObservado
		public override void agregarObservador(IObservador o)
		{
			profesor.Add(o);
		}
		public override void quitarObservador(IObservador o)
		{
			profesor.Remove(o);
		}
		public override void notificar(string accion)
		{
			foreach(IObservador o in profesor)
				o.actualizar(accion);
		}
		
	}
}
