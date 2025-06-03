/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 13/5/2025
 * Time: 15:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of AlumnoAdapter.
	/// </summary>
	public class AlumnoAdapter : Student
	{
		public IMostrarCalificacion _alumno;
		public AlumnoAdapter(IMostrarCalificacion alumno)
		{
			this._alumno = alumno;
		}
		public string getName(){return _alumno.getNombre();}
		
		public int yourAnswerIs(int question){return _alumno.responderPregunta(question);}
		
		public void setScore(int score){_alumno.setCalificacion(new Numero(score));}
		
		public string showResult(){return _alumno.mostrarCalificacion();}
		
		public IMostrarCalificacion getAlumno(){return _alumno.getAlumno();} // Si no se implementa este método, los métodos de comparación se compararán
		// con un Alumno y un AlumnoAdapter
		
		public bool equals(Student student){return _alumno.sosIgual(((AlumnoAdapter)student).getAlumno());}
		
		public bool lessThan(Student student){return _alumno.sosMenor(((AlumnoAdapter)student).getAlumno());}
		
		public bool greaterThan(Student student){return _alumno.sosMayor(((AlumnoAdapter)student).getAlumno());}
	}
}
