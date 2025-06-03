/*
 * Created by SharpDevelop.
 * User: loren
 * Date: 2/4/2025
 * Time: 13:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_5
{
	/// <summary>
	/// Description of PoliticaComparacion.
	/// </summary> //EJERCICIO 1 Práctica 1
	public interface PoliticaComparacion
	{
		bool sosIgual(IAlumno comparable1, IAlumno comparable2);
		bool sosMenor(Alumno comparable1, Alumno comparable2);
		bool sosMayor(Alumno comparable1, Alumno comparable2);
	}
}
