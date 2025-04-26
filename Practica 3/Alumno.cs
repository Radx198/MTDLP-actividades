/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 24/3/2025
 * Time: 22:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_3
{
	/// <summary>
	/// Description of Alumno.
	/// </summary> EJERCICIO 12 Práctica 1
	public class Alumno : Persona, IObservador, IObservado
	{
		private Numero legajo;
		private Numero promedio;
		private PoliticaComparacion comparacion;
		private List<IObservador> observadorAlumnoFavorito; //EJERCICIO 15 Práctica 3
		public Alumno(string n, Numero d, Numero l, Numero p) : base(n, d)
		{
			legajo = l;
			promedio = p;
			comparacion = new PorNombre();
			observadorAlumnoFavorito = new List<IObservador>();
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
		
		//EJERCICIO 11 Práctica 3
		public void prestarAtencion()
		{
			Console.WriteLine("Prestando atención...");
		}
		public virtual void distraerse() // Métodos virtuales porque la subclase AlumnoFavorito emplea una lógica diferente.
		{
			string[] acciones = new string[]{"Mirando el celular", "Dibujando en el margen de la carpeta.", "Tirando aviones de papel."};
			Random rnd = new Random();
			int indice = rnd.Next(3);
			
			Console.WriteLine(acciones[indice]);
			
			if(indice == 2)
				notificar("AvionDePapel");
			
			
			
		}
		
		
		//EJERCICIO 12 Práctica 3
		//métodos implementados por la interfaz IObservador
		public virtual void actualizar(string accion)
		{
			if (accion == "escribir")
				distraerse();
			else
				prestarAtencion();
		}
		
		
		//EJERCICIO 15 Práctica 3
		//métodos implementados por la interfaz IObservador 
		public virtual void agregarObservador(IObservador o)
		{
			observadorAlumnoFavorito.Add(o);
		}
		public virtual void quitarObservador(IObservador o)
		{
			observadorAlumnoFavorito.Remove(o);
		}
		public virtual void notificar(string accion)
		{
			foreach(IObservador o in observadorAlumnoFavorito)
				o.actualizar(accion); 
		}
		
	}
}
