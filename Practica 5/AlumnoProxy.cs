/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 3/6/2025
 * Time: 11:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
namespace Practica_5
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy : Persona, IAlumno
	{ //EJERCICIO 1 Práctica 5
		private Alumno alumno = null;
		private Numero legajo;
		private Numero promedio;
		protected PoliticaComparacion comparacion;
		protected List<IObservador> observadorAlumnoFavorito; //EJERCICIO 15 Práctica 3
		private Numero calificacion; //EJERCICIO 1 Práctica 4
		
		public AlumnoProxy(string n, Numero d, Numero l, Numero p) : base(n, d)
		{
			legajo = l;
			promedio = p;
			comparacion = new PorLegajo();
			observadorAlumnoFavorito = new List<IObservador>();
			
		}
		public Numero getLegajo(){return legajo;}
		
		public Numero getPromedio(){return promedio;}
		
		public void setComparacion(PoliticaComparacion nuevaPolitica) {comparacion = nuevaPolitica;}
		
		public override string ToString(){return getNombre() + " " + legajo.ToString() + " " + promedio + " " + getDNI() + "\n";}
		
		public Numero getCalificacion(){return calificacion;}//EJERCICIO 1 Práctica 4
		
		public void setCalificacion(Numero calificacion){this.calificacion = calificacion;}
		
		public virtual int responderPregunta(int pregunta)
		{
			if (alumno == null)
			{
				alumno = new Alumno(base.getNombre(),base.getDNI(),legajo,promedio);
			}//new Random().Next(1,4)
			return alumno.responderPregunta(pregunta);
			
		}
		
		public virtual string mostrarCalificacion(){return getNombre() + "       " + getCalificacion();}
		
		
		public virtual Alumno getAlumno()  // Método utilizado por comparable y decorado, si previamente no se llama respoderPregunta() 
			// y en su lugar se utiliza comparaciones o se acceden a getters por medio del getAlumno el programa lanzará una excepción de System.NullReferenceException:
		{
			if (alumno == null)
			{
				alumno = new Alumno(base.getNombre(),base.getDNI(),legajo,promedio);
			}
			return alumno;
		}
		
		
		
		
		
		//EJERCICIO 15 Práctica 1
		//métodos implementados por la interfaz Comparable
		
		public override bool sosIgual(Comparable comparable){
//			return legajo.GetValor() == (((Alumno)comparable).getLegajo()).GetValor();
			return comparacion.sosIgual(getAlumno(),(IAlumno)comparable);
		}
		
		public override bool sosMenor(Comparable comparable)
		{
//			return legajo.GetValor() < (((Alumno)comparable).getLegajo()).GetValor();
			return comparacion.sosMenor(getAlumno(),(Alumno)comparable);
		}
		
		public override bool sosMayor(Comparable comparable)
		{
//			return legajo.GetValor() > (((Alumno)comparable).getLegajo()).GetValor();
			return comparacion.sosMayor(getAlumno(),(Alumno)comparable);
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
