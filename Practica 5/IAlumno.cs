/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 3/6/2025
 * Time: 11:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno : Comparable, IObservador, IObservado, IMostrarCalificacion
	{
		Numero getLegajo();

		Numero getPromedio();

		void setComparacion(PoliticaComparacion nuevaPolitica);

		string ToString();

		Numero getCalificacion();

		void setCalificacion(Numero calificacion);

		int responderPregunta(int pregunta);

		string mostrarCalificacion();

		Alumno getAlumno();
		// EJERCICIO 15 Práctica 1
		// Métodos implementados por la interfaz Comparable

		bool sosIgual(Comparable comparable);

		bool sosMenor(Comparable comparable);

		bool sosMayor(Comparable comparable);

		// EJERCICIO 11 Práctica 3
		void prestarAtencion();

		void distraerse(); // La subclase AlumnoFavorito emplea una lógica diferente.

		// EJERCICIO 12 Práctica 3
		// Métodos implementados por la interfaz IObservador
		void actualizar(string accion);

		// EJERCICIO 15 Práctica 3
		// Métodos implementados por la interfaz IObservador
		void agregarObservador(IObservador o);

		void quitarObservador(IObservador o);

		void notificar(string accion);

	}
}
