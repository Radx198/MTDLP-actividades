/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 13/5/2025
 * Time: 19:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of AdicionalDecorator.
	/// </summary> EJERCICIO 6 Práctica 4
	public abstract class AdicionalDecorator : IMostrarCalificacion
	{
		protected IMostrarCalificacion calificacion;
		public AdicionalDecorator(IMostrarCalificacion calificacion)
		{
			this.calificacion = calificacion;
		}
		public virtual string mostrarCalificacion()
		{
			return calificacion.mostrarCalificacion();
		}
		public Alumno getAlumno(){return (Alumno)calificacion.getAlumno();}
		
		public virtual string getNombre(){return calificacion.getNombre();}
		
		public Numero getDNI(){return calificacion.getDNI();}
		
		public virtual Numero getLegajo()
		{
			return calificacion.getLegajo();
		}
		public virtual Numero getPromedio()
		{
			return calificacion.getPromedio();
		}
		
		public virtual string ToString()
		{
			return calificacion.ToString();
		}
		public virtual Numero getCalificacion()
		{
			return calificacion.getCalificacion();
		}
		

		public virtual void setComparacion(PoliticaComparacion nuevaPolitica) {calificacion.setComparacion(nuevaPolitica);}
		
		public virtual void setCalificacion(Numero c){calificacion.setCalificacion(c);}
		
		public virtual int responderPregunta(int pregunta){return calificacion.responderPregunta(pregunta);}
		

		
		
		public virtual bool sosIgual(Comparable comparable)
		{
			return calificacion.sosIgual(comparable);
		}
		public virtual bool sosMenor(Comparable comparable)
		{
			return calificacion.sosMenor(comparable);
		}
		public virtual bool sosMayor(Comparable comparable)
		{
			return calificacion.sosMayor(comparable);
		}
	}
}
