/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 13/5/2025
 * Time: 19:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_4
{
	/// <summary>
	/// Description of IMostrarCalificacion.
	/// </summary>
	public interface IMostrarCalificacion : Comparable
	{
		string mostrarCalificacion();
		
		string getNombre();
		
		Alumno getAlumno();
		Numero getDNI();
		Numero getLegajo();
		Numero getPromedio();
		
		string ToString();
		Numero getCalificacion();
		
		void setComparacion(PoliticaComparacion nuevaPolitica);
		
		void setCalificacion(Numero calificacion);
		
		int responderPregunta(int pregunta);
		
		bool sosIgual(Comparable comparable);
		bool sosMenor(Comparable comparable);
		bool sosMayor(Comparable comparable);
	}
}
